using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiNcapas.Entities;

namespace TiNCapas.DAL
{
    internal class UserRepository : IUserRepository,IDisposable
    {
        readonly UserManagerDbContext context;

        public UserRepository()
        {
            context = new UserManagerDbContext();
        }

        public User CreateUser(User user)
        {
            context.Add(user);
            context.SaveChanges();
            return user;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
