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
    public partial class Eliminar_AsignAlumn : Form
    {

        ControlConexion Controlador = new ControlConexion();

        // CREACION DE OBJETOS CONTROLADORES DE COMBOBOX
        ControlesCombobox CodAlumn = new ControlesCombobox();   // COD ALUMNO
        ControlesCombobox CodAsign = new ControlesCombobox();   // COD ASIGNATURA
        ControlesCombobox NombAsign = new ControlesCombobox();  // NOMBRE ASIGNATURA
        ControlesCombobox CodDocente = new ControlesCombobox();  // COD DOCENTE


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Eliminar_AsignAlumn()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("Select * from AsignaturasAlumnos", Controlador.Conexiones());
            // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;
            // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
            DataTable TablaRegistros = new DataTable();
            // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE ASIGNATURAS
            MostrarRegistros.Fill(TablaRegistros);
            // INVOCANDO LA REFERENCIA QUE SEA IGUAL AL ADAPTADOR DE LLENADO DE DATOS,
            // ES DECIR, TODOS LOS REGISTROS CONTENIDOS DENTRO DE LA TABLA {asignaturas}
            DetallesAlumnAsignSistema.DataSource = TablaRegistros;
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO {APLICABLE A SOLO CONTENEDOR DE FORMULARIO}
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            /*
                 * INVOCANDO METODO PARA PASO DE DATOS DE COMBOBOX HACIA BASE DE DATOS
                 */
            CodAlumn.SeleccionarAlum(cbCodAlumno);       // COD ALUMNO
            CodAsign.SeleccionarAsign(cbCodAsignatura);       // COD ASIGNATURA
            NombAsign.SeleccionarNomAsign(cbNomAsignatura);   //NOMBRE ASIGNATURA
            CodDocente.SeleccionarDocente(cbCodDocente);   //COD DOCENTE

            /*
             * RESETEO DE COMBOBOX PARA UN TAMAÑO FIJO PREDETERMINADO
             */
            cbCodAlumno.Size = new System.Drawing.Size(112, 24);      // COD ALUM
            cbCodAsignatura.Size = new System.Drawing.Size(150, 24);      // COD ASIGNATURA
            cbNomAsignatura.Size = new System.Drawing.Size(151, 24);      //NOMBRE ASIGNATURA
            cbCodDocente.Size = new System.Drawing.Size(87, 24);      //COD DOCENTE
        }

        private void Eliminar_AsignAlumn_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.AsignaturasAlumnos' Puede moverla o quitarla según sea necesario.
            this.asignaturasAlumnosTableAdapter.Fill(this.incoa_systemdbDataSet.AsignaturasAlumnos);

        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Eliminar_AsignAlumn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDANDO QUE NO EXISTAN CAMPOS VACIOS Y QUE AL MENOS LA ASIGNATURA SELECCIONE UN REGISTRO A ACTUALIZAR
                if (cbCodAsignatura.Text.Length == 0 || cbNomAsignatura.Text.Length == 0 || cbCodDocente.Text.Length == 0 || cbCodAlumno.Text.Length == 0)
                {
                    Form NoSeleccion = new MensajeNoSeleccion();
                    NoSeleccion.Show();
                }
                else
                {
                    string query = "DELETE FROM AsignaturasAlumnos WHERE Id_AsAlum = @Id_AsAlum";

                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());
                    comando.Parameters.AddWithValue("@Id_AsAlum", txtid.Text);
                    comando.ExecuteNonQuery();

                    //CREANDO MENSAJE EN VENTANA FLOTANTE
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    // REFERENCIANDO EL NOMBRE DE LA TABLA A MOSTRAR LOS N DATOS CONTENIDOS EN ELLA
                    SqlCommand cmd = new SqlCommand("Select * from AsignaturasAlumnos", Controlador.Conexiones());

                    // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;
                    // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
                    DataTable TablaRegistros = new DataTable();

                    // LLENANDO CON TODOS LOS REGISTROS CONTENIDOS EN LA TABLA DE ASIGNATURAS
                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesAlumnAsignSistema.DataSource = TablaRegistros;

                    cbCodAsignatura.Text = ""; cbCodDocente.Text = ""; cbNomAsignatura.Text = ""; cbCodDocente.Text = ""; cbCodAlumno.Text = "";
                    Controlador.CierreConexiones(); // CIERRE DE CONEXION
                }
            }
            catch (Exception)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form ErrorEliminar = new MensajeErrorEliminarDatos();
                ErrorEliminar.Show();
            }
            finally
            {
                Controlador.CierreConexiones(); // CIERRE DE CONEXION
            }
        }

        private void SeleccionarRegistroAsignatura_Click(object sender, EventArgs e)
        {
            if (DetallesAlumnAsignSistema.SelectedRows.Count > 0)
            {
                txtid.Text = DetallesAlumnAsignSistema.CurrentRow.Cells["Id_AsAlum"].Value.ToString();
                cbCodAsignatura.Text = DetallesAlumnAsignSistema.CurrentRow.Cells["cod_asignatura"].Value.ToString();
                cbNomAsignatura.Text = DetallesAlumnAsignSistema.CurrentRow.Cells["n_asignatura"].Value.ToString();
                cbCodDocente.Text = DetallesAlumnAsignSistema.CurrentRow.Cells["cod_docente"].Value.ToString();
                txtnombres.Text = DetallesAlumnAsignSistema.CurrentRow.Cells["nombreDoc"].Value.ToString();
                cbCodAlumno.Text = DetallesAlumnAsignSistema.CurrentRow.Cells["cod_alumno"].Value.ToString();

                Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION 
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void cbCodDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("select * from Docentes where cod_docente='" + cbCodDocente.Text + "'", Controlador.Conexiones());

                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = (string)reader["nombre"].ToString();
                    /*string ape = (string)reader["apellido"].ToString();*/
                    txtnombres.Text = nombre/*+" "+ape*/ ;
                }

                Controlador.CierreConexiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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