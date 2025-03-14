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

namespace LoginINCOA
{
    public partial class AlumnosSistema : Form
    {
        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        public AlumnosSistema()
        {
            InitializeComponent();
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Alumnos", Controlador.Conexiones());

            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;

            DataTable TablaRegistros = new DataTable();

            MostrarRegistros.Fill(TablaRegistros);
            DetallesUsuariosSistema.DataSource = TablaRegistros;
        }

        private void btnRegistroNuevoAlumno_Click(object sender, EventArgs e)
        {
            if (txtcod.Text.Length == 0 || txtnombre.Text.Length == 0 || txtapellido.Text.Length == 0 || mtxtNacimiento.Text.Length == 0 || txtDireccion.Text.Length == 0 || cboGenero.Text.Length == 0 || txtTelefono.Text.Length == 0 || txtSeccion.Text.Length == 0)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form CamposVacio = new MensajeErrorCamposVacios();
                CamposVacio.Show();
            }
            else
            {
                try
                {
                    string query = "INSERT INTO Alumnos (cod_alumno, nombre, apellido, f_nacimiento, Direccion, genero, especialidad, año, telefono, cod_seccion) VALUES (@cod_alumno, @nombre, @apellido, @f_nacimiento, @Direccion, @genero, @especialidad, @año, @telefono, @cod_seccion)";

                    // CREANDO CADENA DE INSERCION query CON SU PASO DE PARAMETROS HACIA LA BASE DE DATOS
                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones()); // CREANDO COMANDO DE CONEXION
                    comando.Parameters.AddWithValue("@cod_alumno", txtcod.Text);
                    comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    comando.Parameters.AddWithValue("@apellido", txtapellido.Text);
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

                    SqlCommand cmd = new SqlCommand("Select * from Alumnos", Controlador.Conexiones());

                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;

                    DataTable TablaRegistros = new DataTable();

                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesUsuariosSistema.DataSource = TablaRegistros;

                    txtcod.Clear(); txtnombre.Clear(); txtapellido.Clear(); mtxtNacimiento.Clear(); txtDireccion.Clear(); cboGenero.SelectedIndex = -1; cboEspecialidad.SelectedIndex = -1; txtAnio.Clear(); txtTelefono.Clear(); txtSeccion.Clear();

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

        private void btnModificarAlumnos_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioModificar = new ModificarAlumnos(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioModificar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO  
        }

        private void btnEliminarAlumnos_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioModificar = new EliminarAlumnos(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioModificar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO  
        }

        private void AlumnosSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.incoa_systemdbDataSet.Alumnos);

            this.cboGenero.Items.Add("M");
            this.cboGenero.Items.Add("F");

            this.cboEspecialidad.Items.Add("General");
            this.cboEspecialidad.Items.Add("Contador");
            this.cboEspecialidad.Items.Add("Software");
        }

        private void btnBuscadorAlumnos_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioBuscador = new BuscadorAlumnos(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioBuscador.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO  
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