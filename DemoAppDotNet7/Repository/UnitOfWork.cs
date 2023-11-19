using DemoAppDotNet7.Data;
using DemoAppDotNet7.Models;
using DemoAppDotNet7.Repository.Base;

namespace DemoAppDotNet7.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public IRepository<Course> Courses { get; private set; }

        public IRepository<Department> Departments { get; private set; }

        public IRepository<Instructor> Instructors { get; private set; }

        public IRepository<Office> Offices { get; private set; }

        public IRepository<Section> Sections { get; private set; }

        //spicial repo
        public IEmployeeRepository Employees { get; private set; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

            Courses = new MainRepository<Course>(_appDbContext);
            Departments = new MainRepository<Department>(_appDbContext);

            //spicial repo
            Employees = new EmployeeRepository(_appDbContext);

            Instructors = new MainRepository<Instructor>(_appDbContext);
            Offices = new MainRepository<Office>(_appDbContext);
            Sections = new MainRepository<Section>(_appDbContext);
        }

        public async Task<int> CommiteChangesAsync()
        {
            return await _appDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
