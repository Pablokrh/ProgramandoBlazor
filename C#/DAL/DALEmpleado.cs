using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DALEmpleado
    {

        public String VerificarUsuario(EN.ENEmpleado enEmpleado)
        {
           SqlConnection Conexion = new SqlConnection("Data Source= DESKTOP-MSJO6R8; Initial Catalog= HC-Empleados; Integrated Security= true");
           Conexion.Open();
           SqlDataAdapter adaptador;
           DataSet datos = new DataSet();
           try
            {
                adaptador = new SqlDataAdapter("execute VerificarUsuario " + enEmpleado.EmpleadoUsuario, Conexion);
                adaptador.Fill(datos, "Empleado");
                String usuarioValidado = datos.Tables[0].Rows[0]["Usuario"].ToString();

                return usuarioValidado;
           }
           catch (Exception error)
           {
                MessageBox.Show("El error es: " + error);
                return null;

            }


        }

        public String VerificarClave(EN.ENEmpleado enempleado)
        {
            SqlConnection Conexion = new SqlConnection("Data Source= DESKTOP-MSJO6R8; Initial Catalog= HC-Empleados; Integrated Security= true");
            
            try
            {
                Conexion.Open();

            }

            catch (Exception error)
            {
                MessageBox.Show("Error al tratar de conectar con la base de datos \n"+ error);
            }
            //Pongo este try/catch, aunque parece al pedo.

            SqlDataAdapter adaptador;
            DataSet datos = new DataSet();
            try
            {
                adaptador = new SqlDataAdapter("execute VerificarClave " + VerificarUsuario(enempleado), Conexion);
                adaptador.Fill(datos, "Empleado");
            }

            catch (Exception error)
            {
                return null;

            }

            String ClaveValidada = datos.Tables[0].Rows[0]["Clave"].ToString();
            return ClaveValidada;

        }


    }
}
