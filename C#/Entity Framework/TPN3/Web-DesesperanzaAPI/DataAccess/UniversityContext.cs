using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Web_DesesperanzaAPI.Models;

namespace Web_DesesperanzaAPI.DataAccess
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> opciones) : base(opciones)
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Course>? Courses { get; set; }

    }


        

}
