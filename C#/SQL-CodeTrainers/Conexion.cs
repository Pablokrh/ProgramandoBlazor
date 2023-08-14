using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SQL_CodeTrainers
{
    public class Conexion
    { 
        public SqlConnection LeerCadena()
            //Ahí se ve que va a devolver un objeto de tipo sqlConnection
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            //Crea el objeto ///Para utilizar el configurationmanager se importó sysyem.configuration
            //lo que sigue es una validación // ConnectionState requiere System.data
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();

            }
            else
            {
                cn.Open();
            }
            //Si está cerrado se cierra y viceversa. Eso es lo que retorna.
            return cn;
        }

    }
}
 