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
    public partial class MensajeCierreSesion : Form
    {
        public MensajeCierreSesion()
        {
            InitializeComponent();
            Opacity = .95;

            BotonesRedondeados.BordesRedondeados(btnAceptar);
            BotonesRedondeados.BordesRedondeados(btnRechazar);
        }

        // POSICION PANTALLA MENSAJE PERSONALIZADO
        private void MensajeCierreSesion_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height);
        }

        // CONFIRMACION DE CIERRE DE SESION
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // CIERRE UNICAMENTE DE VENTANA EMERGENTE
        private void btnRechazar_Click(object sender, EventArgs e)
        {
            this.Close();
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