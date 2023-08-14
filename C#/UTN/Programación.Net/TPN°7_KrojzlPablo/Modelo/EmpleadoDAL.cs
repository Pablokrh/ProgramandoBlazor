using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Configuration;



namespace Modelo
{
    public class EmpleadoDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConexionSql"].ConnectionString;
        List<EmpleadoEntidades> listEmpleados = new List<EmpleadoEntidades>();

        public List <EmpleadoEntidades> AgregarALista()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStoredProcedure = "MostrarTodo";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader lectore;
                lectore = command.ExecuteReader();
                
                    while (lectore.Read())
                    {
                        listEmpleados.Add(new EmpleadoEntidades(lectore["Id"].ToString(),
                        lectore["NombreCompleto"].ToString(),
                        lectore["DNI"].ToString(),
                        lectore["Edad"].ToString(),
                        lectore["Casado"].ToString(), 
                        lectore["Salario"].ToString()));
                    }                             
                connection.Close();
                return listEmpleados;
            }
        }
       
       
        public List<EmpleadoEntidades> AgregarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario)
        {
            string sqlStoredProcedure = "AgregaEmpleado";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;               
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Edad", edad);
                command.Parameters.AddWithValue("@Salario", salario);
                command.Parameters.AddWithValue("@Casado", casado);
                command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                command.ExecuteNonQuery(); 
                connection.Close();                
            }
            AgregarALista();
            return listEmpleados;
        }


        public bool DNIExistente(string dni)
        {
            bool existe = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlStoredProcedure = "ValidaExistente";
                SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                command.Parameters.AddWithValue("@DNI", dni);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader lectore;
                lectore = command.ExecuteReader();

                while (lectore.Read())
                {
                    if ((int)lectore[0] >0)
                    {                        
                        existe = true;   
                    }
                }                   
                    connection.Close();
            }
            return existe;
        }

    }
}

