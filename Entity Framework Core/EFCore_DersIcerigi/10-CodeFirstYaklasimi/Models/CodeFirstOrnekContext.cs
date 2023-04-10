using Microsoft.EntityFrameworkCore;

namespace _10_CodeFirstYaklasimi.Models
{
    public class CodeFirstOrnekContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=AYKUTBASTUG-ZEN;database=CodeFirstOrnek;Trusted_Connection=true;TrustServerCertificate=true");
            }
        }

    }
}
