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
    public partial class BuscadorAlumnos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //CREACION DE OBJETO PARA REALIZAR LA BUSQUEDA SEGUN CONSULTA
        BaseDeDatos integracion = new BaseDeDatos();

        public BuscadorAlumnos()
        {
            InitializeComponent();
        }


        private void BuscadorAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.incoa_systemdbDataSet.Alumnos);

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
            //BUSCADOR PERSONALIZADO POR CODIGO, NOMBRE, APELLIDO, DIRECCION, SECCION Y ESPECIALIDAD
            DetallesAlumnosSistema.DataSource = integracion.SelectDataTable("SELECT * FROM Alumnos WHERE nombre LIKE ('" + txtBuscador.Text + "%') OR apellido LIKE ('" + txtBuscador.Text + "%') OR cod_seccion LIKE ('" + txtBuscador.Text + "%') OR especialidad LIKE ('" + txtBuscador.Text + "%') OR cod_alumno LIKE ('" + txtBuscador.Text + "%') OR Direccion LIKE ('" + txtBuscador.Text + "%')");
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