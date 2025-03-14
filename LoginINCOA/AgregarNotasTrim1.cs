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

    public partial class AgregarNotasTrim1 : Form
    {
        public int contador;

        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        //CREACION DE OBJETO PARA REALIZAR LA BUSQUEDA SEGUN CONSULTA
        BaseDeDatos integracion = new BaseDeDatos();

        // CREACION DE OBJETOS CONTROLADORES DE COMBOBOX
        ControlesCombobox CodAlum = new ControlesCombobox();   // COD ALUMNO
        ControlesCombobox CodAsign = new ControlesCombobox();   // COD ASIGNATURA


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public AgregarNotasTrim1()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("Select * from Trimestre1", Controlador.Conexiones());

            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;

            DataTable TablaRegistros = new DataTable();

            MostrarRegistros.Fill(TablaRegistros);
            DetallesTrim1Sistema.DataSource = TablaRegistros;
            DetallesTrim1Sistema.Columns[5].DefaultCellStyle.Format = "N2";

            /*
             * INVOCANDO METODO PARA PASO DE DATOS DE COMBOBOX HACIA BASE DE DATOS
             */
            CodAlum.SeleccionarAlum(cbCodAlumno);       // COD ALUMNO
            CodAsign.SeleccionarAsign(cbCodAsignatura);       // COD ASIGNATURA

            /*
             * RESETEO DE COMBOBOX PARA UN TAMAÑO FIJO PREDETERMINADO
             */
            cbCodAlumno.Size = new System.Drawing.Size(112, 24);      // COD ALUM
            cbCodAsignatura.Size = new System.Drawing.Size(185, 24);     // COD ALUM

            BotonesRedondeados.BordesRedondeados(btnCalcularPromedio); // BOTON INICIAR CALCULAR PROMEDIO
            BotonesRedondeados.BordesRedondeados(btnRegistroNota); //BOTON REGISTRAR
        }

        private void AgregarNotasTrim1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Trimestre1' Puede moverla o quitarla según sea necesario.
            this.trimestre1TableAdapter.Fill(this.incoa_systemdbDataSet.Trimestre1);

        }

        private void AgregarNotasTrim1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {

            try
            {
                //VALIDANDO EL INGRESO DE DATOS
                if (Convert.ToDecimal(txtAct1.Text) < 0 || Convert.ToDecimal(txtAct2.Text) < 0 || Convert.ToDecimal(txtExam.Text) < 0)
                {
                    MessageBox.Show("Error de datos, tome en cuenta las siguientes consideraciones: \n\n- Utilice datos numericos ya sean enteros o decimales.\n- Utilice numeros iguales o mayores a 0 y menores o iguales a 10.\n- Utilice la coma para decimales, evite usar el punto.");
                }
                //VALIDANDO EL INGRESO DE DATOS
                else if (Convert.ToDecimal(txtAct1.Text) > 10 || Convert.ToDecimal(txtAct2.Text) > 10 || Convert.ToDecimal(txtExam.Text) > 10)
                {
                    MessageBox.Show("Error de datos, tome en cuenta las siguientes consideraciones: \n\n- Utilice datos numericos ya sean enteros o decimales.\n- Utilice numeros iguales o mayores a 0 y menores o iguales a 10.\n- Utilice la coma para decimales, evite usar el punto.");
                }
                else
                {
                    //PROCESOS
                    double n1 = (Convert.ToDouble(txtAct1.Text) * 0.35);
                    double n2 = (Convert.ToDouble(txtAct2.Text) * 0.35);
                    double n3 = (Convert.ToDouble(txtExam.Text) * 0.30);

                    double promedio = n1 + n2 + n3;

                    txtPromedio2.Text = Math.Round(promedio, 1, MidpointRounding.ToEven).ToString();    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de datos, tome en cuenta las siguientes consideraciones: \n\n- Utilice datos numericos ya sean enteros o decimales.\n- Recuerde respetar el rango 0 - 10 para el ingreso de notas.\n- Utilice la coma para decimales, evite usar el punto.");
            }
        }

        private void btnRegistroNota_Click(object sender, EventArgs e)
        {
            
            if (cbCodAlumno.Text.Length == 0 || cbCodAsignatura.Text.Length == 0 || txtAct1.Text.Length == 0 || txtAct2.Text.Length == 0 || txtExam.Text.Length == 0 || mtxtPromedio.Text.Length == 0)
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
                    SqlCommand Comunicacion = new SqlCommand("SELECT cod_asignatura, cod_alumno FROM Trimestre1 WHERE cod_asignatura = @cod_asignatura AND cod_alumno = @cod_alumno", Controlador.Conexiones());
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
                        cbCodAlumno.Text = "";
                        cbCodAsignatura.Text = "";

                        txtAct1.Clear(); txtAct2.Clear(); txtExam.Clear(); mtxtPromedio.Clear(); txtPromedio2.Clear();
                    }
                    else
                    {
                        string query = "INSERT INTO Trimestre1 (cod_alumno, cod_asignatura, Act1, Act2, Exam, promedio1) VALUES (@cod_alumno, @cod_asignatura, @Act1, @Act2, @Exam, @promedio1)";

                    // CREANDO CADENA DE INSERCION query CON SU PASO DE PARAMETROS HACIA LA BASE DE DATOS
                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones()); // CREANDO COMANDO DE CONEXION
                    comando.Parameters.AddWithValue("@cod_alumno", cbCodAlumno.Text);
                    comando.Parameters.AddWithValue("@cod_asignatura", cbCodAsignatura.Text);
                    comando.Parameters.AddWithValue("@Act1", Convert.ToDecimal(txtAct1.Text));
                    comando.Parameters.AddWithValue("@Act2", Convert.ToDecimal(txtAct2.Text));
                    comando.Parameters.AddWithValue("@Exam", Convert.ToDecimal(txtExam.Text));
                    comando.Parameters.AddWithValue("@promedio1", Convert.ToDecimal(txtPromedio2.Text));
                    comando.ExecuteNonQuery();


                        SqlCommand Comunicacion2 = new SqlCommand("SELECT cod_alumno, cod_asignatura FROM Notas WHERE cod_alumno = @cod_alumno AND cod_asignatura = @cod_asignatura", Controlador.Conexiones());
                        Comunicacion2.Parameters.AddWithValue("cod_alumno", cbCodAlumno.Text);
                        Comunicacion2.Parameters.AddWithValue("cod_asignatura", cbCodAsignatura.Text);
                        SqlDataAdapter AdaptadorSQL1 = new SqlDataAdapter(Comunicacion2);
                        DataTable DatosDB2 = new DataTable();
                        AdaptadorSQL1.Fill(DatosDB2);
                        // SI EXISTE AL MENOS UN REGISTRO EN LA BUSQUEDA, ENTONCES...
                        if (DatosDB2.Rows.Count == 1)
                        {
                            txtOculto1.Clear();
                            txtOculto2.Clear();
                            txtOculto3.Clear();
                        }
                        else
                        {

                            txtOculto1.Text = cbCodAlumno.Text;
                                txtOculto2.Text = cbCodAsignatura.Text;
                                double cero = 0.0;
                                txtOculto3.Text = cero.ToString();

                                SqlCommand comando2 = new SqlCommand("INSERT INTO Notas (cod_alumno, cod_asignatura, NotaFinal) VALUES ( @cod_alumno, @cod_asignatura, @NotaFinal)", Controlador.Conexiones());

                                comando2.Parameters.AddWithValue("@cod_alumno", txtOculto1.Text);
                                comando2.Parameters.AddWithValue("@cod_asignatura", txtOculto2.Text);
                                comando2.Parameters.AddWithValue("@NotaFinal", Convert.ToDecimal(txtOculto3.Text));

                                comando2.ExecuteNonQuery();
                        }

                        //CREANDO MENSAJE EN VENTANA FLOTANTE
                        Form Aprobacion = new MensajeAprobacion();
                        Aprobacion.Show();

                        SqlCommand cmd = new SqlCommand("Select * from Trimestre1", Controlador.Conexiones());

                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;

                    DataTable TablaRegistros = new DataTable();

                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesTrim1Sistema.DataSource = TablaRegistros;

                    cbCodAlumno.Text = "-Seleccione Codigo";
                    cbCodAsignatura.Text = "-Seleccione Codigo";

                    txtAct1.Clear(); txtAct2.Clear(); txtExam.Clear(); mtxtPromedio.Clear(); txtPromedio2.Clear();
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

        private void cbCodAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //REGISTRO DE NOTA SEGUN ALUMNO
            DetallesTrim1Sistema.DataSource = integracion.SelectDataTable("SELECT * FROM Trimestre1 WHERE cod_alumno LIKE ('" + cbCodAlumno.Text + "%')");
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