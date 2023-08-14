using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using Common;
using Common.Cache;

namespace Dominio
    //Toman como sinónimos Dominio y negocio
{


    public class DominioUser
    {
         UserDao userDao = new UserDao();


        //Si fueras anémico esto lo podrías en la capa de entidades
        private int idUser;
        private string loginName;
        private string password;
        private string firstName;
        private string lastName;
        private string position;
        private string email;

        public DominioUser(int idUser, string loginName, string password, string firstName, string lastName, string position, string email )
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.email = email;
        }

        public DominioUser() { }

        public string EditUserProfile()
        {
            try
            {
                userDao.EditProfile(idUser, loginName, password, firstName, lastName, email);
                 Login(loginName, password);
                return "Your profile has been successfully updated";
                //Recuerda que en la BBDD el campo LoginName es unique, es decir, no pueden haber 2 usuario con igual LoginName
            }
            catch (Exception ex) { return "Username is already registed"+ ex.Message; }
           

        }



        public bool Login (string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public void AnyMethod()
        {
            if (ActiveUser.IdUser >= 1)
            {
               if (userDao.ExistUser(ActiveUser.IdUser) == true)
                {
                    //Código
                }
            }
            if (ActiveUser.IdUser.ToString()==null || ActiveUser.IdUser <= 0)
            {
                //Send msg to administrator.
            }
        }

        public string RecoverPassword (string requestingUser)
        {

            return userDao.RequestUserPassword(requestingUser);
        }
       
    }
}
