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
    public partial class Docente : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Docente(string nombre)
        {
            InitializeComponent();
            NombreUsuarioAD.Text = nombre; // DEVUELVE NOMBRE DE USUARIO REGISTRADO
            timer1.Enabled = true; // VALIDA EVENTO MUESTRA HORA/FECHA ACTUAL

            MostrarFormularios(new InicioDocente());

            Opacity = .97;
        }

        private void Docente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(1300, 650);
            CenterToScreen();

            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIconPanel_Click(object sender, EventArgs e)
        {
            if (IconContainer.Width == 211)
            {
                IconContainer.Width = 98;
                IconPanel.Width = 118;
                SaludoAD.Visible = false; //OCULTAMIENTO DE SALUDO
                NombreUsuarioAD.Visible = false; //OCULTAMMIENTO DE NOMBRE
            }
            else if (IconContainer.Width == 98)
            {
                IconContainer.Width = 211;
                IconPanel.Width = 234;
                SaludoAD.Visible = true; //VISIBILIDAD AL SALUDO AL DESPLEGAR PANEL
                NombreUsuarioAD.Visible = true; //VISIBILIDAD AL NOMBRE AL DESPLEGAR PANEL
            }
        }

        private void MostrarFormularios(object MostrandoSubFormularios)
        {
            // SI EL FORMULARIO PRESENTA CONTROLES POR DEFECTO, OJO NO CREADOS EXTERNAMENTE
            // ESTE LOS ELIMINARA...
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            // CREANDO INSTANCIA PARA MOSTRAR SUBFORMULARIOS DEL SISTEMA
            Form FormulariosSistema = MostrandoSubFormularios as Form;
            FormulariosSistema.TopLevel = false; // FORMUNARIOS DE NO ALTO NIVEL {TIPO SECUNDARIOS A MOSTRAR}
            FormulariosSistema.Dock = DockStyle.Fill; // RELLENAR FORMULARIO AL ANCHO TOTAL DEL PANEL CONTENEDOR
            this.panelContenedor.Controls.Add(FormulariosSistema); // MOSTRAR TODOS LOS ELEMENTOS DEL FORMULARIO
            this.panelContenedor.Tag = FormulariosSistema; // DECLARANDO INSTANCIA AL PANEL CONTENEDOR
            FormulariosSistema.Show(); // MOSTRAR EL X FORMULARIO A TRATAR EN EL SISTEMA
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            btnCerrarSesion.BackColor = Color.FromArgb(65, 60, 83);
            btnCerrarSesion.ForeColor = Color.White;

            btnDocentes.BackColor = Color.FromArgb(35, 37, 45);
            btnDocentes.ForeColor = Color.White;
            btnAlumnos.BackColor = Color.FromArgb(35, 37, 45);
            btnAlumnos.ForeColor = Color.White;
            btnNotas.BackColor = Color.FromArgb(35, 37, 45);
            btnNotas.ForeColor = Color.White;

            DialogResult resultado = new DialogResult();

            Form Cierre = new MensajeCierreSesion();
            resultado = Cierre.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.Close();// CIERRE COMPLETO UNICAMENTE DE LA BASE DE DATOS --> {USUARIO DADO DE ALTA EN ESE MOMENTO}
                this.Hide();// OCULTA PANEL DE ADMINISTRACION PARA CERRAR SESION
                Form1 cerrandosesion = new Form1();// CREANDO INSTANCIA DE CIERRE DE SESION
                cerrandosesion.ShowDialog();// MUESTRA NUEVAMENTE VENTANA DE LOGIN
            }

            if (resultado == DialogResult.Cancel)
            {
                // ESTADO INACTIVO ↓ {TODOS} -> BOTONES

                btnCerrarSesion.BackColor = Color.FromArgb(35, 37, 45);
                btnCerrarSesion.ForeColor = Color.White;
                btnDocentes.BackColor = Color.FromArgb(35, 37, 45);
                btnDocentes.ForeColor = Color.White;
                btnAlumnos.BackColor = Color.FromArgb(35, 37, 45);
                btnAlumnos.ForeColor = Color.White;
                btnNotas.BackColor = Color.FromArgb(35, 37, 45);
                btnNotas.ForeColor = Color.White;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraSistema.Text = DateTime.Now.ToString();
        }

        private void IconInicioRetorno_Click(object sender, EventArgs e)
        {
            // INVOCANDO FORMULARIO DE BIENVENIDA PARA USUARIOS DOCENTES
            MostrarFormularios(new InicioDocente());

            btnCerrarSesion.BackColor = Color.FromArgb(35, 37, 45);
            btnCerrarSesion.ForeColor = Color.White;
            btnDocentes.BackColor = Color.FromArgb(35, 37, 45);
            btnDocentes.ForeColor = Color.White;
            btnAlumnos.BackColor = Color.FromArgb(35, 37, 45);
            btnAlumnos.ForeColor = Color.White;
            btnNotas.BackColor = Color.FromArgb(35, 37, 45);
            btnNotas.ForeColor = Color.White;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new AlumnosSistemaDocente());

            //    --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO

           btnAlumnos.BackColor = Color.FromArgb(65, 60, 83);  // ESTADO ACTIVO   
           btnAlumnos.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO 

            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES

            btnCerrarSesion.BackColor = Color.FromArgb(35, 37, 45);
            btnCerrarSesion.ForeColor = Color.White;
            btnDocentes.BackColor = Color.FromArgb(35, 37, 45);
            btnDocentes.ForeColor = Color.White;
            btnNotas.BackColor = Color.FromArgb(35, 37, 45);
            btnNotas.ForeColor = Color.White;
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new DocentesSistemaDocentes());

            //    --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO

            btnDocentes.BackColor = Color.FromArgb(65, 60, 83);  // ESTADO ACTIVO   
            btnDocentes.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO 

            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES
            btnCerrarSesion.BackColor = Color.FromArgb(35, 37, 45);
            btnCerrarSesion.ForeColor = Color.White;
            btnAlumnos.BackColor = Color.FromArgb(35, 37, 45);
            btnAlumnos.ForeColor = Color.White;
            btnNotas.BackColor = Color.FromArgb(35, 37, 45);
            btnNotas.ForeColor = Color.White;
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new NotasSistema());

            //    --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO

            btnNotas.BackColor = Color.FromArgb(65, 60, 83);  // ESTADO ACTIVO   
            btnNotas.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO 

            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES

            btnCerrarSesion.BackColor = Color.FromArgb(35, 37, 45);
            btnCerrarSesion.ForeColor = Color.White;
            btnDocentes.BackColor = Color.FromArgb(35, 37, 45);
            btnDocentes.ForeColor = Color.White;
            btnAlumnos.BackColor = Color.FromArgb(35, 37, 45);
            btnAlumnos.ForeColor = Color.White;
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