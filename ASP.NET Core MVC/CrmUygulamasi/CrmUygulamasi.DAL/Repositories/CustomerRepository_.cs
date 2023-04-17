using CrmUygulamasi.DAL.Abstract;
using CrmUygulamasi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.DAL.Repositories
{
    public class CustomerRepository_ : ICustomerDal
    {
        CrmContext context = new CrmContext();
        public void Create(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return context.Customers.Find(id);
        }

        public List<Customer> ListAll()
        {
            return context.Customers.ToList();
        }

        public void Update(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges(); 
        }
    }
}
