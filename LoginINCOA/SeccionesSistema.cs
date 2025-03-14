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
    public partial class SeccionesSistema : Form
    {
        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        public SeccionesSistema()
        {
            InitializeComponent();
        }

       

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Secciones", Controlador.Conexiones());

            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;

            DataTable TablaRegistros = new DataTable();

            MostrarRegistros.Fill(TablaRegistros);
            DetallesSeccionesSistema.DataSource = TablaRegistros;
        }

        private void btnRegistroNuevoSeccion_Click(object sender, EventArgs e)
        {
            if (txtIdSeccion.Text.Length == 0 || txtnombreSeccion.Text.Length == 0 || txtSeccion.Text.Length == 0 || txtCapacidad.Text.Length == 0)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form CamposVacio = new MensajeErrorCamposVacios();
                CamposVacio.Show();
            }
            else
            {
                try
                {
                    string query = "INSERT INTO Secciones (cod_seccion,nombre,seccion,capacidad) VALUES (@cod_seccion,@nombre,@seccion,@capacidad)";

                    // CREANDO CADENA DE INSERCION query CON SU PASO DE PARAMETROS HACIA LA BASE DE DATOS
                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones()); // CREANDO COMANDO DE CONEXION
                    comando.Parameters.AddWithValue("@cod_seccion", txtIdSeccion.Text);
                    comando.Parameters.AddWithValue("@nombre", txtnombreSeccion.Text);
                    comando.Parameters.AddWithValue("@seccion", txtSeccion.Text);
                    comando.Parameters.AddWithValue("@capacidad", txtCapacidad.Text);
                    comando.ExecuteNonQuery();

                    //CREANDO MENSAJE EN VENTANA FLOTANTE
                    Form Aprobacion = new MensajeAprobacion();
                    Aprobacion.Show();

                    SqlCommand cmd = new SqlCommand("Select * from Secciones", Controlador.Conexiones());

                    SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                    MostrarRegistros.SelectCommand = cmd;

                    DataTable TablaRegistros = new DataTable();

                    MostrarRegistros.Fill(TablaRegistros);
                    DetallesSeccionesSistema.DataSource = TablaRegistros;

                    txtIdSeccion.Clear(); txtnombreSeccion.Clear(); txtSeccion.Clear(); txtCapacidad.Clear();

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

        private void btnModificarSecciones_Click(object sender, EventArgs e)
        {
              Form LlamarFormularioModificar = new ModificarSecciones(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
              LlamarFormularioModificar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void btnEliminarSecciones_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioEliminar = new EliminarSecciones(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioEliminar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        
        }

        private void SeccionesSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Secciones' Puede moverla o quitarla según sea necesario.
            this.seccionesTableAdapter.Fill(this.incoa_systemdbDataSet.Secciones);

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