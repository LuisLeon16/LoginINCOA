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
using System.Globalization;

namespace LoginINCOA
{

    public partial class ModificarENotasTrim3 : Form
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

        public ModificarENotasTrim3()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("Select * from Trimestre3", Controlador.Conexiones());

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
            BotonesRedondeados.BordesRedondeados(btnModificarNota); //BOTON REGISTRAR
            BotonesRedondeados.BordesRedondeados(SeleccionarRegistroAsignatura); //BOTON MODIFICAR
            BotonesRedondeados.BordesRedondeados(EliminarRegistrosNota); //BOTON ELIMINAR

        }

        private void AgregarNotasTrim1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Trimestre3' Puede moverla o quitarla según sea necesario.
            this.trimestre3TableAdapter.Fill(this.incoa_systemdbDataSet.Trimestre3);

            //COLOCA EL CURSOR EN EL AREA DESIGNADA
            this.ActiveControl = txtBuscador;
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

        private void cbCodAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //REGISTRO DE NOTA SEGUN ALUMNO
            DetallesTrim1Sistema.DataSource = integracion.SelectDataTable("SELECT * FROM Trimestre3 WHERE cod_alumno LIKE ('" + cbCodAlumno.Text + "%')");
        }

        private void SeleccionarRegistroAsignatura_Click(object sender, EventArgs e)
        {
            if (DetallesTrim1Sistema.SelectedRows.Count > 0)
            {
                    cbCodAlumno.Text = DetallesTrim1Sistema.CurrentRow.Cells["cod_alumno"].Value.ToString();
                    cbCodAsignatura.Text = DetallesTrim1Sistema.CurrentRow.Cells["cod_asignatura"].Value.ToString();
                    txtAct1.Text = DetallesTrim1Sistema.CurrentRow.Cells["Act1"].Value.ToString();
                    txtAct2.Text = DetallesTrim1Sistema.CurrentRow.Cells["Act2"].Value.ToString();
                    txtExam.Text = DetallesTrim1Sistema.CurrentRow.Cells["Exam"].Value.ToString();
                    txtPromedio2.Text = DetallesTrim1Sistema.CurrentRow.Cells["promedio3"].Value.ToString();

                    Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION
 
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            //BUSCADOR PERSONALIZADO POR CODIGO
           DetallesTrim1Sistema.DataSource = integracion.SelectDataTable("SELECT * FROM Trimestre3 WHERE cod_alumno LIKE ('" + txtBuscador.Text + "%')  OR cod_asignatura LIKE ('" + txtBuscador.Text + "%')");
        }

        private void EliminarRegistrosNota_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Trimestre3 WHERE cod_alumno=@cod_alumno AND cod_asignatura=@cod_asignatura";

            SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());

            comando.Parameters.AddWithValue("@cod_alumno", cbCodAlumno.Text);
            comando.Parameters.AddWithValue("@cod_asignatura", cbCodAsignatura.Text);
            comando.ExecuteNonQuery(); // ENVIANDO COMPONENTE QUERY HACIA LA BASE DE DATOS CON NUEVO REGISTRO ACTUALIZADO

            if (cbCodAlumno.Text.Length == 0 || cbCodAsignatura.Text.Length == 0 || txtAct1.Text.Length == 0 || txtAct2.Text.Length == 0 || txtExam.Text.Length == 0 || mtxtPromedio.Text.Length == 0)
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

                // REFERENCIANDO EL NOMBRE DE LA TABLA A MOSTRAR LOS N DATOS CONTENIDOS EN ELLA
                SqlCommand cmd = new SqlCommand("Select * from Trimestre3", Controlador.Conexiones());
                // CREANDO ADAPTADOR DE COMUNICACION HACIA LA BASE DE DATOS PARA EL LLENADO DE REGISTROS...
                SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                MostrarRegistros.SelectCommand = cmd;
                // REFERENCIANDO LA INVOCACION DE UN NUEVO OBJETO PARA MANEJO DE DATAGRIDVIEW
                DataTable TablaRegistros = new DataTable();

                MostrarRegistros.Fill(TablaRegistros);

                DetallesTrim1Sistema.DataSource = TablaRegistros;

                cbCodAlumno.Text = "-Seleccione Codigo";
                cbCodAsignatura.Text = "-Seleccione Codigo";

                txtAct1.Clear(); txtAct2.Clear(); txtExam.Clear(); mtxtPromedio.Clear(); txtPromedio2.Clear();
            }
            Controlador.CierreConexiones(); // CIERRE DE CONEXION
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {

            if (cbCodAlumno.Text.Length == 0 || cbCodAsignatura.Text.Length == 0 || txtAct1.Text.Length == 0 || txtAct2.Text.Length == 0 || txtExam.Text.Length == 0 || mtxtPromedio.Text.Length == 0)
            {
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
            else
            {
                try
                {         
                        string query = "UPDATE Trimestre3 SET cod_alumno = @cod_alumno, cod_asignatura = @cod_asignatura, Act1 = @Act1, Act2 = @Act2, Exam = @Exam, promedio3 = @promedio3 WHERE cod_alumno=@cod_alumno AND cod_asignatura=@cod_asignatura";

                        // CREANDO CADENA DE INSERCION query CON SU PASO DE PARAMETROS HACIA LA BASE DE DATOS
                        SqlCommand comando = new SqlCommand(query, Controlador.Conexiones()); // CREANDO COMANDO DE CONEXION
                        comando.Parameters.AddWithValue("@cod_alumno", cbCodAlumno.Text);
                        comando.Parameters.AddWithValue("@cod_asignatura", cbCodAsignatura.Text);
                        comando.Parameters.AddWithValue("@Act1", Convert.ToDecimal(txtAct1.Text));
                        comando.Parameters.AddWithValue("@Act2", Convert.ToDecimal(txtAct2.Text));
                        comando.Parameters.AddWithValue("@Exam", Convert.ToDecimal(txtExam.Text));
                        comando.Parameters.AddWithValue("@promedio3", Convert.ToDecimal(txtPromedio2.Text));
                        comando.ExecuteNonQuery();

                    //CREANDO MENSAJE CON VENTANA FLOTANTE
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    SqlCommand cmd = new SqlCommand("Select * from Trimestre3", Controlador.Conexiones());

                        SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                        MostrarRegistros.SelectCommand = cmd;

                        DataTable TablaRegistros = new DataTable();

                        MostrarRegistros.Fill(TablaRegistros);
                        DetallesTrim1Sistema.DataSource = TablaRegistros;

                        cbCodAlumno.Text = "-Seleccione Codigo";
                        cbCodAsignatura.Text = "-Seleccione Codigo";

                        txtAct1.Clear(); txtAct2.Clear(); txtExam.Clear(); mtxtPromedio.Clear(); txtPromedio2.Clear();
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

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModificar.Checked == true && chkEliminar.Checked == true)
            {
                SeleccionarRegistroAsignatura.Enabled = false;
                cbCodAlumno.Enabled = false;
                cbCodAsignatura.Enabled = false;
                txtAct1.Enabled = false;
                txtAct2.Enabled = false;
                txtExam.Enabled = false;
                btnCalcularPromedio.Enabled = false;
                EliminarRegistrosNota.Enabled = false;
                btnModificarNota.Enabled = false;
            }
            else if (chkModificar.Checked == false || chkEliminar.Checked == true)
            {
                if (chkEliminar.Checked == true)
                {
                    SeleccionarRegistroAsignatura.Enabled = true;
                    cbCodAlumno.Enabled = false;
                    cbCodAsignatura.Enabled = false;
                    txtAct1.Enabled = false;
                    txtAct2.Enabled = false;
                    txtExam.Enabled = false;
                    btnCalcularPromedio.Enabled = false;
                    btnModificarNota.Enabled = false;
                    EliminarRegistrosNota.Enabled = true;
                }
                else if (chkModificar.Checked == false)
                {
                    SeleccionarRegistroAsignatura.Enabled = false;
                    cbCodAlumno.Enabled = false;
                    cbCodAsignatura.Enabled = false;
                    txtAct1.Enabled = false;
                    txtAct2.Enabled = false;
                    txtExam.Enabled = false;
                    btnCalcularPromedio.Enabled = false;
                    EliminarRegistrosNota.Enabled = false;
                    btnModificarNota.Enabled = false;
                }
            }
        }

        private void chkModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModificar.Checked == true && chkEliminar.Checked == true)
            {
                SeleccionarRegistroAsignatura.Enabled = false;
                cbCodAlumno.Enabled = false;
                cbCodAsignatura.Enabled = false;
                txtAct1.Enabled = false;
                txtAct2.Enabled = false;
                txtExam.Enabled = false;
                btnCalcularPromedio.Enabled = false;
                EliminarRegistrosNota.Enabled = false;
                btnModificarNota.Enabled = false;
            }else if (chkModificar.Checked == true || chkEliminar.Checked == false)
            {
                if (chkModificar.Checked == true)
                {
                    SeleccionarRegistroAsignatura.Enabled = true;
                    cbCodAlumno.Enabled = false;
                    cbCodAsignatura.Enabled = false;
                    txtAct1.Enabled = true;
                    txtAct2.Enabled = true;
                    txtExam.Enabled = true;
                    btnCalcularPromedio.Enabled = true;
                    EliminarRegistrosNota.Enabled = false;
                    btnModificarNota.Enabled = true;
                }
                else if (chkModificar.Checked == false)
                {
                    SeleccionarRegistroAsignatura.Enabled = false;
                    cbCodAlumno.Enabled = false;
                    cbCodAsignatura.Enabled = false;
                    txtAct1.Enabled = false;
                    txtAct2.Enabled = false;
                    txtExam.Enabled = false;
                    btnCalcularPromedio.Enabled = false;
                    EliminarRegistrosNota.Enabled = false;
                    btnModificarNota.Enabled = false;
                }
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