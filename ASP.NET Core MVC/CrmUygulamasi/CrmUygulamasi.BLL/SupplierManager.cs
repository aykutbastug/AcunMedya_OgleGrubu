using CrmUygulamasi.BLL.Abstract;
using CrmUygulamasi.DAL.Abstract;
using CrmUygulamasi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.BLL
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public void Create(Supplier supplier)
        {
            _supplierDal.Create(supplier);
        }

        public void Delete(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
        }

        public Supplier Get(int id)
        {
            return _supplierDal.Get(id);
        }

        public List<Supplier> ListAll()
        {
            return _supplierDal.ListAll();
        }

        public void Update(Supplier supplier)
        {
            _supplierDal.Update(supplier);
        }
    }
}
