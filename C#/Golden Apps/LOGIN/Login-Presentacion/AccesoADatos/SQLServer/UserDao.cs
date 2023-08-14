using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common;
using Common.Cache;
using AccesoADatos.CorreoElectronico;


namespace AccesoADatos
{
   public class UserDao:AccesoSQL
    {

        public void EditProfile(int id, string userName, string password, string name, string lastName, string mail)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using( var command=new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Users set LoginName=@userName, Password=@pass, FirstName=@name, " +
                        "Lastname= @lastName, Email=@mail where UserId=@id";
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }



        public bool Login (string user, string pass)
        {

            using (var sqlconexion = GetSqlConnection())
            {
                //Antes arriba figuraba esto de abajo y no paraba de tirar error:
                //using (SqlConnection sqlconexion = GetSqlConnection())
                //Había hecho mal la clase AccesoSQL. El new se ejecuta cada vez que se ejecuta el método.
                using (SqlCommand comando = new SqlCommand("select * from Users where LoginName=@user and Password=@pass", sqlconexion))
                {
                    sqlconexion.Open();

                    comando.Parameters.AddWithValue("@user", user);
                    comando.Parameters.AddWithValue("@pass", pass);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader sqlDataReader = comando.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            ActiveUser.IdUser = sqlDataReader.GetInt32(0);
                            //Ese número al final hace referencia al número de columna de la tabla
                            ActiveUser.FirstName = sqlDataReader.GetString(3);
                            ActiveUser.LastName = sqlDataReader.GetString(4);
                            ActiveUser.Position = sqlDataReader.GetString(5);
                            ActiveUser.Email = sqlDataReader.GetString(6);
                            ActiveUser.LoginName = sqlDataReader.GetString(1);
                            ActiveUser.Password = sqlDataReader.GetString(2);
                        }
                        return true;

                    }
                    else return false;

                }

            }

        }

        public bool ExistUser (int id)
        {
            using (SqlConnection sqlconexion = GetSqlConnection())
            {
                sqlconexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = GetSqlConnection();
                comando.CommandText = "select * from Users where idUser=@user";
                comando.Parameters.AddWithValue("@user", id);
                comando.CommandType = CommandType.Text;
                SqlDataReader sqlDataReader = comando.ExecuteReader();
                comando.Parameters.Clear();
                if (sqlDataReader.Read())
                {                    
                    return true;
                    //Si la consulta existe, es decir, ingresó un Id verdadero. Retorna true.
                }
                else return false;
            }

        }
        public string RequestUserPassword (string requestingUser)
        {
            List<string> ListAux = new List<string>();
            ListAux.Add("pablokrh@hotmail.com");
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = GetSqlConnection();
                command.CommandText="select * from Users where LoginName=@user or Email=@email";
                command.Parameters.AddWithValue("@user", requestingUser);
                command.Parameters.AddWithValue("@email", requestingUser);
                command.CommandType = CommandType.Text;
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.Read() == true)
                //Se insiste. Eso significa que si se sigue leyendo se hará lo de abajo.
                {
                    string userName = sqlDataReader.GetString(3) + sqlDataReader.GetString(4);
                    string Email = sqlDataReader.GetString(6);
                    string userPassword = sqlDataReader.GetString(2);
                    SystemSupportMail systemSupportMail = new SystemSupportMail();
                    systemSupportMail.SendMail(subject: "SYSTEM: Password recovery request",
                        body: "Hi " + userName + Environment.NewLine + "You requested to recover your password." +
                        "Your current password is: " + userPassword + Environment.NewLine +
                        "However, we ask that you change your password inmediately once you enter the system.", receiverMail: ListAux);
                    return "Hi " + userName + Environment.NewLine + "You requested to recover your password." +
                       Environment.NewLine + "Please check your email " + Email + Environment.NewLine +
                        "However, we ask that you change your password inmediately once you enter the system.";
                }
                else return "Sorry, you don´t have an account whit that email or username";



            }

        }

    }
}
