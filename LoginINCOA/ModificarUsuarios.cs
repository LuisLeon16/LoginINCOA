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
    public partial class ModificarUsuarios : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ControlConexion Controlador = new ControlConexion();

        public ModificarUsuarios()
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
            BotonesRedondeados.BordesRedondeados(ModificarRegistrosUsuarios); // BOTON INICIAR SESION
            BotonesRedondeados.BordesRedondeados(SeleccionarRegistro); // BOTON SALIR
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO {APLICABLE A SOLO CONTENEDOR DE FORMULARIO}
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ModificarUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ModificarRegistrosUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDANDO QUE NO EXISTAN CAMPOS VACIOS Y QUE AL MENOS EL USUARIO SELECCIONE UN REGISTRO A ACTUALIZAR
                if (txtid.Text.Length == 0 || txtnombres.Text.Length == 0 || txtusuario.Text.Length == 0 || txtpass.Text.Length == 0 || cbotipo.Text.Length == 0)
                {
                    Form NoSeleccion = new MensajeNoSeleccion();
                    NoSeleccion.Show();
                }
                else
                {
                    string query = "UPDATE Usuarios SET Nombre = @nombre, Usuario = @usuario, Password = @pass, Tipo_usuario = @tipousuario WHERE id_usuario = @id_usuario";

                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());

                    comando.Parameters.AddWithValue("@id_usuario", txtid.Text); // REFERENCIA DEL ID UNICO DE CADA USUARIO
                    comando.Parameters.AddWithValue("@nombre", txtnombres.Text); // NOMBRE Y APELLIDO
                    comando.Parameters.AddWithValue("@usuario", txtusuario.Text); // NOMBRE DE USUARIO
                    comando.Parameters.AddWithValue("@pass", txtpass.Text); // PASSWORD DE ACCESO {CLAVE DE ACCESO}
                    comando.Parameters.AddWithValue("@tipousuario", cbotipo.Text); // TIPO DE USUARIO {ROL DE USUARIO}

                    comando.ExecuteNonQuery();

                    //CREANDO MENSAJE EN VENTANA FLOTANTE
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    // REFERENCIANDO EL NOMBRE DE LA TABLA A MOSTRAR LOS N DATOS CONTENIDOS EN ELLA
                    SqlCommand cmd = new SqlCommand("Select * from Usuarios", Controlador.Conexiones());

                    // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;
                    // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
                    DataTable TablaRegistros = new DataTable();

                    // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE USUARIOS
                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesUsuariosSistema.DataSource = TablaRegistros;

                    txtid.Clear(); txtnombres.Clear(); txtusuario.Clear(); txtpass.Clear(); cbotipo.SelectedIndex = -1;
                
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

        private void SeleccionarRegistro_Click(object sender, EventArgs e)
        {
            if (DetallesUsuariosSistema.SelectedRows.Count > 0)
            {
                /* EL DATAGRIDVIEW SE ENCARGA DE MOSTRAR AL USUARIO LOS DATOS ALMACENADOS EN LA BASE DE DATOS
                * POR LO TANTO AL MOMENTO QUE EL USUARIO SELECCIONE DICHO REGISTRO Y PRESIONE EL BOTON SELECCIONAR
                * USUARIO, SE PROCEDE A TOMAR CADA UNO DE LOS CAMPOS ALMACENADOS EN LOS TEXTBOX CON SUS IDENTIFICADORES
                * UNICOS Y REALIZA LA RESPECTIVA CONVERSION A CADENA PARA QUE ESA INFORMACION SEA VISIBLE AL USUARIO
                * FINAL Y PUEDA PROCEDER A ACTUALIZAR EL N REGISTRO QUE DESEE...
                */
                txtid.Text = DetallesUsuariosSistema.CurrentRow.Cells["id_usuario"].Value.ToString(); // ID DE USUARIO
                txtnombres.Text = DetallesUsuariosSistema.CurrentRow.Cells["Nombre"].Value.ToString(); // NOMBRE Y APELLIDO
                txtusuario.Text = DetallesUsuariosSistema.CurrentRow.Cells["Usuario"].Value.ToString(); // NOMBRE DE USUARIO
                txtpass.Text = DetallesUsuariosSistema.CurrentRow.Cells["Password"].Value.ToString(); // CLAVE DE ACCESO {PASSWORD}
                cbotipo.Text = DetallesUsuariosSistema.CurrentRow.Cells["Tipo_usuario"].Value.ToString(); // TIPO DE USUARIO {ROLES DE USUARIOS}
                Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION 
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void ModificarUsuarios_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.incoa_systemdbDataSet.Usuarios);

            this.cbotipo.Items.Add("Admin");
            this.cbotipo.Items.Add("Docente");
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