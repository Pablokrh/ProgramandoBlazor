//using Newtonsoft.Json.Linq;

using Microsoft.EntityFrameworkCore;
using ApiNet6OpBoo.Models.DataModels;

namespace ApiNet6OpBoo.DataAccess
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> opciones) : base(opciones)
        {

        }

        public DbSet<User>? Users { get; set; }
    }      

}
