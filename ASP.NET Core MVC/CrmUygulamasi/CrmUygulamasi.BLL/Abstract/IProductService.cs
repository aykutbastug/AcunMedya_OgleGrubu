using CrmUygulamasi.Entites;

namespace CrmUygulamasi.BLL.Abstract
{
    public interface IProductService
    {
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product Get(int id);
        List<Product> ListAll();
    }
}
