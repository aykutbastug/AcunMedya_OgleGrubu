using Microsoft.AspNetCore.Mvc;
using OdevDbFirst.Models;

namespace OdevDbFirst.Controllers
{
    public class SupplierController : Controller
    {
        OdevDbFirstContext context = new OdevDbFirstContext();
        public IActionResult Index()
        {
            var liste = context.Suppliers.ToList();

            return View(liste);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Supplier model)
        {
            if (ModelState.IsValid)
            {
                context.Suppliers.Add(model);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View(model);

        }
    }
}
