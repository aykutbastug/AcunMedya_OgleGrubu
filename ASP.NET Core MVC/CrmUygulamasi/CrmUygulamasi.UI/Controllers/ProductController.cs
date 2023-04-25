using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using CrmUygulamasi.Entites;
using CrmUygulamasi.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly INotificationService notificationService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductController(INotificationService notificationService, IWebHostEnvironment webHostEnvironment)
        {
            this.notificationService = notificationService;
            this.webHostEnvironment = webHostEnvironment;
        }

        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            List<Product> list = productManager.ListAll();
            return View(list);
        }

        [HttpPost]
        public IActionResult Create(Product product, IFormFile file)
        {
            product.ImageUrl = "";
            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null)
                    {
                        //resim upload işlemi
                        string wwwrootPath = webHostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                        string extension = Path.GetExtension(file.FileName);

                        string yeniDosyaAdi = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwrootPath + "/images/product/", yeniDosyaAdi);

                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                        product.ImageUrl = yeniDosyaAdi;
                    }

                    productManager.Create(product);
                    notificationService.Notification(NotifyType.Success, $"{product.ProductName} isimli ürün başarılı bir şekilde kayıt edildi.");
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

        public IActionResult CreateProductPartial()
        {
            return PartialView("_CreateProductPartialView", new Product());
        }

        public IActionResult EditProductPartial(int id)
        {
            Product product = productManager.Get(id);
            return PartialView("_EditProductPartialView", product);
        }

        [HttpPost]
        public IActionResult Edit(Product product, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null)
                    {
                        //resim upload işlemi
                        string wwwrootPath = webHostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                        string extension = Path.GetExtension(file.FileName);

                        string yeniDosyaAdi = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwrootPath + "/images/product/", yeniDosyaAdi);

                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                        product.ImageUrl = yeniDosyaAdi;
                    }


                    productManager.Update(product);
                    notificationService.Notification(NotifyType.Success, $"{product.ProductName} isimli ürün başarılı bir şekilde güncellendi.");
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

        public IActionResult DeleteProductPartial(int id)
        {
            Product product = productManager.Get(id);
            return PartialView("_DeleteProductPartialView", product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            try
            {
                productManager.Delete(product);
                notificationService.Notification(NotifyType.Success, $"{product.ProductName} isimli ürün başarılı bir şekilde silindi.");
            }
            catch (Exception ex)
            {
                notificationService.Notification(NotifyType.Error, ex.Message);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
