using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TPN5_KrojzlPablo
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

        public void InsertarUsuario(Usuario usuario)
        {

            using (SqlConnection conectanding = new SqlConnection(conexionString))
            {
                conectanding.Open();
                string queryInsertar = "insert into Usuarios(Id, Nombre, Apellido, edad) values(@id, @nombre, @apellido, @edad)";
                SqlCommand comandoInserte = new SqlCommand(queryInsertar, conectanding);
                comandoInserte.Parameters.AddWithValue("@id", usuario.Id);
                comandoInserte.Parameters.AddWithValue("@nombre", usuario.Nombre);
                comandoInserte.Parameters.AddWithValue("@apellido", usuario.Apellido);
                comandoInserte.Parameters.AddWithValue("@edad", usuario.Edad);
                comandoInserte.ExecuteNonQuery();
                conectanding.Close();
            }

        }
        
        public List<Usuario> ConsultaRegistros()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (SqlConnection conectando = new SqlConnection(conexionString))
            {
                string querySelect = "select * from usuarios";
                conectando.Open();
                SqlCommand comandoConsulta = new SqlCommand(querySelect, conectando);

                SqlDataReader reader= comandoConsulta.ExecuteReader();
                SqlDataAdapter MiAdaptadorSql = new SqlDataAdapter(querySelect, conectando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listaUsuarios.Add(new Usuario
                        {
                            Nombre = Convert.ToString(reader["Nombre"]),
                            Apellido = Convert.ToString(reader["Apellido"]),
                            Edad = Convert.ToInt32(reader["Edad"]),
                            Id = Convert.ToInt32(reader["Id"])
                        });
                    }
                }             
                conectando.Close();
            }
            return listaUsuarios;     
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

