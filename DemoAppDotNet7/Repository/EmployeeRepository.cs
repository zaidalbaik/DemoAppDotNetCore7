using DemoAppDotNet7.Data;
using DemoAppDotNet7.Models;
using DemoAppDotNet7.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace DemoAppDotNet7.Repository
{
    public class EmployeeRepository : MainRepository<Employee>, IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            try
            {
                _appDbContext.Update(employee);
                await _appDbContext.SaveChangesAsync();

                return employee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public bool EmployeeExists(int id)
        {
            return (_appDbContext.Employees?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
