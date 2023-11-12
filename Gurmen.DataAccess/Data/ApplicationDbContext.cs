using Gurmen.Model;
using Microsoft.EntityFrameworkCore;

namespace Gurmen.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { ID=1, Name="Ahmet", Surname="Salim", Gender=Gender.Man, Age=20},
                new Person { ID=2, Name="Fatih", Surname="Salim", Gender=Gender.Man, Age=24},
                new Person { ID=3, Name="Ali", Surname="Yıldırım", Gender=Gender.Man, Age=1000},
                new Person { ID=4, Name="İrem", Surname ="Selin", Gender=Gender.Woman, Age=25},
                new Person { ID=5, Name="Veli", Surname ="Tunç", Gender=Gender.Man, Age=32}
            );
        }
    }
}
