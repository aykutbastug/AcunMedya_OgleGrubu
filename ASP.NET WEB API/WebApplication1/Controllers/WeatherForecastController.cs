using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet("SayilariTopla/{sayi1}/{sayi2}")]
        public int SayilariTopla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }


        [HttpPost("SayilariToplaPost")]
        public int SayilariToplaPost(Sayi sayi)
        {
            return sayi.Sayi1 + sayi.Sayi2;
        }


        [HttpPut("SayilariToplaPut")]
        public int SayilariToplaPut(Sayi sayi)
        {
            return sayi.Sayi1 + sayi.Sayi2;
        }
    }
}