using Microsoft.EntityFrameworkCore;
using University_API.Models;

namespace University_API.DataAccess
{
    public class UniversityContext:DbContext
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
