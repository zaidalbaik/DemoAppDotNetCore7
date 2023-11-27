using DemoAppDotNet7.Data.Config;
using DemoAppDotNet7.Data.Interceptors;
using DemoAppDotNet7.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DemoAppDotNet7.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        //Table
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Office> Offeces { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<TestViewGetEmployees> TestViewGetEmployees { get; set; }


        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //individual call
            //new EmployeeConfigurations().Configure(modelBuilder.Entity<Employee>());

            //for all configurations 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeConfigurations).Assembly);

            modelBuilder.HasDbFunction(
              typeof(AppDbContext).GetMethod(nameof(GetInstructorAndCourseInfoByOfficeId), new[] { typeof(int) })
            );
        }
        public IQueryable<Result> GetInstructorAndCourseInfoByOfficeId(int OfficeId)
       => FromExpression(() => GetInstructorAndCourseInfoByOfficeId(OfficeId));

    }
}
