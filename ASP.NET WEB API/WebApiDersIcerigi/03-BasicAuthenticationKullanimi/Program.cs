
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;

namespace _03_BasicAuthenticationKullanimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(opt =>
            {
                opt.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Description = "Burada basic authenticaition bilgilerini giriniz",
                    Name = "Authorization",
                    Scheme = "basic",
                    Type = SecuritySchemeType.Http
                });

                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference{ Type = ReferenceType.SecurityScheme, Id="basic" }
                        },
                        new List<string>()
                    }
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication(); //kimlik doğrulaması
            app.UseAuthorization(); //rollerin kontrolünü sağlıyor


            app.MapControllers();

            app.Run();
        }
    }
}