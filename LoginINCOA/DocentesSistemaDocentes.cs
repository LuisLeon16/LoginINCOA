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
    public partial class DocentesSistemaDocentes : Form
    {
        //CREACION DE OBJETO PARA REALIZAR LA BUSQUEDA SEGUN CONSULTA
        BaseDeDatos integracion = new BaseDeDatos();

        public DocentesSistemaDocentes()
        {
            InitializeComponent();
        }

        private void DocentesSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.incoa_systemdbDataSet.Docentes);
            // TODO: esta línea de código carga datos en la tabla 'incoa_systemdbDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.incoa_systemdbDataSet.Docentes);

            this.ActiveControl = txtBuscador;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
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