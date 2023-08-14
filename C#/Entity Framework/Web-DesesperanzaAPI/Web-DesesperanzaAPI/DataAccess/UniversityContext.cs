using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Web_DesesperanzaAPI.Models;

namespace Web_DesesperanzaAPI.DataAccess
{
    public class UniversityContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;

        public UniversityContext(DbContextOptions<UniversityContext> opciones, ILoggerFactory loggerFactory) : base(opciones)
        {
            _loggerFactory = loggerFactory;
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Course>? Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var logger = _loggerFactory.CreateLogger<UniversityContext>();
            //optionsBuilder.LogTo(d => logger.Log(LogLevel.Information, d, new[] { DbLoggerCategory.Database.Name }));
            //optionsBuilder.EnableSensitiveDataLogging();
            //Con esas 2 lineas ya funciona, pero no hace logs personalizados
            optionsBuilder.LogTo(d => logger.Log(LogLevel.Information, d, new[] { DbLoggerCategory.Database.Name }), LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

    }


        

}
