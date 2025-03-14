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
    public partial class ModificarAlumnos : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ControlConexion Controlador = new ControlConexion();

        public ModificarAlumnos()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("Select * from Alumnos", Controlador.Conexiones());
            // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;
            // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
            DataTable TablaRegistros = new DataTable();
            // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE ALUMNOS
            MostrarRegistros.Fill(TablaRegistros);
            // INVOCANDO LA REFERENCIA QUE SEA IGUAL AL ADAPTADOR DE LLENADO DE DATOS,
            // ES DECIR, TODOS LOS REGISTROS CONTENIDOS DENTRO DE LA TABLA ALUMNOS
            DetallesUsuariosSistema.DataSource = TablaRegistros;
            // ESTILOS DE BORDES REDONDEADOS EN BOTONES
            BotonesRedondeados.BordesRedondeados(ModificarRegistrosAlumnos); // BOTON INICIAR SESION
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

        private void ModificarAlumnos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ModificarRegistrosAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDANDO QUE NO EXISTAN CAMPOS VACIOS Y QUE AL MENOS EL USUARIO SELECCIONE UN REGISTRO A ACTUALIZAR
                if (txtcod.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || mtxtNacimiento.Text.Length == 0 || txtDireccion.Text.Length == 0 || cboGenero.Text.Length == 0 || txtTelefono.Text.Length == 0 || txtSeccion.Text.Length == 0)
                {
                    Form NoSeleccion = new MensajeNoSeleccion();
                    NoSeleccion.Show();
                }
                else
                {
                    string query = "UPDATE Alumnos SET nombre = @nombre, apellido = @apellido, f_nacimiento = @f_nacimiento, Direccion = @Direccion, genero = @genero, especialidad = @especialidad, año = @año, telefono = @telefono, cod_seccion = @cod_seccion WHERE cod_alumno = @cod_alumno";

                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());

                    comando.Parameters.AddWithValue("@cod_alumno", txtcod.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    comando.Parameters.AddWithValue("@f_nacimiento", Convert.ToDateTime(mtxtNacimiento.Text));
                    comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    comando.Parameters.AddWithValue("@genero", cboGenero.Text);
                    comando.Parameters.AddWithValue("@especialidad", cboEspecialidad.Text);
                    comando.Parameters.AddWithValue("@año", txtAnio.Text);
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    comando.Parameters.AddWithValue("@cod_seccion", txtSeccion.Text);
                    comando.ExecuteNonQuery();

                    //CREANDO MENSAJE EN VENTANA FLOTANTE
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    // REFERENCIANDO EL NOMBRE DE LA TABLA A MOSTRAR LOS N DATOS CONTENIDOS EN ELLA
                    SqlCommand cmd = new SqlCommand("Select * from Alumnos", Controlador.Conexiones());

                    // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;
                    // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
                    DataTable TablaRegistros = new DataTable();

                    // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE ALUMNOS
                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesUsuariosSistema.DataSource = TablaRegistros;

                    txtcod.Clear(); txtNombre.Clear(); txtApellido.Clear(); mtxtNacimiento.Clear(); txtDireccion.Clear(); cboGenero.SelectedIndex = -1; cboEspecialidad.SelectedIndex = -1; txtAnio.Clear(); txtTelefono.Clear(); txtSeccion.Clear();

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
                txtcod.Text = DetallesUsuariosSistema.CurrentRow.Cells["cod_alumno"].Value.ToString(); // ID DE ALUMNO
                txtNombre.Text = DetallesUsuariosSistema.CurrentRow.Cells["nombre"].Value.ToString(); // NOMBRE
                txtApellido.Text = DetallesUsuariosSistema.CurrentRow.Cells["apellido"].Value.ToString(); // APELLIDO
                mtxtNacimiento.Text = DetallesUsuariosSistema.CurrentRow.Cells["f_nacimiento"].Value.ToString(); // FECHA DE NACIMIENTO
                txtDireccion.Text = DetallesUsuariosSistema.CurrentRow.Cells["Direccion"].Value.ToString(); // DIRECCION
                cboGenero.Text = DetallesUsuariosSistema.CurrentRow.Cells["genero"].Value.ToString(); // GENERO
                cboEspecialidad.Text = DetallesUsuariosSistema.CurrentRow.Cells["especialidad"].Value.ToString(); //ESPECIALIDAD
                txtAnio.Text = DetallesUsuariosSistema.CurrentRow.Cells["año"].Value.ToString(); //AÑO
                txtTelefono.Text = DetallesUsuariosSistema.CurrentRow.Cells["telefono"].Value.ToString(); // TELEFONO
                txtSeccion.Text = DetallesUsuariosSistema.CurrentRow.Cells["cod_seccion"].Value.ToString(); // SECCION
                Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION 
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void ModificarAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.incoa_systemdbDataSet.Alumnos);

            this.cboGenero.Items.Add("M");
            this.cboGenero.Items.Add("F");

            this.cboEspecialidad.Items.Add("General");
            this.cboEspecialidad.Items.Add("Contador");
            this.cboEspecialidad.Items.Add("Software");
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