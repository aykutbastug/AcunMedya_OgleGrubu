using CrmUygulamasi.BLL.Abstract;
using CrmUygulamasi.DAL.Abstract;
using CrmUygulamasi.Entites;

namespace CrmUygulamasi.BLL
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Product product)
        {
            _productDal.Create(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Get(int id)
        {
            return _productDal.Get(id);
        }

        public List<Product> ListAll()
        {
            return _productDal.ListAll();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
