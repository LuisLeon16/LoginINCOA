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
    public partial class ResumenTrimestres : Form
    {
        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        //CREACION DE OBJETO PARA REALIZAR LA BUSQUEDA SEGUN CONSULTA
        BaseDeDatos integracion = new BaseDeDatos();

        public ResumenTrimestres()
        {
            InitializeComponent();

          SqlCommand comando = new SqlCommand("resumen", Controlador.Conexiones());
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(comando);

            DataTable dt = new DataTable();

            Controlador.CierreConexiones();

            adapter.Fill(dt);

            DetallesPromFinalSistema.DataSource = dt;


            BotonesRedondeados.BordesRedondeados(btnCalcularPromedio);
            BotonesRedondeados.BordesRedondeados(SeleccionarRegistro);
        }

        private void PrimerTrimestre_Load(object sender, EventArgs e)
        {
            LlenarDatos();

            //COLOCA EL CURSOR EN EL AREA DESIGNADA
            this.ActiveControl = txtBuscador;
        }

        //METODO CREADO PARA LLENAR GRID CON EL PROCEDIMIENTO ALMACENADO
        public void LlenarDatos()
        {
            //ACTIVACION DE VISIBILIDAD DE DATAGRID
            DetallesPromFinalSistema.Visible = true;

            try
            {
                   SqlCommand comando = new SqlCommand("resumen", Controlador.Conexiones());
                   comando.CommandType = CommandType.StoredProcedure;

                   SqlDataAdapter adapter = new SqlDataAdapter(comando);

                   DataTable dt = new DataTable();

                   Controlador.CierreConexiones();

                   adapter.Fill(dt);

                   DetallesPromFinalSistema.DataSource = dt;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         }

        private void SeleccionarRegistro_Click(object sender, EventArgs e)
        {
            if (DetallesPromFinalSistema.SelectedRows.Count > 0)
            {
                txtCodAlumno.Text = DetallesPromFinalSistema.CurrentRow.Cells[0].Value.ToString();
                txtCodAsignatura.Text = DetallesPromFinalSistema.CurrentRow.Cells[1].Value.ToString();
                txtProm1.Text = DetallesPromFinalSistema.CurrentRow.Cells[2].Value.ToString();
                txtProm2.Text = DetallesPromFinalSistema.CurrentRow.Cells[3].Value.ToString();
                txtProm3.Text = DetallesPromFinalSistema.CurrentRow.Cells[4].Value.ToString();
                txtNF.Text = DetallesPromFinalSistema.CurrentRow.Cells[5].Value.ToString();
                Controlador.CierreConexiones();  // CIERRE DE CONEXION UNA VEZ TOMADOS LOS PARAMETROS Y ARGUMENTOS PREVIO A LA ACTUALIZACION 
            }// DE LO CONTRARIO...
            else
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
                try
                {
                    //VALIDANDO EL INGRESO DE DATOS
                    if (Convert.ToDecimal(txtProm1.Text) < 0 || Convert.ToDecimal(txtProm2.Text) < 0 || Convert.ToDecimal(txtProm3.Text) < 0)
                    {
                        MessageBox.Show("Error de datos, tome en cuenta las siguientes consideraciones: \n\n- Utilice datos numericos ya sean enteros o decimales.\n- Utilice numeros iguales o mayores a 0 y menores o iguales a 10.\n- Utilice la coma para decimales, evite usar el punto.");
                    }
                    //VALIDANDO EL INGRESO DE DATOS
                    else if (Convert.ToDecimal(txtProm1.Text) > 10 || Convert.ToDecimal(txtProm3.Text) > 10 || Convert.ToDecimal(txtProm3.Text) > 10)
                    {
                        MessageBox.Show("Error de datos, tome en cuenta las siguientes consideraciones: \n\n- Utilice datos numericos ya sean enteros o decimales.\n- Utilice numeros iguales o mayores a 0 y menores o iguales a 10.\n- Utilice la coma para decimales, evite usar el punto.");
                    }
                    else
                    {
                        //PROCESOS
                        double n1 = (Convert.ToDouble(txtProm1.Text));
                        double n2 = (Convert.ToDouble(txtProm2.Text));
                        double n3 = (Convert.ToDouble(txtProm3.Text));

                        double promedio = (n1 + n2 + n3) / 3;

                        txtNF.Text = Math.Round(promedio, 1, MidpointRounding.ToEven).ToString();
                    }
                }
                catch (Exception)
                {
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
        }

        private void btnRegistroNota_Click(object sender, EventArgs e)
        {
            if (txtCodAlumno.Text.Length == 0 || txtCodAsignatura.Text.Length == 0 || txtProm1.Text.Length == 0 || txtProm2.Text.Length == 0 || txtProm3.Text.Length == 0 || txtNF.Text.Length == 0)
            {
                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form NoSeleccion = new MensajeNoSeleccion();
                NoSeleccion.Show();
            }
            else
            {
                try
                {
                string query = "UPDATE Notas SET cod_alumno = @cod_alumno, cod_asignatura = @cod_asignatura, NotaFinal = @NotaFinal WHERE cod_alumno = @cod_alumno AND cod_asignatura = @cod_asignatura";

                SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());

                comando.Parameters.AddWithValue("@cod_alumno", txtCodAlumno.Text); 
                comando.Parameters.AddWithValue("@cod_asignatura", txtCodAsignatura.Text);
                comando.Parameters.AddWithValue("@NotaFinal", Convert.ToDecimal(txtNF.Text));
                       
                comando.ExecuteNonQuery();

                //CREANDO MENSAJE EN VENTANA FLOTANTE
                Form Aprobacion = new MensajeAprobacion();
                Aprobacion.Show();

                SqlCommand comando2 = new SqlCommand("resumen", Controlador.Conexiones());
                comando2.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(comando2);

                DataTable dt = new DataTable();

                Controlador.CierreConexiones();

                adapter.Fill(dt);

                DetallesPromFinalSistema.DataSource = dt;

                txtCodAlumno.Clear(); txtCodAsignatura.Clear(); txtProm1.Clear(); txtProm2.Clear(); txtProm3.Clear(); txtNF.Clear();
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

        //BUSCADOR
        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            //BUSCADOR PERSONALIZADO POR CODIGO
            DetallesPromFinalSistema.DataSource = integracion.SelectDataTable("SELECT * FROM vista_datos WHERE cod_alumno LIKE ('" + txtBuscador.Text + "%') OR cod_asignatura LIKE ('" + txtBuscador.Text + "%')");
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
