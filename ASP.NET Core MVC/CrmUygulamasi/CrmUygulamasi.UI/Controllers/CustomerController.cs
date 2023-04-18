using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using CrmUygulamasi.Entites;
using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerRepository());
        public IActionResult Index()
        {
            List<Customer> list = customerManager.ListAll();
            return View(list);
        }

        //public IActionResult Create() 
        //{ 
        //    return View();  
        //}

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customerManager.Create(customer);
            return RedirectToAction(nameof(Index));
        }
    }
}
