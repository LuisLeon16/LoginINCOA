/**
@@@@   @@     @@    @@@@    @@@@@	 @@@@@
 @@    @@@@   @@   @@	   @@	@@   @@ @@     
 @@    @@ @@  @@   @@	   @@   @@	 @@@@@ 
 @@    @@  @@ @@   @@	   @@	@@	 @@ @@
@@@@   @@   @@@@    @@@@    @@@@@    @@ @@
**/

/**********************************************************************
 **********************************************************************
 * Instituto Nacional de la Colonia Cuidad Obrera de Apopa (INCOA)    *
 * © COPYRIGHT 2020 TODOS LOS DERECHOS RESERVADOS                     *
 **********************************************************************
 * INTEGRANTES:
 ********************************************************************** 
 * -> RONALD HERIBERTO ABARCA RIVAS       *    25 - 1599 - 2019       *
 * -> LUIS ANTONIO LEON ANAYA             *    25 - 0645 - 2019       *
 * -> ELÍAS JESÚS QUINTEROS ESCOBAR       *    25 - 0872 - 2019       *
 * -> BRYAN ANTONIO ROGEL ROGEL           *    25 - 0361 - 2019       *
 * -> KENIA ALEXANDRA SOLA OSORIO         *    25 - 1164 - 2019       *
 * -> LEVI ASAEL VALLE PALMA              *    25 - 0234 - 2019       *
 **********************************************************************
 * DESARROLLOS INFORMATICOS R.L.E.B.K.L & ASOCIADOS S.A DE C.V        *
***********************************************************************
**********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace LoginINCOA
{
    public partial class ModificarSecciones : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ControlConexion Controlador = new ControlConexion();

        public ModificarSecciones()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("Select * from Secciones", Controlador.Conexiones());
            // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;
            // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
            DataTable TablaRegistros = new DataTable();
            // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE SECCIONES
            MostrarRegistros.Fill(TablaRegistros);
            // INVOCANDO LA REFERENCIA QUE SEA IGUAL AL ADAPTADOR DE LLENADO DE DATOS,
            // ES DECIR, TODOS LOS REGISTROS CONTENIDOS DENTRO DE LA TABLA {SECCIONES}
            DetallesSeccionesSistema.DataSource = TablaRegistros;
            // ESTILOS DE BORDES REDONDEADOS EN BOTONES
            BotonesRedondeados.BordesRedondeados(btnModificarRegistrosSecciones); // BOTON INICIAR SESION
            BotonesRedondeados.BordesRedondeados(btnSeleccionarRegistroSeccion); // BOTON SALIR
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO {APLICABLE A SOLO CONTENEDOR DE FORMULARIO}
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ModificarSecciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Secciones' Puede moverla o quitarla según sea necesario.
            this.seccionesTableAdapter.Fill(this.incoa_systemdbDataSet.Secciones);

        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSeleccionarRegistroSeccion_Click(object sender, EventArgs e)
        {
            if (DetallesSeccionesSistema.SelectedRows.Count > 0)
            {
                txtidSeccionMod.Text = DetallesSeccionesSistema.CurrentRow.Cells["cod_seccion"].Value.ToString();
                txtnombreSeccionMod.Text = DetallesSeccionesSistema.CurrentRow.Cells["nombre"].Value.ToString(); // 
                txtSeccionMod.Text = DetallesSeccionesSistema.CurrentRow.Cells["seccion"].Value.ToString();
                txtCapacidadMod.Text = DetallesSeccionesSistema.CurrentRow.Cells["capacidad"].Value.ToString();
                Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION 
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void btnModificarRegistrosSecciones_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDANDO QUE NO EXISTAN CAMPOS VACIOS Y QUE AL MENOS EL USUARIO SELECCIONE UN REGISTRO A ACTUALIZAR
                if (txtidSeccionMod.Text.Length == 0 || txtnombreSeccionMod.Text.Length == 0 || txtSeccionMod.Text.Length == 0 || txtCapacidadMod.Text.Length == 0)
                {
                    Form NoSeleccion = new MensajeNoSeleccion();
                    NoSeleccion.Show();
                }
                else
                {
                    string query = "UPDATE Secciones SET nombre = @nombre, seccion = @seccion, Capacidad = @capacidad WHERE cod_seccion = @idseccion";

                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());

                    comando.Parameters.AddWithValue("@idseccion", txtidSeccionMod.Text); // REFERENCIA DEL ID UNICO DE CADA SECCION
                    comando.Parameters.AddWithValue("@nombre", txtnombreSeccionMod.Text);
                    comando.Parameters.AddWithValue("@seccion", txtSeccionMod.Text);
                    comando.Parameters.AddWithValue("@capacidad", txtCapacidadMod.Text);

                    comando.ExecuteNonQuery();

                    //CREANDO MENSAJE EN VENTANA FLOTANTE
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    // REFERENCIANDO EL NOMBRE DE LA TABLA A MOSTRAR LOS N DATOS CONTENIDOS EN ELLA
                    SqlCommand cmd = new SqlCommand("Select * from Secciones", Controlador.Conexiones());

                    // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;
                    // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
                    DataTable TablaRegistros = new DataTable();

                    // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE SECCIONES
                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesSeccionesSistema.DataSource = TablaRegistros;

                    txtidSeccionMod.Clear(); txtnombreSeccionMod.Clear(); txtSeccionMod.Clear(); txtCapacidadMod.Clear();
                    Controlador.CierreConexiones(); // CIERRE DE CONEXION
                }
            }
            catch (Exception)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form Duplicado = new MensajeErrorDuplicados();
                Duplicado.Show();
            }
            finally
            {
                Controlador.CierreConexiones(); // CIERRE DE CONEXION
            }
        }

        private void ModificarSecciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
/**
@@@@   @@     @@    @@@@    @@@@@	 @@@@@
 @@    @@@@   @@   @@	   @@	@@   @@ @@     
 @@    @@ @@  @@   @@	   @@   @@	 @@@@@ 
 @@    @@  @@ @@   @@	   @@	@@	 @@ @@
@@@@   @@   @@@@    @@@@    @@@@@    @@ @@
**/