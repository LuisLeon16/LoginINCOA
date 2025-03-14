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
//IMPORTANDO LIBRERIA PARA REALIZAR CONEXION A LA BASE DE DATOS
using System.Data.SqlClient;

namespace LoginINCOA
{
    class ControlConexion
    {
        public SqlConnection Conexiones()
        {
            //CREACION DE UNA INSTANCIA CON CADENA DE CONEXION (NOMBRE DEL SERVIDOR, NOMBRE DE LA BASE DE DATOS Y LA AUTENTIFICACION DE WINDOWS)
            SqlConnection ConexionSistema = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=incoa_systemdb;Integrated Security=True");
            ConexionSistema.Open();
            return ConexionSistema;
        }

        public SqlConnection CierreConexiones()
        {
            SqlConnection ConexionSistema = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=incoa_systemdb;Integrated Security=True");
            ConexionSistema.Close();
            return ConexionSistema;
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
