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
    public class ModeloTablas
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConexionSql"].ConnectionString;


        public EmpleadoResponse AgregarALista()
        {
            EmpleadoResponse response = new EmpleadoResponse();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlStoredProcedure = "MostrarTodo";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        response.listEmpleado.Add(new Empleado(reader["Id"].ToString(),
                        reader["NombreCompleto"].ToString(),
                        reader["DNI"].ToString(),
                        reader["Edad"].ToString(),
                        reader["Casado"].ToString(),
                        reader["Salario"].ToString()));
                    }
                    connection.Close();
                    return response;
                }
            }
            catch (Exception error)
            {
                response.error = error;
                return response;
            }

        }
       
        public EmpleadoResponse RecuperaFila(int auxId)
        {
            Empleado emp=null;
            EmpleadoResponse response=null;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlStoredProcedure = "RecuperaFila";
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Id", SqlDbType.Int);
                    command.Parameters["@Id"].Value = auxId;

                    SqlDataReader reader;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        emp = new Empleado(reader["Id"].ToString(),
                        reader["NombreCompleto"].ToString(),
                        reader["DNI"].ToString(),
                        reader["Edad"].ToString(),
                        reader["Casado"].ToString(),
                        reader["Salario"].ToString());
                    }
                    connection.Close();
                    response = new EmpleadoResponse(emp);

                    return response;
                }
            }
            catch(Exception error)
            {
                response.error = error;
                return response;
            }
        }
       
        public EmpleadoResponse AgregarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario)
        {
            EmpleadoResponse response = new EmpleadoResponse();
            string sqlStoredProcedure = "AgregaEmpleado";

            try
            {
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
                response= AgregarALista();
                return response;
            }
            catch (Exception error)
            {
                response.error = error;
                return response;
            }
        }

        public EmpleadoResponse ModificarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario, int id)
        {         
            EmpleadoResponse response = new EmpleadoResponse();
            string sqlStoredProcedure = "ModificaEmpleado";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Salario", salario);
                    command.Parameters.AddWithValue("@Casado", casado);
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                response = AgregarALista();               
                return response;
            }

            catch (Exception error)
            {
                response.error = error;
                return response;
            }
          
        }

        public EmpleadoResponse FiltrarPorNombre(string buscaPorNombre)
        {
            EmpleadoResponse response = new EmpleadoResponse();
            try
            {
                response = AgregarALista();

                List<Empleado> listaAux = new List<Empleado>();

                string auxBusca = char.ToUpper(buscaPorNombre[0]) + buscaPorNombre.Substring(1);

                foreach (var item in response.listEmpleado)
                {
                    if (item.NombreCompleto == buscaPorNombre || item.NombreCompleto == auxBusca)
                    {
                        listaAux.Add(item);
                    }
                    else
                    {
                        if (item.NombreCompleto.Contains(buscaPorNombre) || item.NombreCompleto.Contains(auxBusca))
                        {
                            listaAux.Add(item);
                        }
                    }
                }

                response.listEmpleado = listaAux;
                return response;
            }
            catch(Exception error)
            {
                response.error = error;
                return response;
            }
        }

        public EmpleadoResponse DNIExistente(string dni)
        {
            EmpleadoResponse response = new EmpleadoResponse();

            bool existe = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlStoredProcedure = "ValidaExistente";
                    SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if ((int)reader[0] > 0)
                        {
                            existe = true;
                        }
                    }
                    connection.Close();
                    response.dniValido = existe;
                    return response;
                }
            }
            catch (Exception error)
            {
                response.error = error;
                return response;
            }
        
        }

        public EmpleadoResponse EliminarEmpleado(int auxId)
        {
            EmpleadoResponse response = new EmpleadoResponse();
            string sqlStoredProcedure = "EliminaEmpleado";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                    command.Parameters.Add("@Id", SqlDbType.Int);
                    command.Parameters["@Id"].Value = auxId;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                response = AgregarALista();
                return response;
            }
            catch (Exception error)
            { 
                response.error = error;
                return response;
            }

           
        }
    }
}

