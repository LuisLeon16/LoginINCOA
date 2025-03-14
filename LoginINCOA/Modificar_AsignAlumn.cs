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
    public partial class Modificar_AsignAlumn : Form
    {
        ControlConexion Controlador = new ControlConexion();

        // CREACION DE OBJETOS CONTROLADORES DE COMBOBOX
        ControlesCombobox CodAlumn = new ControlesCombobox();   // COD ALUMNO
        ControlesCombobox CodAsign = new ControlesCombobox();   // COD ASIGNATURA
        ControlesCombobox CodDocente = new ControlesCombobox();  // COD DOCENTE


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Modificar_AsignAlumn()
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
            DetallesAsignAlumnSistema.DataSource = TablaRegistros;
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO {APLICABLE A SOLO CONTENEDOR DE FORMULARIO}
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            /*
                 * INVOCANDO METODO PARA PASO DE DATOS DE COMBOBOX HACIA BASE DE DATOS
                 */
            CodAlumn.SeleccionarAlum(cbCodAlumno);       // COD ALUMNO
            CodAsign.SeleccionarAsign(cbCodAsignatura);       // COD ASIGNATURA
            CodDocente.SeleccionarDocente(cbCodDocente);   //COD DOCENTE

            /*
             * RESETEO DE COMBOBOX PARA UN TAMAÑO FIJO PREDETERMINADO
             */
            cbCodAlumno.Size = new System.Drawing.Size(112, 24);      // COD ALUM
            cbCodAsignatura.Size = new System.Drawing.Size(150, 24);      // COD ASIGNATURA
            cbCodDocente.Size = new System.Drawing.Size(87, 24);      //COD DOCENTE

        }

        private void Modificar_AsignAlumn_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.AsignaturasAlumnos' Puede moverla o quitarla según sea necesario.
            this.asignaturasAlumnosTableAdapter.Fill(this.incoa_systemdbDataSet.AsignaturasAlumnos);

        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Modificar_AsignAlumn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistroNuevoAsignatura_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDANDO QUE NO EXISTAN CAMPOS VACIOS Y QUE AL MENOS LA ASIGNATURA SELECCIONE UN REGISTRO A ACTUALIZAR
                if (cbCodAsignatura.Text.Length == 0 || txtNombreAsignatura.Text.Length == 0 || cbCodDocente.Text.Length == 0 || cbCodAlumno.Text.Length == 0)
                {
                    //CREANDO MENSAJE EN VENTANA FLOTANTE
                    Form NoSeleccion = new MensajeNoSeleccion();
                    NoSeleccion.Show();
                }
                else
                {
                    string query = "UPDATE AsignaturasAlumnos SET cod_asignatura = @cod_asignatura, n_asignatura = @n_asignatura, cod_docente = @cod_docente, nombreDoc = @nombreDoc, cod_alumno = @cod_alumno WHERE cod_asignatura = @cod_asignatura AND cod_alumno = @cod_alumno";

                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());
                    comando.Parameters.AddWithValue("@cod_asignatura", cbCodAsignatura.Text);
                    comando.Parameters.AddWithValue("@n_asignatura", txtNombreAsignatura.Text);
                    comando.Parameters.AddWithValue("@cod_docente", cbCodDocente.Text);
                    comando.Parameters.AddWithValue("@nombreDoc", txtnombres.Text);
                    comando.Parameters.AddWithValue("@cod_alumno", cbCodAlumno.Text);

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
                    DetallesAsignAlumnSistema.DataSource = TablaRegistros;

                    cbCodAsignatura.SelectedIndex = -1; cbCodDocente.SelectedIndex = -1; txtNombreAsignatura.Clear(); cbCodDocente.SelectedIndex = -1; cbCodAlumno.SelectedIndex = -1; txtnombres.Clear();
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

        private void SeleccionarRegistroAsignatura_Click(object sender, EventArgs e)
        {
            if (DetallesAsignAlumnSistema.SelectedRows.Count > 0)
            {
                cbCodAlumno.Enabled = true;
                cbCodDocente.Enabled = true;

                cbCodAsignatura.Text = DetallesAsignAlumnSistema.CurrentRow.Cells["cod_asignatura"].Value.ToString();
                txtNombreAsignatura.Text = DetallesAsignAlumnSistema.CurrentRow.Cells["n_asignatura"].Value.ToString();
                cbCodDocente.Text = DetallesAsignAlumnSistema.CurrentRow.Cells["cod_docente"].Value.ToString();
                txtnombres.Text = DetallesAsignAlumnSistema.CurrentRow.Cells["nombreDoc"].Value.ToString();
                cbCodAlumno.Text = DetallesAsignAlumnSistema.CurrentRow.Cells["cod_alumno"].Value.ToString();

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
                    txtnombres.Text = nombre;
                }

                Controlador.CierreConexiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCodAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("select * from Asignaturas where cod_asignatura='" + cbCodAsignatura.Text + "'", Controlador.Conexiones());

                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = (string)reader["n_asignatura"].ToString();
                    txtNombreAsignatura.Text = nombre;
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