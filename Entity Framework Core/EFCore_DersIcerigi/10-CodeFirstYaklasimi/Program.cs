using _10_CodeFirstYaklasimi.Models;
using Microsoft.EntityFrameworkCore;

namespace _10_CodeFirstYaklasimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<CodeFirstOrnekContext>(option =>
            //option.UseSqlServer("server=AYKUTBASTUG-ZEN;database=CodeFirstOrnek;Trusted_Connection=true;TrustServerCertificate=true"));
            option.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString2")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}