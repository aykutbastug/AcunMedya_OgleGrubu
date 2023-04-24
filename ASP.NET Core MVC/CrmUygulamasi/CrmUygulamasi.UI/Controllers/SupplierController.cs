using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using CrmUygulamasi.Entites;
using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.Controllers
{
    public class SupplierController : Controller
    {
        SupplierManager supplierManager = new SupplierManager(new EfSupplierRepository());
        public IActionResult Index()
        {
            List<Supplier> list = supplierManager.ListAll();
            return View(list);
        }

        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            supplierManager.Create(supplier);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateSupplierPartial()
        {
            return PartialView("_CreateSupplierPartialView", new Supplier());
        }

        public IActionResult EditSupplierPartial(int id)
        {
            Supplier supplier = supplierManager.Get(id);

            return PartialView("_EditSupplierPartialView", supplier);
        }

        [HttpPost]
        public IActionResult Edit(Supplier supplier)
        {
            supplierManager.Update(supplier);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteSupplierPartial(int id)
        {
            Supplier supplier = supplierManager.Get(id);

            return PartialView("_DeleteSupplierPartialView", supplier);
        }

        [HttpPost]
        public IActionResult Delete(Supplier supplier)
        {
            supplierManager.Delete(supplier);
            return RedirectToAction(nameof(Index));
        }
    }
}
