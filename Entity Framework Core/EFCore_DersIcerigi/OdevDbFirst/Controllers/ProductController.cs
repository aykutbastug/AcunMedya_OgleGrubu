using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OdevDbFirst.Models;

namespace OdevDbFirst.Controllers
{
    public class ProductController : Controller
    {
        OdevDbFirstContext context = new OdevDbFirstContext();
        public IActionResult Index()
        {
            var liste = context.Products
                                .Include(x => x.Category)
                                .Include(x => x.Supplier)
                                .ToList();

            return View(liste);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();
            ViewBag.Suppliers = context.Suppliers.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(model);
                context.SaveChanges(); 

                return RedirectToAction("Index");   
            }


            ViewBag.Categories = context.Categories.ToList();
            ViewBag.Suppliers = context.Suppliers.ToList();
            return View(model);
        }
    }
}
