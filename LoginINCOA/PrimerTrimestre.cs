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
    public partial class PrimerTrimestre : Form
    {
        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        //CREACION DE OBJETO PARA REALIZAR LA BUSQUEDA SEGUN CONSULTA
        BaseDeDatos integracion = new BaseDeDatos();

        public PrimerTrimestre()
        {
            InitializeComponent();

            if (DetallesTrim1Sistema.SelectedRows.Count < 0)
            {
                DetallesTrim1Sistema.DataSource = integracion.SelectDataTable("SELECT * FROM Trimestre1");
            }

            BotonesRedondeados.BordesRedondeados(btnAgregarNotas); // BOTON AGREGAR
            BotonesRedondeados.BordesRedondeados(btnActualizarTabla); //BOTON ACTUALIZAR TABLA

        }

        private void PrimerTrimestre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Trimestre1' Puede moverla o quitarla según sea necesario.
            this.trimestre1TableAdapter.Fill(this.incoa_systemdbDataSet.Trimestre1);
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.incoa_systemdbDataSet.Alumnos);

            //COLOCA EL CURSOR EN EL AREA DESIGNADA
            this.ActiveControl = txtBuscador;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            //BUSCADOR PERSONALIZADO POR CODIGO, NOMBRE, APELLIDO, COD SECCION Y ESPECIALIDAD
            DetallesAlumnosSistema.DataSource = integracion.SelectDataTable("SELECT * FROM Alumnos WHERE nombre LIKE ('" + txtBuscador.Text + "%') OR apellido LIKE ('" + txtBuscador.Text + "%') OR especialidad LIKE ('" + txtBuscador.Text + "%')  OR cod_alumno LIKE ('" + txtBuscador.Text + "%') OR cod_seccion LIKE ('" + txtBuscador.Text + "%')");
        }

        private void DetallesAlumnosSistema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Ocultador.Visible = false;
            btnActualizarTabla.Enabled = true;
            btnAgregarNotas.Enabled = true;
            
            //RELLENAR TXT LUEGO DE SELECCIONARLO EN EL DATAGRID IZQUIERDO (ALUMNOS)
            txtCodAlumno.Text = DetallesAlumnosSistema.CurrentRow.Cells[0].Value.ToString();
            txtNombres.Text = (string)DetallesAlumnosSistema.CurrentRow.Cells[1].Value;
            txtApellidos.Text = (string)DetallesAlumnosSistema.CurrentRow.Cells[2].Value;
            txtEspecialidad.Text = DetallesAlumnosSistema.CurrentRow.Cells[3].Value.ToString();
            txtSeccion.Text = DetallesAlumnosSistema.CurrentRow.Cells[4].Value.ToString();

            LlenarDatos();

        }

        public void LlenarDatos()
        {
            //ACTIVACION DE VISIBILIDAD DE DATAGRID
            DetallesTrim1Sistema.Visible = true;

            string query = "Select * from Trimestre1 WHERE cod_alumno LIKE ('" + txtCodAlumno.Text + "%')";

            SqlCommand cmd = new SqlCommand(query, Controlador.Conexiones());

            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;
            DataTable TablaRegistros = new DataTable();
            MostrarRegistros.Fill(TablaRegistros);
            DetallesTrim1Sistema.DataSource = TablaRegistros;

        }

        private void btnAgregarNotas_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioAgregar = new AgregarNotasTrim1(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioAgregar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO  
        }

        private void ActualizarTabla_Click(object sender, EventArgs e)
        {
            LlenarDatos();
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
