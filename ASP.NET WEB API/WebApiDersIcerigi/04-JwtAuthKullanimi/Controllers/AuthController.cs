using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _04_JwtAuthKullanimi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody]LoginModel model)
        {
            if (model.Username == "deneme" && model.Password == "123")
            {
                return Ok(TokenService.GenereteToken(model.Username));
            }

            return BadRequest("Kullanıcı adı ve şifresi hatalı");
        }
    }


    public class LoginModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
