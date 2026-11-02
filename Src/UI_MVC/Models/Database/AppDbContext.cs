using Microsoft.EntityFrameworkCore;
using UI_MVC.Models.Entities;

namespace UI_MVC.Models.Database
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            //optionsBuilder.UseSqlServer(
            //    @"Server=.;Database=Maktab_PeopleDb;Integrated Security=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Maktab_PeopleDb; Integrated Security=True");
        }

        public DbSet<Person> People { get; set; }
    }
}
