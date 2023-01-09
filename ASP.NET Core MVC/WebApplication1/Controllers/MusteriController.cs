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
                        ToplamAlacak = NumberData.GetNumber(1500, 999999),
                        ToplamBorc = NumberData.GetNumber(1500, 999999),
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


        public IActionResult MusteriDuzenle(int id)
        {
            Musteri musteri = Musteriler.FirstOrDefault(x => x.Id == id);

            return View(musteri);
        }

        [HttpPost]
        public IActionResult MusteriDuzenle(Musteri musteri)
        {
            Musteri _musteri = Musteriler.FirstOrDefault(x => x.Id == musteri.Id);
            _musteri.Adres = musteri.Adres;
            _musteri.Sehir = musteri.Sehir;
            _musteri.EFatura = musteri.EFatura;
            _musteri.AdiSoyadi = musteri.AdiSoyadi;
            _musteri.Unvan = musteri.Unvan;
            _musteri.ToplamAlacak = musteri.ToplamAlacak;
            _musteri.ToplamBorc = musteri.ToplamBorc;


            return RedirectToAction("MusteriListesi");
        }

        public IActionResult MusteriSil(int id) 
        {
            Musteri musteri = Musteriler.FirstOrDefault(x => x.Id == id);

            return View(musteri);
        }

        [HttpPost]
        public IActionResult MusteriSil(Musteri musteri)
        {
            Musteri _musteri = Musteriler.FirstOrDefault(x => x.Id == musteri.Id);

            Musteriler.Remove(_musteri);


            return RedirectToAction("MusteriListesi");
        }


    }
}
