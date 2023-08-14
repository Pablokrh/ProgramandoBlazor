using Microsoft.EntityFrameworkCore;
using University_API.DataAccess;


namespace University_API.Services
{
    public class LinqQueries
    {
        private readonly UniversityContext _context;

        public LinqQueries(UniversityContext context)
        {
            _context = context;
        }

        public void SearchUsersByEmail(string email)
        {
            var userMail = from user in _context.Users where user.Email == email
                           select user;
            Console.WriteLine("Usuario: "+ userMail);

        }

        


    }
}
