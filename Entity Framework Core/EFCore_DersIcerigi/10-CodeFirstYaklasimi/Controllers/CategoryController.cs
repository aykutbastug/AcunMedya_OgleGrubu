using _10_CodeFirstYaklasimi.Models;
using Microsoft.AspNetCore.Mvc;

namespace _10_CodeFirstYaklasimi.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CodeFirstOrnekContext context;
        public CategoryController(CodeFirstOrnekContext context)
        {
            this.context = context;
        }

        //CodeFirstOrnekContext context = new CodeFirstOrnekContext(); 
        public IActionResult Index()
        {
            var categories = context.Categories.AsEnumerable();

            return View(categories);
        }

        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(model);
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
