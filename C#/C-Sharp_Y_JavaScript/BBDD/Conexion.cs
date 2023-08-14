using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BBDD
{
    public class Conexion
    {
        string conexionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;

        public void CrearBase()
        {
            using (SqlConnection conectando = new SqlConnection(conexionString))
            {
                conectando.Open();
                string queryCreaBBDD= "CREATE TABLE [dbo].[Usuarios] (" +
                                    "[Id] INT NOT NULL,"+
                                    "[Nombre] NCHAR(40) NULL,"+
                                    "[Apellido] NCHAR(40) NULL,"+
                                    "[Edad] INT NULL,"+
                                    "PRIMARY KEY CLUSTERED([Id] ASC))";
                SqlCommand comando = new SqlCommand(queryCreaBBDD, conectando);
                comando.ExecuteNonQuery();
                conectando.Close();
            }           
        }


        public void InsertarUsuario(int id, string nombre, string apellido, int edad)
        {
            using (SqlConnection conectanding = new SqlConnection(conexionString))
            {
                conectanding.Open();
                string queryInsertar = "insert into Usuarios(Id, Nombre, Apellido, edad) values(@id, @nombre, @apellido, @edad)";
                SqlCommand comandoInserte = new SqlCommand(queryInsertar, conectanding);
                comandoInserte.Parameters.AddWithValue("@id", id);
                comandoInserte.Parameters.AddWithValue("@nombre", nombre);
                comandoInserte.Parameters.AddWithValue("@apellido", apellido);
                comandoInserte.Parameters.AddWithValue("@edad", edad);
                comandoInserte.ExecuteNonQuery();
                conectanding.Close();
            }

        }

        public string PrinteaTabla()
        {
            string mensaje = "";
            using (SqlConnection conexiona=new SqlConnection(conexionString))
            {
                string querySelect = "select * from usuarios";
                SqlCommand ComandoRetorna = new SqlCommand(querySelect, conexiona);
                conexiona.Open();
                SqlDataReader lector;
                lector = ComandoRetorna.ExecuteReader();
                while (lector.Read())
                {
                    mensaje += lector[0];
                    mensaje += lector[1];
                    mensaje += lector[2];
                    mensaje += lector[3] +Environment.NewLine;
                }
                conexiona.Close();
            }
            return mensaje;
        }

        public void EliminaUsuario(int id)
        {
            using (SqlConnection conexiona = new SqlConnection(conexionString))
            {
                conexiona.Open();
                string queryElimina = "delete from Usuarios where Id=@id";
                SqlCommand comandoEliminador = new SqlCommand(queryElimina, conexiona);
                comandoEliminador.Parameters.AddWithValue("@id", id);
                comandoEliminador.ExecuteNonQuery();




                conexiona.Close();


            }



        }

    }
}
/* <connectionStrings>
    <add name="CadenaConexion" connectionString="Data Source=DESKTOP-MSJO6R8;Initial Catalog=BolsaDeDatos;Integrated Security=True"
        providerName="System.Data.SqlClient" />
  </connectionStrings>
*/