using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace _03_BasicAuthenticationKullanimi
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {

        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var endpoint = Context.GetEndpoint();

            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
            {
                return AuthenticateResult.NoResult();
            }

            if (Request.Headers.ContainsKey("Authorization") == false)
            {
                return AuthenticateResult.Fail("Kimlik bilgilerini içeren Authorization parametresi header'da bulunamadı");
            }


            var authHedaer = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var cridentialBytes = Convert.FromBase64String(authHedaer.Parameter);
            var cridential = Encoding.UTF8.GetString(cridentialBytes).Split(':', 2);

            var username = cridential[0];
            var password = cridential[1];

            bool result = (username == "deneme" && password == "123") ? true : false;

            if (result)
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, "11"),
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, "admin")
                };

                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
            else
            {
                return AuthenticateResult.Fail("Kullanıcı adı veya şifresi hatalı.");
            }

        }
    }
}
