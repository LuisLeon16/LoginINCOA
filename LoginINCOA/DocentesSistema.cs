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
    public partial class DocentesSistema : Form
    {
        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        public DocentesSistema()
        {
            InitializeComponent();
        }

        private void btnRegistroNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (txtcod.Text.Length == 0 || txtnombres.Text.Length == 0 || txtapellidos.Text.Length == 0 || txtDireccion.Text.Length == 0 || mtxtNacimiento.Text.Length == 0 || cboGenero.Text.Length == 0 || txtTel.Text.Length == 0)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form CamposVacio = new MensajeErrorCamposVacios();
                CamposVacio.Show();
            }
            else
            {
                try
                {
                    string query = "INSERT INTO Docentes (cod_docente,nombre,apellido,f_nacimiento,direccion, genero, telefono) VALUES (@cod_docente,@nombre,@apellido,@f_nacimiento,@direccion,@genero,@telefono)";

                    // CREANDO CADENA DE INSERCION query CON SU PASO DE PARAMETROS HACIA LA BASE DE DATOS
                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones()); // CREANDO COMANDO DE CONEXION
                    comando.Parameters.AddWithValue("@cod_docente", txtcod.Text);
                    comando.Parameters.AddWithValue("@nombre", txtnombres.Text);
                    comando.Parameters.AddWithValue("@apellido", txtapellidos.Text);
                    comando.Parameters.AddWithValue("@f_nacimiento", Convert.ToDateTime(mtxtNacimiento.Text));
                    comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    comando.Parameters.AddWithValue("@genero", cboGenero.Text);
                    comando.Parameters.AddWithValue("@telefono", txtTel.Text);
                    comando.ExecuteNonQuery();

                    //CREANDO MENSAJE EN VENTANA FLOTANTE
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    SqlCommand cmd = new SqlCommand("Select * from Docentes", Controlador.Conexiones());

                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;

                    DataTable TablaRegistros = new DataTable();

                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesDocentesSistema.DataSource = TablaRegistros;

                    txtcod.Clear(); txtnombres.Clear(); txtapellidos.Clear(); mtxtNacimiento.Clear(); cboGenero.SelectedIndex = -1; txtDireccion.Clear(); txtTel.Clear();

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

        private void ActualizarTabla_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Docentes", Controlador.Conexiones());

            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;

            DataTable TablaRegistros = new DataTable();

            MostrarRegistros.Fill(TablaRegistros);
            DetallesDocentesSistema.DataSource = TablaRegistros;
        }

        private void ModificarDocente_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioModificar = new ModificarDocentes(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioModificar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void EliminarDocente_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioEliminar = new EliminarDocentes(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioEliminar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void DocentesSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.incoa_systemdbDataSet.Docentes);

            this.cboGenero.Items.Add("M");
            this.cboGenero.Items.Add("F");

        }

        private void btnBuscadorUsuarios_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioEliminar = new BuscadorDocentes(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioEliminar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
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