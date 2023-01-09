using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PersonelController : Controller
    {
        static List<Personel> Personeller = new List<Personel>();
        // GET: PersonelController
        public ActionResult Index()
        {
            if (Personeller.Count == 0)
            {
                for (int i = 1; i < 6; i++)
                {
                    Personel personel = new Personel() { 
                        AdiSoyadi = NameData.GetFullName(),
                        Departman = NameData.GetDepartmentName(),
                        Id = i
                    };

                    Personeller.Add(personel);
                }
            }

            return View(Personeller);
        }

        // GET: PersonelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
