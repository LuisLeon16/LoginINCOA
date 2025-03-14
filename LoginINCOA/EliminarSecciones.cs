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
    public partial class EliminarSecciones : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // CONEXION VS A BASE DE DATOS
        ControlConexion Controlador = new ControlConexion();

        public EliminarSecciones()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("Select * from Secciones", Controlador.Conexiones());
            // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;
            // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
            DataTable TablaRegistros = new DataTable();
            // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE Secciones
            MostrarRegistros.Fill(TablaRegistros);
            // INVOCANDO LA REFERENCIA QUE SEA IGUAL AL ADAPTADOR DE LLENADO DE DATOS,
            // ES DECIR, TODOS LOS REGISTROS CONTENIDOS DENTRO DE LA TABLA {secciones}
            DetallesSeccionesSistema.DataSource = TablaRegistros;
            // ESTILOS DE BORDES REDONDEADOS EN BOTONES
            BotonesRedondeados.BordesRedondeados(EliminarRegistrosSeccion); // BOTON INICIAR SESION
            BotonesRedondeados.BordesRedondeados(SeleccionarRegistroSeccion); // BOTON SALIR
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO {APLICABLE A SOLO CONTENEDOR DE FORMULARIO}
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EliminarSecciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Secciones' Puede moverla o quitarla según sea necesario.
            this.seccionesTableAdapter.Fill(this.incoa_systemdbDataSet.Secciones);

        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

        private void SeleccionarRegistroSeccion_Click(object sender, EventArgs e)
        {
            if (DetallesSeccionesSistema.SelectedRows.Count > 0)
            {
                txtIdSeccionEli.Text = DetallesSeccionesSistema.CurrentRow.Cells["cod_seccion"].Value.ToString(); // ID DE SECCION
                txtnombreSeccionEli.Text = DetallesSeccionesSistema.CurrentRow.Cells["nombre"].Value.ToString(); // NOMBRE 
                txtCapacidad.Text = DetallesSeccionesSistema.CurrentRow.Cells["seccion"].Value.ToString(); // NOMBRE DE SECCION
                txtSeccionEli.Text = DetallesSeccionesSistema.CurrentRow.Cells["capacidad"].Value.ToString(); // CAPACIDAD

                Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION          
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void EliminarSecciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EliminarRegistrosSeccion_Click(object sender, EventArgs e)
        {
            if (txtIdSeccionEli.Text.Length == 0 || txtnombreSeccionEli.Text.Length == 0 || txtCapacidad.Text.Length == 0 || txtSeccionEli.Text.Length == 0)
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
            else
            {
                string query = "DELETE FROM Secciones WHERE cod_seccion=@cod_seccion";

                // --> WHERE cod_seccion=@cod_seccion" IMPORTANTE: SI NO SE REFERENCIA POR DEFECTO NO MUESTRA ERROR PERO SE PRODUCE UN ERROR LOGICO, AL ELIMINAR ABSOLUTAMENTE
                // TODOS LOS DATOS DE LA TABLA REFERENCIADA EN LA BASE DE DATOS.

                SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());

                comando.Parameters.AddWithValue("@cod_seccion", txtIdSeccionEli.Text); // REFERENCIA DEL ID UNICO DE CADA SECCIONES
                comando.ExecuteNonQuery(); // ENVIANDO COMPONENTE QUERY HACIA LA BASE DE DATOS CON NUEVO REGISTRO ACTUALIZADO

                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                // VALIDANDO QUE NO EXISTAN CAMPOS VACIOS Y QUE AL MENOS EL USUARIO SELECCIONE UN REGISTRO A ELIMINAR
                if (txtIdSeccionEli.Text.Length == 0 || txtnombreSeccionEli.Text.Length == 0 || txtCapacidad.Text.Length == 0 || txtSeccionEli.Text.Length == 0)
                {
                    // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                    Form NoSeleccion = new MensajeNoSeleccion();
                    NoSeleccion.Show();
                }
                else
                {
                    // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    /*---------------------------------------------------------------------------------------------
                    * AL MOMENTO QUE EL USUARIO INGRESA LOS DATOS, ESTE VUELVE A EJECUTAR EL PROCEDIMIENTO PARA  *
                    * REFRESCAR LA TABLA CONTENEDORA CON LAS N SECCIONES REGISTRADOS EN EL SISTEMA...             *
                    * --------------------------------------------------------------------------------------------
                    */

                    // REFERENCIANDO EL NOMBRE DE LA TABLA A MOSTRAR LOS N DATOS CONTENIDOS EN ELLA
                    SqlCommand cmd = new SqlCommand("Select * from Secciones", Controlador.Conexiones());
                    // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;
                    // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
                    DataTable TablaRegistros = new DataTable();
                    // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE SECCIONES
                    MostrarRegistros.Fill(TablaRegistros);
                    // INVOCANDO LA REFERENCIA QUE SEA IGUAL AL ADAPTADOR DE LLENADO DE DATOS,
                    // ES DECIR, TODOS LOS REGISTROS CONTENIDOS DENTRO DE LA TABLA {secciones}
                    DetallesSeccionesSistema.DataSource = TablaRegistros;

                    txtIdSeccionEli.Clear(); txtnombreSeccionEli.Clear(); txtCapacidad.Clear(); txtSeccionEli.Clear();
                }
            }
            Controlador.CierreConexiones(); // CIERRE DE CONEXION
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