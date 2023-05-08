using Microsoft.EntityFrameworkCore;

namespace _01_EFCore.Entities
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (optionsBuilder.IsConfigured == false)
        //    {
        //        optionsBuilder.UseSqlServer("server=AYKUTBASTUG-ZEN;database=TodoAppDers; Trusted_Connection=true;TrustServerCertificate=true;");
        //    }
        //}
    }
}
