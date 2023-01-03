using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MusteriController : Controller
    {
        static List<Musteri> Musteriler = new List<Musteri>();
        public IActionResult MusteriListesi()
        {
            if (Musteriler.Count == 0)
            {
                for (int i = 1; i < 11; i++)
                {
                    Musteriler.Add(new Musteri()
                    {
                        AdiSoyadi = NameData.GetFullName(),
                        Adres = PlaceData.GetAddress(),
                        EFatura = i % 2 == 0 ? true : false,
                        Id = i,
                        KayitTarihi = DateTimeData.GetDatetime(),
                        Sehir = "İstanbul",
                        ToplamAlacak = NumberData.GetDouble(),
                        ToplamBorc = NumberData.GetDouble(),
                        Unvan = NameData.GetCompanyName()
                    });
                }
            }

            return View(Musteriler);
        }

        public IActionResult MusteriEkle()
        {
            ViewData["Tarih"] = DateTime.Today.ToShortDateString();
            ViewBag.Saat = DateTime.Now.ToShortTimeString();
            return View();
        }

        [HttpPost]
        public IActionResult MusteriEkle(Musteri musteri)
        {
            musteri.Id = Musteriler.Count + 1;
            Musteriler.Add(musteri);
            return RedirectToAction("MusteriListesi");
        }
    }
}
