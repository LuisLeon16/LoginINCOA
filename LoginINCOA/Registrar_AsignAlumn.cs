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
    public partial class Registrar_AsignAlumn : Form
    {

        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        // CREACION DE OBJETOS CONTROLADORES DE COMBOBOX
        ControlesCombobox CodAlum = new ControlesCombobox();   // COD ALUMNO
        ControlesCombobox CodAsign = new ControlesCombobox();   // COD ASIGNATURA
        ControlesCombobox CodDocente = new ControlesCombobox();  // COD DOCENTE

        //CREACION DE OBJETO PARA REALIZAR LA BUSQUEDA SEGUN CONSULTA
        BaseDeDatos integracion = new BaseDeDatos();


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Registrar_AsignAlumn()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("Select * from AsignaturasAlumnos", Controlador.Conexiones());

            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;

            DataTable TablaRegistros = new DataTable();

            MostrarRegistros.Fill(TablaRegistros);
            DetallesAlumAsignSistema.DataSource = TablaRegistros;

            /*
             * INVOCANDO METODO PARA PASO DE DATOS DE COMBOBOX HACIA BASE DE DATOS
             */
            CodAlum.SeleccionarAlum(cbCodAlumno);       // COD ALUMNO
            CodAsign.SeleccionarAsign(cbCodAsignatura);       // COD ASIGNATURA
            CodDocente.SeleccionarDocente(cbCodDocente);   //COD DOCENTE

            /*
             * RESETEO DE COMBOBOX PARA UN TAMAÑO FIJO PREDETERMINADO
             */
            cbCodAlumno.Size = new System.Drawing.Size(112, 24);      // COD ALUM
            cbCodAsignatura.Size = new System.Drawing.Size(150, 24);      // COD ASIGNATURA
            cbCodDocente.Size = new System.Drawing.Size(87, 24);      //COD DOCENTE

        }

        private void Registrar_AsignAlumn_Load(object sender, EventArgs e)
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

        private void Registrar_AsignAlumn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnRegistroNuevoAsignatura_Click(object sender, EventArgs e)
        {
            if (cbCodAsignatura.Text.Length == 0 || txtNombreAsignatura.Text.Length == 0 || cbCodDocente.Text.Length == 0 || cbCodAlumno.Text.Length == 0)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form CamposVacio = new MensajeErrorCamposVacios();
                CamposVacio.Show();
            }
            else if (cbCodAlumno.Text.Length > 17 || cbCodAsignatura.Text.Length > 17)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form CamposVacio = new MensajeErrorCamposVacios();
                CamposVacio.Show();
            }
            else
            {
                try
                {
                    SqlCommand Comunicacion = new SqlCommand("SELECT cod_asignatura, cod_alumno FROM AsignaturasAlumnos WHERE cod_asignatura = @cod_asignatura AND cod_alumno = @cod_alumno", Controlador.Conexiones());
                    Comunicacion.Parameters.AddWithValue("cod_asignatura", cbCodAsignatura.Text);
                    Comunicacion.Parameters.AddWithValue("cod_alumno", cbCodAlumno.Text);
                    SqlDataAdapter AdaptadorSQL = new SqlDataAdapter(Comunicacion);
                    DataTable DatosDB = new DataTable();
                    AdaptadorSQL.Fill(DatosDB);
                    // SI EXISTE AL MENOS UN REGISTRO EN LA BUSQUEDA, ENTONCES...
                    if (DatosDB.Rows.Count == 1)
                    {
                        //CREANDO MENSAJE EN VENTANA FLOTANTE
                        Form Duplicado = new MensajeErrorDuplicados();
                        Duplicado.Show();

                        //LIMPIEZA
                        cbCodAsignatura.Text = ""; cbCodDocente.Text = ""; txtNombreAsignatura.Clear(); txtnombres.Clear(); cbCodDocente.Text = ""; cbCodAlumno.Text = "";
                    }
                    else
                    {
                        string query = "INSERT INTO AsignaturasAlumnos (cod_asignatura,n_asignatura,cod_docente,nombreDoc,cod_alumno) VALUES (@cod_asignatura,@n_asignatura,@cod_docente,@nombreDoc,@cod_alumno)";

                    // CREANDO CADENA DE INSERCION query CON SU PASO DE PARAMETROS HACIA LA BASE DE DATOS
                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones()); // CREANDO COMANDO DE CONEXION
                    comando.Parameters.AddWithValue("@cod_asignatura", cbCodAsignatura.Text);
                    comando.Parameters.AddWithValue("@n_asignatura", txtNombreAsignatura.Text);
                    comando.Parameters.AddWithValue("@cod_docente", cbCodDocente.Text);
                    comando.Parameters.AddWithValue("@nombreDoc", txtnombres.Text);
                    comando.Parameters.AddWithValue("@cod_alumno", cbCodAlumno.Text);
                    comando.ExecuteNonQuery();

                        //CREANDO MENSAJE EN VENTANA FLOTANTE
                        Form Aprobacion = new MensajeAprobacion();
                        Aprobacion.Show();

                        SqlCommand cmd = new SqlCommand("Select * from AsignaturasAlumnos", Controlador.Conexiones());

                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;

                    DataTable TablaRegistros = new DataTable();

                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesAlumAsignSistema.DataSource = TablaRegistros;

                    cbCodAsignatura.Text = ""; cbCodDocente.Text = ""; txtNombreAsignatura.Clear(); cbCodDocente.Text = ""; cbCodAlumno.Text = ""; txtnombres.Clear();
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