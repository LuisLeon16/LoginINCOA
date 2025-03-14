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
    public partial class MiniForm_Asign_Alumn : Form
    {

        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        public MiniForm_Asign_Alumn()
        {
            InitializeComponent();

            Opacity = .95;  

            BotonesRedondeados.BordesRedondeados(btnBuscadorAlumnos);
            BotonesRedondeados.BordesRedondeados(btnEliminarAlumn_Asign);
            BotonesRedondeados.BordesRedondeados(btnModificarAlumn_Asign);
            BotonesRedondeados.BordesRedondeados(btnRegistrarAlumn_Asign);
        }

        private void btnRegistrarAlumn_Asign_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioRegistrar = new Registrar_AsignAlumn(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioRegistrar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void btnModificarAlumn_Asign_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioModificar = new Modificar_AsignAlumn(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioModificar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void btnEliminarAlumn_Asign_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioModificar = new Eliminar_AsignAlumn(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioModificar.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void btnBuscadorAlumnos_Click(object sender, EventArgs e)
        {
            Form LlamarFormularioBuscador = new Buscador_AlumAsign(); // CREANDO NUEVO OBJETO DE TIPO FORMULARIO
            LlamarFormularioBuscador.Show(); // INCOVANDO SUBFORMULARIO A FORMULARIO PADRE PARA MOSTRAR SUS ACCIONES DE MANTENIMIENTO
        }

        private void MiniForm_Asign_Alumn_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height);
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
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
