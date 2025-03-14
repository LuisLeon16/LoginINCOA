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
// MANEJADOR DE EVENTOS URL --> NAVEGADORES {ENLACES}
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginINCOA
{
    public partial class InicioAdmins : Form
    {
        public InicioAdmins()
        {
            InitializeComponent();
        }

        private void Calendario_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioCalendario = new CalendarioINCOA(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioCalendario.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void APPSINCOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("En estos momentos será redirigido hacia la página de facebook de la banda musical de nuestra institución, gracias por su confianza en nosotros.", "Facebook BANDA INCOA",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/PoderIMB.IMPARABLES/");
                Process.Start(sInfo);
            }
        }

        private void lblApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("En estos momentos será redirigido hacia la página de facebook de la banda musical de nuestra institución, gracias por su confianza en nosotros.", "Facebook BANDA INCOA",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/PoderIMB.IMPARABLES/");
                Process.Start(sInfo);
            }

        }

        private void lblCalendario_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioCalendario = new CalendarioINCOA(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioCalendario.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void FacebookINCOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("En estos momentos será redirigido hacia la página de facebook de nuestra institución, gracias por su confianza en nosotros.", "Facebook INCOA",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/incoa11329oficial/");
                Process.Start(sInfo);
            }

        }

        private void lblFacebook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("En estos momentos será redirigido hacia la página de facebook de nuestra institución, gracias por su confianza en nosotros.", "Facebook INCOA",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/incoa11329oficial/");
                Process.Start(sInfo);
            }

        }

        private void AcercaDeINCOA_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioCalendario = new AcercaDeINCOA(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioCalendario.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void lblAcercaDe_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioCalendario = new AcercaDeINCOA(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioCalendario.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
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