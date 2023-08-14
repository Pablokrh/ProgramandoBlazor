using Microsoft.EntityFrameworkCore;
using TiNcapas.Entities;

namespace TiNCapas.DAL
{
    public class UserManagerDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);DataBase=UsersNCapas;Trusted_Connection=True; TrustServerCertificate=True;");
        }
        public DbSet<User>Users { get; set; }

    }
}