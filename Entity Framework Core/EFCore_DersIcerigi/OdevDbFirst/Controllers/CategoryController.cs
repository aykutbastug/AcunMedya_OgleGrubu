using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdevDbFirst.Models;

namespace OdevDbFirst.Controllers
{
    public class CategoryController : Controller
    {
        OdevDbFirstContext context = new OdevDbFirstContext();
        // GET: CategoryController
        public ActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();

            return View(categories);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View(new Category());
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category kategori)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Categories.Add(kategori);
                    context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(kategori);
                
            }
            catch
            {
                return View(kategori);
            }
        }
    }
}
