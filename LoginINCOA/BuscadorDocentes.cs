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
using System.Runtime.InteropServices;

namespace LoginINCOA
{
    public partial class BuscadorDocentes : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //CREACION DE OBJETO PARA REALIZAR LA BUSQUEDA SEGUN CONSULTA
        BaseDeDatos integracion = new BaseDeDatos();

        public BuscadorDocentes()
        {
            InitializeComponent();
        }

        //PRUEBA BUSCADOR

        /*string query = "select * from Docentes where " + cboSeleccion.Text + " like '%" + txtBuscador.Text + "%'";

         SqlDataAdapter ada = new SqlDataAdapter(query, Controlador.Conexiones());

         DataSet data = new DataSet();

         ada.Fill(data, "Docentes");

         DetallesAlumnosSistema.DataSource = data;
         DetallesAlumnosSistema.DataMember = "Docentes";*/


        private void BuscadorAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.incoa_systemdbDataSet.Docentes);

            //COLOCA EL CURSOR EN EL AREA DESIGNADA
            this.ActiveControl = txtBuscador;
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BuscadorAlumnos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            //BUSCADOR PERSONALIZADO POR CODIGO, NOMBRE, APELLIDO Y DIRECCION
            DetallesDocentesSistema.DataSource = integracion.SelectDataTable("SELECT * FROM Docentes WHERE nombre LIKE ('" + txtBuscador.Text + "%') OR apellido LIKE ('" + txtBuscador.Text + "%') OR cod_docente LIKE ('" + txtBuscador.Text + "%') OR direccion LIKE ('" + txtBuscador.Text + "%')");
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