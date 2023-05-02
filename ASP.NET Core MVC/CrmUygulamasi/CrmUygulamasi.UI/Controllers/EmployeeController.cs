using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using CrmUygulamasi.Entites;
using CrmUygulamasi.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly INotificationService notificationService;

        public EmployeeController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeRepository());
        public IActionResult Index()
        {
            List<Employee> list = employeeManager.ListAll();
            return View(list);
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employeeManager.Create(employee);
                    notificationService.Notification(NotifyType.Success, $"{employee.NameSurname} isimli personel başarılı bir şekilde kayıt edildi.");
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

        public IActionResult CreateEmployeePartial()
        {
            return PartialView("_CreateEmployeePartialView", new Employee());
        }

        public IActionResult EditEmployeePartial(int id)
        {
            Employee employee = employeeManager.Get(id);

            return PartialView("_EditEmployeePartialView", employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employeeManager.Update(employee);
                    notificationService.Notification(NotifyType.Success, $"{employee.NameSurname} isimli personel başarılı bir şekilde güncellendi.");
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

        public IActionResult DeleteEmployeePartial(int id)
        {
            Employee employee = employeeManager.Get(id);

            return PartialView("_DeleteEmployeePartialView", employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            try
            {
                employeeManager.Delete(employee);
                notificationService.Notification(NotifyType.Success, $"{employee.NameSurname} isimli personel başarılı bir şekilde silindi.");
            }
            catch (Exception ex)
            {
                notificationService.Notification(NotifyType.Error, ex.Message);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
