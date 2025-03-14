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
    public partial class EliminarUsuarios : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // CONEXION VS A BASE DE DATOS
        ControlConexion Controlador = new ControlConexion();

        public EliminarUsuarios()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("Select * from Usuarios", Controlador.Conexiones());
            // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;
            // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
            DataTable TablaRegistros = new DataTable();
            // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE USUARIOS
            MostrarRegistros.Fill(TablaRegistros);
            // INVOCANDO LA REFERENCIA QUE SEA IGUAL AL ADAPTADOR DE LLENADO DE DATOS,
            // ES DECIR, TODOS LOS REGISTROS CONTENIDOS DENTRO DE LA TABLA {usuario}
            DetallesUsuariosSistema.DataSource = TablaRegistros;
            // ESTILOS DE BORDES REDONDEADOS EN BOTONES
            BotonesRedondeados.BordesRedondeados(EliminarRegistrosUsuarios); // BOTON INICIAR SESION
            BotonesRedondeados.BordesRedondeados(SeleccionarRegistro); // BOTON SALIR
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO {APLICABLE A SOLO CONTENEDOR DE FORMULARIO}
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EliminarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.incoa_systemdbDataSet.Usuarios);
        }

        private void SeleccionarRegistro_Click(object sender, EventArgs e)
        {
            if (DetallesUsuariosSistema.SelectedRows.Count > 0)
            {
                /* EL DATAGRIDVIEW SE ENCARGA DE MOSTRAR AL USUARIO LOS DATOS ALMACENADOS EN LA BASE DE DATOS
                * POR LO TANTO AL MOMENTO QUE EL USUARIO SELECCIONE DICHO REGISTRO Y PRESIONE EL BOTON SELECCIONAR
                * USUARIO, SE PROCEDE A TOMAR CADA UNO DE LOS CAMPOS ALMACENADOS EN LOS TEXTBOX CON SUS IDENTIFICADORES
                * UNICOS Y REALIZA LA RESPECTIVA CONVERSION A CADENA PARA QUE ESA INFORMACION SEA VISIBLE AL USUARIO
                * FINAL Y PUEDA PROCEDER A ELIMINAR EL N REGISTRO QUE DESEE...
                * -------------------------------------------------------------------------------------------------------------------
                * IMPORTANTE: TODOS LOS TEXTBOX SE HAN BLOQUEADO PARA SU RESPECTIVA EDICION, YA QUE EL PROCEDIMIENTO ES DE ELIMINAR
                * Y NO MODIFICAR, UNICAMENTE SIRVEN COMO REFERENCIA AL USUARIO PARA EL X REGISTRO A ELIMINAR.
                */

                txtid.Text = DetallesUsuariosSistema.CurrentRow.Cells["id_usuario"].Value.ToString(); // ID DE USUARIO
                txtnombres.Text = DetallesUsuariosSistema.CurrentRow.Cells["Nombre"].Value.ToString(); // NOMBRE Y APELLIDO
                txtusuario.Text = DetallesUsuariosSistema.CurrentRow.Cells["Usuario"].Value.ToString(); // NOMBRE DE USUARIO
                txtpass.Text = DetallesUsuariosSistema.CurrentRow.Cells["Password"].Value.ToString(); // CLAVE DE ACCESO {PASSWORD}
                txttipo.Text = DetallesUsuariosSistema.CurrentRow.Cells["Tipo_usuario"].Value.ToString(); // TIPO DE USUARIO {ROLES DE USUARIOS}

                Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION          
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EliminarUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EliminarRegistrosUsuarios_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length == 0 || txtnombres.Text.Length == 0 || txtusuario.Text.Length == 0 || txtpass.Text.Length == 0 || txttipo.Text.Length == 0)
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
            else
            {
                string query = "DELETE FROM Usuarios WHERE id_usuario=@id_usuario";

                // --> WHERE id_usuario=@id_usuario" IMPORTANTE: SI NO SE REFERENCIA POR DEFECTO NO MUESTRA ERROR PERO SE PRODUCE UN ERROR LOGICO, AL ELIMINAR ABSOLUTAMENTE
                // TODOS LOS DATOS DE LA TABLA REFERENCIADA EN LA BASE DE DATOS.

                SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());

                comando.Parameters.AddWithValue("@id_usuario", txtid.Text); // REFERENCIA DEL ID UNICO DE CADA USUARIO
                comando.ExecuteNonQuery(); // ENVIANDO COMPONENTE QUERY HACIA LA BASE DE DATOS CON NUEVO REGISTRO ACTUALIZADO

                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                // VALIDANDO QUE NO EXISTAN CAMPOS VACIOS Y QUE AL MENOS EL USUARIO SELECCIONE UN REGISTRO A ELIMINAR
                if (txtid.Text.Length == 0 || txtnombres.Text.Length == 0 || txtusuario.Text.Length == 0 || txtpass.Text.Length == 0 || txttipo.Text.Length == 0)
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
                    * REFRESCAR LA TABLA CONTENEDORA CON LOS N USUARIOS REGISTRADOS EN EL SISTEMA...             *
                    * --------------------------------------------------------------------------------------------
                    */

                    // REFERENCIANDO EL NOMBRE DE LA TABLA A MOSTRAR LOS N DATOS CONTENIDOS EN ELLA
                    SqlCommand cmd = new SqlCommand("Select * from Usuarios", Controlador.Conexiones());
                    // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;
                    // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
                    DataTable TablaRegistros = new DataTable();
                    // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE USUARIOS
                    MostrarRegistros.Fill(TablaRegistros);
                    // INVOCANDO LA REFERENCIA QUE SEA IGUAL AL ADAPTADOR DE LLENADO DE DATOS,
                    // ES DECIR, TODOS LOS REGISTROS CONTENIDOS DENTRO DE LA TABLA {usuario}
                    DetallesUsuariosSistema.DataSource = TablaRegistros;

                    txtid.Clear(); txtnombres.Clear(); txtusuario.Clear(); txtpass.Clear(); txttipo.Clear();
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