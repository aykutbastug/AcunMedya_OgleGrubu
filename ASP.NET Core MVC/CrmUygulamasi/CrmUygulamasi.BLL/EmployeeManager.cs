using CrmUygulamasi.BLL.Abstract;
using CrmUygulamasi.DAL.Abstract;
using CrmUygulamasi.Entites;

namespace CrmUygulamasi.BLL
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Create(Employee employee)
        {
            _employeeDal.Create(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public Employee Get(int id)
        {
            return _employeeDal.Get(id);
        }

        public List<Employee> ListAll()
        {
            return _employeeDal.ListAll();
        }

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
