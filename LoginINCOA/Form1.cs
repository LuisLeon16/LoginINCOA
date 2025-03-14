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
// IMPORTANDO LIBRERIA SERVICIO CLIENTE C# -> SQL SERVER
using System.Data.SqlClient;
// IMPORTANDO LIBRERIA QUE HABILITA EL EVENTO DE ARRASTRES DE FORMULARIOS POR PARTE DE LOS USUARIOS
using System.Runtime.InteropServices;

namespace LoginINCOA
{
    public partial class Form1 : Form
    {
        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        public void loguear(string usuario, string contrasena)
        {
            if (CajaUsuariosLogin.Text.Length == 0 || PassLogin.Text.Length == 0) // USUARIO VACIO
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form CamposVacio = new MensajeErrorCamposVacios();
                CamposVacio.Show();

                CajaUsuariosLogin.Clear();
                PassLogin.Clear();
                CajaUsuariosLogin.Focus();

            }
            //FIN --> VALIDACION DE CAJAS DE TEXTO VACIAS
            else { 
           try
            {
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario FROM Usuarios WHERE Usuario = @usuario AND Password = @pas", Controlador.Conexiones());
                // PARAMETROS DE CONSULTA
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // SI CONTADOR ES IGUAL A 1, EXISTEN REGISTROS EN LA BASE DE DATOS
                if (dt.Rows.Count == 1)
                {
                    this.Hide(); // OCULTA DATOS DE INGRESO
                    /*
                        USUARIOS NIVEL --> ADMINISTRADORES
                     */
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                          //INVOCANDO PANTALLA DE ESPERA ANTES DE INICIAR LA APLICACION
                       
                        this.Hide(); // SE OCULTA VENTANA LOGIN PARA MOSTRAR VENTANA DE CARGA
                        BienvenidaUsuarios vistabienvenida = new BienvenidaUsuarios(); // INSTANCIA (OBJETO) CREADO PARA INVOCAR VENTANA
                        vistabienvenida.ShowDialog(); // MUESTRA VENTANA TIPO --> VENTANA DE DIALOGO
               
                          //MUESTRA VENTANA DE ADMINISTRACION --> USUARIOS NIVEL ADMINISTRADOR
                        
                        new Admin(dt.Rows[0][0].ToString()).Show();          
                    }
                    else if (dt.Rows[0][1].ToString() == "Docente")
                    {
                        this.Hide(); // SE OCULTA VENTANA LOGIN PARA MOSTRAR VENTANA DE CARGA
                        BienvenidaUsuariosDocentes vistabienvenida = new BienvenidaUsuariosDocentes(); // INSTANCIA (OBJETO) CREADO PARA INVOCAR VENTANA
                        vistabienvenida.ShowDialog(); // MUESTRA VENTANA TIPO --> VENTANA DE DIALOGO
                       
                        new Docente(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else 
                { // DE LO CONTRARIO, NO ACCEDE...
                  // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                    Form llamadatarearechazada = new MensajeErrorLogin();
                    llamadatarearechazada.Show(); // FINALIZA TAREA  

                        CajaUsuariosLogin.Clear();
                        PassLogin.Clear();
                        CajaUsuariosLogin.Focus();
                        ContraLogin();
                }
            }

            catch (Exception)
            {
                // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
                Form ErrorDB = new MensajeErrorDB();
                ErrorDB.Show();
            }

            finally
            {
                Controlador.CierreConexiones(); // CIERRE DE CONEXION
            }
            }
        }

        public Form1()
        {
            InitializeComponent();

            LogoLogin.BackColor = Color.Transparent;
            textoIniciarSesion.BackColor = Color.Transparent;
            textoContrasena.BackColor = Color.Transparent;
            imgUser.BackColor = Color.Transparent;
            imgPass.BackColor = Color.Transparent;
            // ESTILOS DE BORDES REDONDEADOS EN BOTONES
            BotonesRedondeados.BordesRedondeados(btnIniciarSesion); // BOTON INICIAR SESION
            // OPACIDAD GENERAL DE FORM
            this.Opacity = .97;
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO {APLICABLE A SOLO CONTENEDOR DE FORMULARIO}
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            //CREANDO BORDE REDONDEADO A FORMULARIO DE LOGUEO
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int heigh);


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
            //COLOCA EL CURSOR EN EL AREA DESIGNADA
            this.ActiveControl = CajaUsuariosLogin;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            loguear(this.CajaUsuariosLogin.Text, this.PassLogin.Text); // CAPTURA N DATOS INGRESADOS Y COMPARA CADENAS
        }

        private void CajaUsuariosLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(this, new EventArgs());
            }
        }

        private void PassLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(this, new EventArgs());
            }
        }

        private void CajaUsuariosLogin_Enter(object sender, EventArgs e)
        {
            // SI FOCO SE ENCUENTRA ACTIVO, ENTONCES...
            if (CajaUsuariosLogin.Text == "Ingrese su usuario...")
            {
                CajaUsuariosLogin.Text = "";
                CajaUsuariosLogin.ForeColor = Color.Black;
            }
        }

        private void CajaUsuariosLogin_Leave(object sender, EventArgs e)
        {
            // SI FOCO NO SE ENCUENTRA ACTIVO, ENTONCES...
            if (CajaUsuariosLogin.Text == "")
            {
                CajaUsuariosLogin.Text = "Ingrese su usuario...";
                CajaUsuariosLogin.ForeColor = Color.LightGray;
            }
        }

        private void PassLogin_Enter(object sender, EventArgs e)
        {
            // SI FOCO SE ENCUENTRA ACTIVO, ENTONCES...
            if (PassLogin.Text == "password")
            {
                PassLogin.Text = "";
                PassLogin.ForeColor = Color.Black;
            }
        }

        private void PassLogin_Leave(object sender, EventArgs e)
        {
            // SI FOCO NO SE ENCUENTRA ACTIVO, ENTONCES...
            if (PassLogin.Text == "")
            {
                PassLogin.Text = "password";
                PassLogin.ForeColor = Color.LightGray;
            }
        }

        public void ContraLogin()
        {
            if (PassLogin.Text == "password")
            {
                PassLogin.Text = "";
                PassLogin.ForeColor = Color.Black;
            }
            else if (PassLogin.Text == "")
            {
                PassLogin.Text = "password";
                PassLogin.ForeColor = Color.LightGray;
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
