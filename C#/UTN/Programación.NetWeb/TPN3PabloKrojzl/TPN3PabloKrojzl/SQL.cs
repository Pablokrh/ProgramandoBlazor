using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TPN3PabloKrojzl
{
    public class SQL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public void AgregarProducto(string cli, string Producto, int idCompra)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string agregaProducto = " insert into productos(cliente, idCompra, producto) values(@cliente, @idCompra, @producto)";
                SqlCommand command = new SqlCommand(agregaProducto, connection);
                command.Parameters.AddWithValue("@idCompra", idCompra);
                command.Parameters.AddWithValue("@cliente", cli);
                command.Parameters.AddWithValue("@producto", Producto);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int GeneraIDCompra()
        {
            int idCompra = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string IdCompraQuery = "select max(idCompra) from productos";
                SqlCommand IdQuery = new SqlCommand(IdCompraQuery, connection);

                SqlDataReader reader;
                reader=IdQuery.ExecuteReader();

                while (reader.Read())
                {
                    if ((int)reader[0] == 0)
                    {
                        idCompra = 1;
                    }
                    else
                    {
                        idCompra = (int)reader[0] + 1;
                    }
                }
                connection.Close();

                return idCompra;
            }
        }
    }
}