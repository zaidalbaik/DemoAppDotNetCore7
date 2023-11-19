using DemoAppDotNet7.Models;

namespace DemoAppDotNet7.Repository.Base
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        public Task<Employee> UpdateEmployee(Employee employee);
        public bool EmployeeExists(int id);
    }
}
