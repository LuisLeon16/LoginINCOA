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

namespace LoginINCOA
{
    public partial class MensajeErrorCamposVacios : Form
    {
        // INICIALIZACION TIMER CONTEO REGRESIVO -> VENTANA EMERGENTE
        Timer CuentaRegresiva = new Timer();
        int InicializacionConteo = 2;  // -> CONTEO DESCENDENTE INICIAL EN 2s

        public MensajeErrorCamposVacios()
        {
            InitializeComponent();
            Opacity = .95;

            CuentaRegresiva.Interval = 1000;        // INTERVALO 1000ms
            CuentaRegresiva.Enabled = true;         // HABILITANDO CONTEO REGRESIVO
            CuentaRegresiva.Tick += ConteoRegresivo_Tick;    // ACUMULATIVO -> VALIDO 1 EVENTO RECARGABLE
            CuentaRegresiva.Start();                // INICIANDO CONTEO REGRESITO [START]


            BotonesRedondeados.BordesRedondeados(btnAceptar);
        }

        // POSICION PANTALLA VENTANA EMERGENTE PERSONALIZADO
        private void MensajeErrorCamposVacios_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height);
        }

        // CERRAR VENTANA -> BOTON CONTENEDOR MENSAJE
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CERRAR VENTANA -> BOTON SUPERIOR CIERRE
        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConteoRegresivo_Tick(object sender, EventArgs e)
        {
            InicializacionConteo -= 1;  // CONTEO DESCENDENTE 1 EN 1... APLICABLE UNA VEZ POR EVENTO [RECARGABLE]
            // SI CONTEO FINALIZA EN 0 ENTONCES
            if (InicializacionConteo < 0)
            {
                // DETENCION DE CONTEO REGRESIVO
                CuentaRegresiva.Stop();
                this.Hide();    // OCULTAR VENTANA EMERGENTE
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