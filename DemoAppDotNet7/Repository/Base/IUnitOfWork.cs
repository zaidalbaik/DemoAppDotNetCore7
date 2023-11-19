using DemoAppDotNet7.Models;

namespace DemoAppDotNet7.Repository.Base
{
    public interface IUnitOfWork : IDisposable
    {
        public IRepository<Course> Courses { get; }
        public IRepository<Department> Departments { get; }
        public IEmployeeRepository Employees { get; }
        public IRepository<Instructor> Instructors { get; }
        public IRepository<Office> Offices { get; }
        public IRepository<Section> Sections { get; }
        
        Task<int> CommiteChangesAsync();
    }
}
