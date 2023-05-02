using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using CrmUygulamasi.UI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CrmUygulamasi.UI.Controllers
{
    public class AuthController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeRepository());

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = employeeManager.ListAll().FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);

                if (user != null && user.State)
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.NameSurname),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role)
                    };

                    //claims.Add(new Claim("id",user.Id.ToString()));

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    if (user == null)
                    {
                        ModelState.AddModelError("", "Kullanıcı bilgileri hatalı");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı aktif değil");
                    }
                }
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Auth");
        }
    }
}
