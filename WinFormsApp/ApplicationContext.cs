using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;

namespace WinFormsApp
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=WinFormsDatabase;" +
                "Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
