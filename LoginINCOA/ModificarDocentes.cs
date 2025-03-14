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
    public partial class ModificarDocentes : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ControlConexion Controlador = new ControlConexion();

        public ModificarDocentes()
        {
            InitializeComponent();
            SqlCommand cmd = new SqlCommand("Select * from Docentes", Controlador.Conexiones());
            // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;
            // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
            DataTable TablaRegistros = new DataTable();
            // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE DOCENTES
            MostrarRegistros.Fill(TablaRegistros);
            // INVOCANDO LA REFERENCIA QUE SEA IGUAL AL ADAPTADOR DE LLENADO DE DATOS,
            // ES DECIR, TODOS LOS REGISTROS CONTENIDOS DENTRO DE LA TABLA DOCENTE
            DetallesDocentesSistema.DataSource = TablaRegistros;
            // ESTILOS DE BORDES REDONDEADOS EN BOTONES
            BotonesRedondeados.BordesRedondeados(ModificarRegistrosDocente); // BOTON INICIAR SESION
            BotonesRedondeados.BordesRedondeados(SeleccionarRegistro); // BOTON SALIR
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO {APLICABLE A SOLO CONTENEDOR DE FORMULARIO}
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ModificarDocentes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.incoa_systemdbDataSet.Docentes);

            this.cboGenero.Items.Add("M");
            this.cboGenero.Items.Add("F");
        }

        private void SeleccionarRegistro_Click(object sender, EventArgs e)
        {
            if (DetallesDocentesSistema.SelectedRows.Count > 0)
            {
                /* EL DATAGRIDVIEW SE ENCARGA DE MOSTRAR AL USUARIO LOS DATOS ALMACENADOS EN LA BASE DE DATOS
                * POR LO TANTO AL MOMENTO QUE EL USUARIO SELECCIONE DICHO REGISTRO Y PRESIONE EL BOTON SELECCIONAR
                * USUARIO, SE PROCEDE A TOMAR CADA UNO DE LOS CAMPOS ALMACENADOS EN LOS TEXTBOX CON SUS IDENTIFICADORES
                * UNICOS Y REALIZA LA RESPECTIVA CONVERSION A CADENA PARA QUE ESA INFORMACION SEA VISIBLE AL USUARIO
                * FINAL Y PUEDA PROCEDER A ACTUALIZAR EL N REGISTRO QUE DESEE...
                */
                txtcod.Text = DetallesDocentesSistema.CurrentRow.Cells["cod_docente"].Value.ToString(); // ID DEL DOCENTE
                txtnombres.Text = DetallesDocentesSistema.CurrentRow.Cells["nombre"].Value.ToString(); // NOMBRE
                txtapellidos.Text = DetallesDocentesSistema.CurrentRow.Cells["apellido"].Value.ToString(); // APELLIDO
                mtxtNacimiento.Text = DetallesDocentesSistema.CurrentRow.Cells["f_nacimiento"].Value.ToString(); // FECHA DE NACIMIENTO
                txtDireccion.Text = DetallesDocentesSistema.CurrentRow.Cells["direccion"].Value.ToString(); // DIRECCION
                cboGenero.Text = DetallesDocentesSistema.CurrentRow.Cells["genero"].Value.ToString(); //GENERO
                txtTelefono.Text = DetallesDocentesSistema.CurrentRow.Cells["telefono"].Value.ToString(); //TELEFONO
                Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION 
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ModificarDocentes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ModificarRegistrosDocente_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDANDO QUE NO EXISTAN CAMPOS VACIOS Y QUE AL MENOS EL USUARIO SELECCIONE UN REGISTRO A ACTUALIZAR
                if (txtcod.Text.Length == 0 || txtnombres.Text.Length == 0 || txtapellidos.Text.Length == 0 || txtDireccion.Text.Length == 0 || mtxtNacimiento.Text.Length == 0 || cboGenero.Text.Length == 0 || txtTelefono.Text.Length == 0)
                {
                    Form NoSeleccion = new MensajeNoSeleccion();
                    NoSeleccion.Show();
                }
                else
                {
                    string query = "UPDATE Docentes SET nombre = @nombre, apellido = @apellido, f_nacimiento = @f_nacimiento, direccion = @direccion, genero = @genero, telefono = @telefono WHERE cod_docente = @cod_docente";

                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());

                    comando.Parameters.AddWithValue("@cod_docente", txtcod.Text); // REFERENCIA DEL ID O COD UNICO DEL DOCENTE
                    comando.Parameters.AddWithValue("@nombre", txtnombres.Text); // NOMBRE
                    comando.Parameters.AddWithValue("@apellido", txtapellidos.Text); // APELLIDO
                    comando.Parameters.AddWithValue("@f_nacimiento", Convert.ToDateTime(mtxtNacimiento.Text)); //FECHA NACIMIENTO
                    comando.Parameters.AddWithValue("@direccion", txtDireccion.Text); //DIRECCION
                    comando.Parameters.AddWithValue("@genero", cboGenero.Text);
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    comando.ExecuteNonQuery();

                    //CREANDO MENSAJE EN VENTANA FLOTANTE
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    // REFERENCIANDO EL NOMBRE DE LA TABLA A MOSTRAR LOS N DATOS CONTENIDOS EN ELLA
                    SqlCommand cmd = new SqlCommand("Select * from Docentes", Controlador.Conexiones());

                    // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;
                    // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
                    DataTable TablaRegistros = new DataTable();

                    // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE DOCENTES
                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesDocentesSistema.DataSource = TablaRegistros;

                    txtcod.Clear(); txtnombres.Clear(); txtapellidos.Clear(); mtxtNacimiento.Clear(); txtDireccion.Clear(); cboGenero.SelectedIndex = -1; txtTelefono.Clear();

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
    }
}
/**
    @@@@   @@     @@    @@@@    @@@@@	 @@@@@
	 @@    @@@@   @@   @@	   @@	@@   @@ @@     
	 @@    @@ @@  @@   @@	   @@   @@	 @@@@@ 
	 @@    @@  @@ @@   @@	   @@	@@	 @@ @@
    @@@@   @@   @@@@    @@@@    @@@@@    @@ @@
**/