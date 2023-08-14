using TiNcapas.Entities;

namespace TiNCapas.Bussiness
{
    public class UserService
    {
        readonly IUserRepository repositorio;
        //Acá se ve que no hay inyección de dependencias:
        //No llega nada por parámetro y debe crearse el contexto aquí.
        public UserService(IUserRepository repository)
        {
             repositorio = repository;
        }


        public void CreateUser(User user)
        {           
            repositorio.CreateUser(user);  
        }
    }
}