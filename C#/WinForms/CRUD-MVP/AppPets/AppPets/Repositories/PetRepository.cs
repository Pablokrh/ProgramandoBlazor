using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AppPets.Model;

namespace AppPets.Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {

        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
            //Dice que esto podría hacerse en la clase base, pero recomienda hacerlo así, por razones
            //de mantener el código limpio además de por las pruebas unitarias

        }


        public void Add(PetModel petModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Pet values (@name, @type, @colour)";
                command.Parameters.AddWithValue("@name", petModel.Name);
                command.Parameters.AddWithValue("@type", petModel.Type);
                command.Parameters.AddWithValue("@colour", petModel.Colour);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Pet where Pet_Id=@id";
                command.Parameters.AddWithValue("@id", id);              
                command.ExecuteNonQuery();
            }
        }

        public void Edit(PetModel petModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Pet set Pet_Name=@name, Pet_Type=@type, Pet_Colour=@colour where Pet_Id=@id";
                command.Parameters.AddWithValue("@name", petModel.Name);
                command.Parameters.AddWithValue("@type", petModel.Type);
                command.Parameters.AddWithValue("@colour", petModel.Colour);
                command.Parameters.AddWithValue("@id", petModel.Id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PetModel> GetAll()
        {
            var petList = new List<PetModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command=new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Pet order by Pet_Id desc";
                //Se ordena con el Pet_Id descendentemente
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        petModel.Type = reader[2].ToString();
                        petModel.Colour = reader[3].ToString();
                        petList.Add(petModel);
                    }
                }
            }
                return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            var petList = new List<PetModel>();
            int petId = int.TryParse(value, out _)? Convert.ToInt32(value) : 0;
            //eso de arriba se divide en 2. Primero el tryParse y si eso es correcto se hace la conversión
            //Si no se puede se pasa el valor 0 por defecto.
            string petName = value;


            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Pet " +
                                      "where Pet_Id=@id or Pet_Name like @name+'%'" +                    
                                      "order by Pet_Id desc";
                //Hace la consulta con un or

                command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        petModel.Type = reader[2].ToString();
                        petModel.Colour = reader[3].ToString();
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }
    }
}
