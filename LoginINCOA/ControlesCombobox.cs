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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginINCOA
{
    class ControlesCombobox
    {
        //INSTANCIA CONTROLADOR GENERAL DE CONEXION (TODOS LOS MANTENIMIENTOS DEL SISTEMA)
        ControlConexion Controlador = new ControlConexion();

        /*
            --> DATOS DEL COD ALUMNO
        */

        public void SeleccionarAlum(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Alumnos", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[0].ToString());
            }
            Controlador.CierreConexiones();
            DatosTablasRelacionadas.Items.Insert(0, "-Seleccione Codigo");
            DatosTablasRelacionadas.SelectedIndex = 0;
        }

        /*
            --> DATOS DEL COD ASIGNATURA
        */

        public void SeleccionarAsign(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Asignaturas", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[0].ToString());
            }
            Controlador.CierreConexiones();
            DatosTablasRelacionadas.Items.Insert(0, "-Seleccione Codigo");
            DatosTablasRelacionadas.SelectedIndex = 0;
        }
        /*
           --> DATOS DEL NOMBRE ASIGNATURA
       */

        public void SeleccionarNomAsign(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Asignaturas", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[1].ToString());
            }
            Controlador.CierreConexiones();
            DatosTablasRelacionadas.Items.Insert(0, "-Seleccione Asignatura");
            DatosTablasRelacionadas.SelectedIndex = 0;
        }
        /*
           --> DATOS DEL COD DOCENTE
       */

        public void SeleccionarDocente(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Docentes", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[0].ToString());
            }
            Controlador.CierreConexiones();
            DatosTablasRelacionadas.Items.Insert(0, "");

            DatosTablasRelacionadas.SelectedIndex = 0;
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