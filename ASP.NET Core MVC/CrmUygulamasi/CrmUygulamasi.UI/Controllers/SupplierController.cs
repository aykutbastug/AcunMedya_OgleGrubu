using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using CrmUygulamasi.Entites;
using CrmUygulamasi.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.Controllers
{
    public class SupplierController : Controller
    {
        private readonly INotificationService notificationService;

        public SupplierController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        SupplierManager supplierManager = new SupplierManager(new EfSupplierRepository());
        public IActionResult Index()
        {
            List<Supplier> list = supplierManager.ListAll();
            return View(list);
        }

        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    supplierManager.Create(supplier);
                    notificationService.Notification(NotifyType.Success, $"{supplier.CompanyName} isimli tedarikçi başarılı bir şekilde kayıt edildi.");
                }
                catch (Exception ex)
                {
                    notificationService.Notification(NotifyType.Error, ex.Message);
                }
            }
            else
                ModelStateControl.KontrolEt(notificationService, ModelState);


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
            if (ModelState.IsValid)
            {
                try
                {
                    supplierManager.Update(supplier);
                    notificationService.Notification(NotifyType.Success, $"{supplier.CompanyName} isimli tedarikçi başarılı bir şekilde güncellendi.");
                }
                catch (Exception ex)
                {
                    notificationService.Notification(NotifyType.Error, ex.Message);
                }
            }
            else
                ModelStateControl.KontrolEt(notificationService, ModelState);

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
            try
            {
                supplierManager.Delete(supplier);
                notificationService.Notification(NotifyType.Success, $"{supplier.CompanyName} isimli tedarikçi başarılı bir şekilde silindi.");
            }
            catch (Exception ex)
            {
                notificationService.Notification(NotifyType.Error, ex.Message);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
