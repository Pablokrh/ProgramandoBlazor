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
        List<Empleado> listEmpleados = new List<Empleado>();

        public List <Empleado> AgregarALista()
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
                        listEmpleados.Add(new Empleado(lectore["Id"].ToString(),
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
       
        public Empleado RecuperaFila(int auxId)
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStoredProcedure = "RecuperaFila";
                connection.Open();

                SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters["@Id"].Value = auxId;

                SqlDataReader lectore;
                lectore = command.ExecuteReader();
                
                    while (lectore.Read())
                    {
                      return new Empleado (lectore["Id"].ToString(),
                        lectore["NombreCompleto"].ToString(),
                        lectore["DNI"].ToString(),
                        lectore["Edad"].ToString(),
                        lectore["Casado"].ToString(),
                        lectore["Salario"].ToString());
                    }                
                    connection.Close();
                return null;
            }
        }
       
        public List<Empleado> AgregarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario)
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

        public List<Empleado> ModificarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario, int id)
        {            
            string sqlStoredProcedure = "ModificaEmpleado";
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

            AgregarALista();
            return listEmpleados;
        }

        public List <Empleado> FiltrarPorNombre(string buscaPorNombre)
        {
            List<Empleado> listafiltrada = new List<Empleado>();

            string auxBusca = char.ToUpper(buscaPorNombre[0]) + buscaPorNombre.Substring(1);

            foreach (var item in listEmpleados)
            {
                if (item.NombreCompleto == buscaPorNombre|| item.NombreCompleto ==auxBusca)
                {
                    listafiltrada.Add(item);
                }
                else
                {
                    if (item.NombreCompleto.Contains(buscaPorNombre)|| item.NombreCompleto.Contains(auxBusca))
                    {
                        listafiltrada.Add(item);
                    }
                }                
            }


                return listafiltrada;    
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

        public void EliminarEmpleado(int auxId)
        {         
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStoredProcedure = "EliminaEmpleado";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters["@Id"].Value = auxId;
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                connection.Close();
            }

            for (int i = 0; i < listEmpleados.Count; i++)
            {
                if (listEmpleados[i].Id == auxId) listEmpleados.Remove(listEmpleados[i]);
            }
        }
    }
}

