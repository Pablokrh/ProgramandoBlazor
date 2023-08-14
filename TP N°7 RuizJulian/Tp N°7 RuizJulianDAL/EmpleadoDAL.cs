using MayoristaEntities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_N_7_RuizJulianDAL
{
    public class EmpleadoDAL
    {
        public static List<Empleado> ListarEmpleados(string NombreApellido)
        {

            List<Empleado> list = new List<Empleado>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ListarEmpleados";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreApellido", SqlDbType.VarChar).Value = NombreApellido;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ObtenerEmpleado(reader));
                }
            }

            return list;


        }

        public static Empleado ObtenerEmpleado(int id)
        {

           Empleado empleado = new Empleado();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ObtenerEmpleado";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    empleado = ObtenerEmpleado(reader);
                }
            }

            return empleado;


        }


        public static Empleado ObtenerEmpleado(SqlDataReader reader)
        {
            Empleado cliente = new Empleado();

            cliente.Id = Convert.ToInt32(reader["Id"]);
            cliente.NombreApellido = Convert.ToString(reader["NombreApellido"]);
            cliente.Cuil = Convert.ToString(reader["Cuil"]);
            cliente.Domicilio = Convert.ToString(reader["Domicilio"]);
            cliente.Telefono = Convert.ToString(reader["Telefono"]);
            cliente.Mail = Convert.ToString(reader["Mail"]);
            cliente.Localidad = Convert.ToString(reader["Localidad"]);
            cliente.Pais = Convert.ToString(reader["Pais"]);
            cliente.Provincia = Convert.ToString(reader["Provincia"]);
            cliente.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
            cliente.Nacionalidad = Convert.ToString(reader["Nacionalidad"]);

            return cliente;
        }
        public static Empleado ABMEmpleado(Empleado empleado)
        {
            Empleado Empleado = empleado;

            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
                {
                    conn.Open();
                    string sql = string.Empty;

                    if ((empleado).Id > 0)
                    {
                        sql = @"MODIFICAREMPLEADOS";
                    }
                    else
                        sql = @"EMPLEADOS";


                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    if (empleado.Id > 0)
                    {
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = empleado.Id;
                    }

                    cmd.Parameters.Add("@NombreApellido", SqlDbType.VarChar).Value = empleado.NombreApellido;
                    cmd.Parameters.Add("@Cuil", SqlDbType.VarChar).Value = empleado.Cuil;
                    cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = empleado.Domicilio;
                    cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = empleado.Telefono;
                    cmd.Parameters.Add("@Mail", SqlDbType.VarChar).Value = empleado.Mail;
                    cmd.Parameters.Add("@Nacionalidad", SqlDbType.VarChar).Value = empleado.Nacionalidad;
                    cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = empleado.FechaNacimiento;
                    cmd.Parameters.Add("@Localidad", SqlDbType.VarChar).Value = empleado.Localidad;
                    cmd.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = empleado.Provincia;
                    cmd.Parameters.Add("@Pais", SqlDbType.VarChar).Value = empleado.Pais;

                    cmd.ExecuteNonQuery();


                    return empleado;
                }



            }
            catch (Exception Ex)
            {
                return empleado;

            }

        }
        public static void DeleteEmpleado(int id)
        {

            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
                {
                    conn.Open();
                    string sql = @"ELIMINAREMPLEADOS";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }



            }
            catch (Exception Ex)
            {

            }
        }
    }
}
