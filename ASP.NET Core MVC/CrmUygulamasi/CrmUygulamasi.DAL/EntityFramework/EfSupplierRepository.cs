using CrmUygulamasi.DAL.Abstract;
using CrmUygulamasi.DAL.Repositories;
using CrmUygulamasi.Entites;

namespace CrmUygulamasi.DAL.EntityFramework
{
    public class EfSupplierRepository : GenericRepository<Supplier>, ISupplierDal
    {

    }
}
