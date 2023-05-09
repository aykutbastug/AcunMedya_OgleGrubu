using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _04_JwtAuthKullanimi
{
    public class TokenService
    {
        public const string SECRETKEY = "E0D130868A89425EAD6A7D49AECE8155";
        public const string ISSUER = "api.com";
        public const string AUDIENCE = "api.com";


        public static string GenereteToken(string username)
        {
            byte[] key = Encoding.UTF8.GetBytes(SECRETKEY);
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, "11"),
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "admin")
            };

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(ISSUER, AUDIENCE, claims, null, DateTime.Now.AddDays(3), credentials);

            string token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            return token;
        }
    }
}
