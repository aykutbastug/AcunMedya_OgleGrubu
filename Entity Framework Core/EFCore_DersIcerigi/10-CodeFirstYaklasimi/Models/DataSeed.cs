using Microsoft.EntityFrameworkCore;

namespace _10_CodeFirstYaklasimi.Models
{
    public static class DataSeed
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<CodeFirstOrnekContext>();
            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                for (int i = 0; i < 30; i++)
                {
                    context.Categories.Add(new Category()
                    {
                        Description = $"Kategori {i + 1} açıklama",
                        Name = "Kategori " + (i + 1)
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
