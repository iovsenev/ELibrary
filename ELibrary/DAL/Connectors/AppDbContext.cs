using ELibrary.DLL.Models;
using Microsoft.EntityFrameworkCore;

namespace ELibrary.DAL.Connectors
{
    public class AppDbContext: DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data source=Ilya\SQLEXPRESS;Database=ELibrary;Trusted_Connection=true;TrustServerCertificate=True;");
        }

    }
}
