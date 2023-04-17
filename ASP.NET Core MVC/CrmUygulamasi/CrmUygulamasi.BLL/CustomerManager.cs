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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Create(Customer customer)
        {
            _customerDal.Create(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public Customer Get(int id)
        {
            return _customerDal.Get(id);
        }

        public List<Customer> ListAll()
        {
            return _customerDal.ListAll();
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
