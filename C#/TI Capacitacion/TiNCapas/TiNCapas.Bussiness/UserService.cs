using TiNcapas.Entities;
using TiNCapas.DAL;

namespace TiNCapas.Bussiness
{
    public class UserService:IDisposable
    {
        UserManagerDbContext context;
        //Acá se ve que no hay inyección de dependencias:
        //No llega nada por parámetro y debe crearse el contexto aquí.
        public UserService()
        {
             context = new UserManagerDbContext();
        }


        public void CreateUser(User user)
        {           
            context.Users.Add(user);
            context.SaveChanges();
        
        
        }
        public void Dispose()
        {
            context.Dispose();
        }

    }
}