using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AuthController : Controller
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public IActionResult Index()
        {
            if (ogrenciler.Count == 0)
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Id = 1;
                ogrenci.Adi = NameData.GetFirstName();
                ogrenci.Soyadi = NameData.GetSurname();


                Ogrenci ogrenci2 = new Ogrenci();
                ogrenci2.Id = 2;
                ogrenci2.Adi = NameData.GetFirstName();
                ogrenci2.Soyadi = NameData.GetSurname();

                //NumberData.GetNumber(100, 1000);


                ogrenciler.Add(ogrenci);
                ogrenciler.Add(ogrenci2); 
            }

            return View(ogrenciler);
        }

        public IActionResult  Login()
        {
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Id = 1;
            //ogrenci.Adi = "Aykut";
            //ogrenci.Soyadi = "BAŞTUĞ";

            return View(new Ogrenci() { Id = ogrenciler.Count + 1 });
        }



        [HttpPost]
        public IActionResult Login(Ogrenci ogrenci)
        {
            //sql'e kaydetme işlemi yapılabilir

            ogrenciler.Add(ogrenci);
            //return View(ogrenci);
            return RedirectToAction("Index");   
        }

    }
}
