namespace CrmUygulamasi.BLL.Abstract
{
    public interface IEmployeeService
    {
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        Employee Get(int id);
        List<Employee> ListAll();
    }
}
