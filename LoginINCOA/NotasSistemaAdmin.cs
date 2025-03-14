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
    public partial class NotasSistemaAdmin : Form
    {

        public NotasSistemaAdmin()
        {
            InitializeComponent();

            //LLAMANDO CLASE DE BOTONES PERSONALIZADOS (CLASE - METODO)
            BotonesRedondeados.BordesRedondeados(btnPrimerTrimestre);
            BotonesRedondeados.BordesRedondeados(btnSegundoTrimestre);
            BotonesRedondeados.BordesRedondeados(btnTercerTrimestre);
            BotonesRedondeados.BordesRedondeados(btnResumen);
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

        //LLENANDO CONTENEDOR CON EL PRIMER TRIMESTRE
        private void btnPrimerTrimestre_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new PrimerTrimestreAdmin());

            //    --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO

            btnPrimerTrimestre.BackColor = Color.DeepSkyBlue;  // ESTADO ACTIVO   
            btnPrimerTrimestre.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO 

            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES

            btnSegundoTrimestre.BackColor = Color.DarkOrange;
            btnSegundoTrimestre.ForeColor = Color.White;
            btnTercerTrimestre.BackColor = Color.DarkOrange;
            btnTercerTrimestre.ForeColor = Color.White;
            btnResumen.BackColor = Color.DarkOrange;
            btnResumen.ForeColor = Color.White;
        }

        //LLENANDO CONTENEDOR CON EL SEGUNDO TRIMESTRE
        private void btnSegundoTrimestre_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new SegundoTrimestreAdmin());

            //    --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO

            btnSegundoTrimestre.BackColor = Color.DeepSkyBlue;  // ESTADO ACTIVO   
            btnSegundoTrimestre.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO 

            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES

            btnPrimerTrimestre.BackColor = Color.DarkOrange;
            btnPrimerTrimestre.ForeColor = Color.White;
            btnTercerTrimestre.BackColor = Color.DarkOrange;
            btnTercerTrimestre.ForeColor = Color.White;
            btnResumen.BackColor = Color.DarkOrange;
            btnResumen.ForeColor = Color.White;
        }

        //LLENANDO CONTENEDOR CON EL TERCER TRIMESTRE
        private void btnTercerTrimestre_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new TercerTrimestreAdmin());

            //    --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO

            btnTercerTrimestre.BackColor = Color.DeepSkyBlue;  // ESTADO ACTIVO   
            btnTercerTrimestre.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO 

            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES

            btnSegundoTrimestre.BackColor = Color.DarkOrange;
            btnSegundoTrimestre.ForeColor = Color.White;
            btnPrimerTrimestre.BackColor = Color.DarkOrange;
            btnPrimerTrimestre.ForeColor = Color.White;
            btnResumen.BackColor = Color.DarkOrange;
            btnResumen.ForeColor = Color.White;
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new ResumenTrimestresAdmin());

            //    --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO

            btnResumen.BackColor = Color.DeepSkyBlue;  // ESTADO ACTIVO   
            btnResumen.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO 

            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES

            btnSegundoTrimestre.BackColor = Color.DarkOrange;
            btnSegundoTrimestre.ForeColor = Color.White;
            btnTercerTrimestre.BackColor = Color.DarkOrange;
            btnTercerTrimestre.ForeColor = Color.White;
            btnPrimerTrimestre.BackColor = Color.DarkOrange;
            btnPrimerTrimestre.ForeColor = Color.White;
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