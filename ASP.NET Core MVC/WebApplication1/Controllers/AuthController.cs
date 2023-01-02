using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = 1;
            ogrenci.Adi = "Aykut";
            ogrenci.Soyadi = "BAŞTUĞ";


            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Id = 2;
            ogrenci2.Adi = "Aykut2";
            ogrenci2.Soyadi = "BAŞTUĞ2";

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(ogrenci);
            ogrenciler.Add(ogrenci2);

            return View(ogrenciler);
        }

        public IActionResult  Login()
        {
            return View();
        }

    }
}
