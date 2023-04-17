using CrmUygulamasi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.BLL.Abstract
{
    public interface ICustomerService
    {
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        Customer Get(int id);
        List<Customer> ListAll();
    }
}
