
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace _04_JwtAuthKullanimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //string secretkey = "E0D130868A89425EAD6A7D49AECE8155";
            string secretkey = TokenService.SECRETKEY;

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opts => 
                {
                    opts.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true, //tokenı oluşturanı da kontrol et
                        ValidateAudience = true, //tokenı üreten kişiye validate et
                        ValidateLifetime = true, //sürekli hayat boyu validate et
                        ValidateIssuerSigningKey = true, //VERIFY SIGNATURE alanınıda kullan demiş oluruz
                        ValidIssuer = TokenService.ISSUER, //
                        ValidAudience = TokenService.AUDIENCE, //
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretkey))
                    };                
                });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(opts => 
            {
                opts.SwaggerDoc("v1", new OpenApiInfo { Title = "WepAPI Örnek", Version = "v1" });

                opts.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
                {
                    Description = "Burada bearer authenticaition bilgilerini giriniz",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Type = SecuritySchemeType.Http
                });

                opts.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference{ Type = ReferenceType.SecurityScheme, Id="bearer" }
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
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}