using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class SQL
    {
        string conexionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
        /*
        public void CrearBase()
        {
            using (SqlConnection conectando = new SqlConnection(conexionString))
            {
                conectando.Open();
                string queryCreaBBDD = "CREATE TABLE [dbo].[Usuarios] (" +
                                    "[Id] INT NOT NULL," +
                                    "[Nombre] NCHAR(40) NULL," +
                                    "[Apellido] NCHAR(40) NULL," +
                                    "[Edad] INT NULL," +
                                    "PRIMARY KEY CLUSTERED([Id] ASC))";
                SqlCommand comando = new SqlCommand(queryCreaBBDD, conectando);
                comando.ExecuteNonQuery();
                conectando.Close();
            }
        }
        */
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
        
        public DataTable ConsultaRegistros()
        {
           
            DataTable clientesTabla = new DataTable();

            using (SqlConnection conectando = new SqlConnection(conexionString))
            {
                string querySelect = "select * from usuarios";
                conectando.Open();

                SqlDataAdapter MiAdaptadorSql = new SqlDataAdapter(querySelect, conectando);

                using (MiAdaptadorSql)
                {
                                 
                    MiAdaptadorSql.Fill(clientesTabla);                  
                }               
                conectando.Close();
            }
            return clientesTabla;


            /*
             * 
            using (SqlConnection conectando = new SqlConnection(conexionString))
            {
                string querySelect = "select * from usuarios";
                SqlCommand ComandoRetorna = new SqlCommand(querySelect, conectando);
                conectando.Open();
                SqlDataReader lector;
                lector = ComandoRetorna.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        mensaje += " "+ lector[0]+ "    ";
                        mensaje += lector[1];
                        mensaje += lector[2];
                        mensaje += lector[3] + Environment.NewLine;
                    }
                }
               
                conectando.Close();
            }
            return mensaje;           
             * 
             * */

        }

        public void EliminarUsuarios()
        {
            using (SqlConnection conectando = new SqlConnection(conexionString))
            {
                conectando.Open();
                string queryElimina = "delete from Usuarios";
                SqlCommand comandoEliminador = new SqlCommand(queryElimina, conectando);
               // comandoEliminador.Parameters.AddWithValue("@id", id);
                comandoEliminador.ExecuteNonQuery();
                conectando.Close();


            }



        }
    }
}

