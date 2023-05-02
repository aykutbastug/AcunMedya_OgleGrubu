using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using CrmUygulamasi.Entites;
using CrmUygulamasi.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly INotificationService notificationService;

        public CustomerController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerRepository());
        public IActionResult Index()
        {
            List<Customer> list = customerManager.ListAll();
            return View(list);
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    customerManager.Create(customer);
                    notificationService.Notification(NotifyType.Success, $"{customer.CompanyName} isimli müşteri başarılı bir şekilde kayıt edildi.");
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

        public IActionResult CreateCustomerPartial()
        {
            return PartialView("_CreateCustomerPartialView", new Customer());
        }

        public IActionResult EditCustomerPartial(int id)
        {
            Customer customer = customerManager.Get(id);

            return PartialView("_EditCustomerPartialView", customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    customerManager.Update(customer);
                    notificationService.Notification(NotifyType.Success, $"{customer.CompanyName} isimli müşteri başarılı bir şekilde güncellendi.");
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

        public IActionResult DeleteCustomerPartial(int id)
        {
            Customer customer = customerManager.Get(id);

            return PartialView("_DeleteCustomerPartialView", customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            try
            {
                customerManager.Delete(customer);
                notificationService.Notification(NotifyType.Success, $"{customer.CompanyName} isimli müşteri başarılı bir şekilde silindi.");
            }
            catch (Exception ex)
            {
                notificationService.Notification(NotifyType.Error, ex.Message);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
