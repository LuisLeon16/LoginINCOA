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
    public partial class frmUsuariosSistema : Form
    {
        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        public frmUsuariosSistema()
        {
            InitializeComponent();
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Usuarios", Controlador.Conexiones());

            SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
            MostrarRegistros.SelectCommand = cmd;

            DataTable TablaRegistros = new DataTable();

            MostrarRegistros.Fill(TablaRegistros);
            DetallesUsuariosSistema.DataSource = TablaRegistros;
        }

        private void btnRegistroNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (txtnombres.Text.Length == 0 || txtusuario.Text.Length == 0 || txtpass.Text.Length == 0 || cbotipo.Text.Length == 0)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form CamposVacio = new MensajeErrorCamposVacios();
                CamposVacio.Show();
            }
            else
            {
                try
                {
                    SqlCommand Comunicacion = new SqlCommand("SELECT Nombre, Usuario FROM Usuarios WHERE Nombre = @Nombre OR Usuario = @Usuario", Controlador.Conexiones());
                    Comunicacion.Parameters.AddWithValue("Nombre", txtnombres.Text);
                    Comunicacion.Parameters.AddWithValue("Usuario", txtusuario.Text);
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
                        txtnombres.Clear(); txtusuario.Clear(); txtpass.Clear(); cbotipo.SelectedIndex = -1;
                    }
                    else
                    {
                        string query = "INSERT INTO Usuarios (Nombre,Usuario,Password,Tipo_usuario) VALUES (@nombre,@usuario,@password,@tipo_usuario)";

                        // CREANDO CADENA DE INSERCION query CON SU PASO DE PARAMETROS HACIA LA BASE DE DATOS
                        SqlCommand comando = new SqlCommand(query, Controlador.Conexiones()); // CREANDO COMANDO DE CONEXION
                        comando.Parameters.AddWithValue("@nombre", txtnombres.Text);
                        comando.Parameters.AddWithValue("@usuario", txtusuario.Text);
                        comando.Parameters.AddWithValue("@password", txtpass.Text);
                        comando.Parameters.AddWithValue("@tipo_usuario", cbotipo.Text);
                        comando.ExecuteNonQuery();

                        //CREANDO MENSAJE EN VENTANA FLOTANTE
                        Form Aprobacion = new MensajeAprobacion();
                        Aprobacion.Show();

                        SqlCommand cmd = new SqlCommand("Select * from Usuarios", Controlador.Conexiones());

                        SqlDataAdapter MostrarRegistros = new SqlDataAdapter();
                        MostrarRegistros.SelectCommand = cmd;

                        DataTable TablaRegistros = new DataTable();

                        MostrarRegistros.Fill(TablaRegistros);
                        DetallesUsuariosSistema.DataSource = TablaRegistros;

                        txtnombres.Clear(); txtusuario.Clear(); txtpass.Clear(); cbotipo.SelectedIndex = -1;
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

        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioModificar = new ModificarUsuarios(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioModificar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioEliminar = new EliminarUsuarios(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioEliminar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void frmUsuariosSistema_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.incoa_systemdbDataSet.Usuarios);

        }

        private void frmUsuariosSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.incoa_systemdbDataSet.Usuarios);

            this.cbotipo.Items.Add("Admin");
            this.cbotipo.Items.Add("Docente");
        }

        private void btnBuscadorUsuarios_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioEliminar = new BuscadorUsuarios(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
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