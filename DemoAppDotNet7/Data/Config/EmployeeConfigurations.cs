using DemoAppDotNet7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAppDotNet7.Data.Config
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
           
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("EmployeeId");
            builder.Property(e => e.Id).ValueGeneratedNever();//not set automaticly

            builder.Property(e => e.FirstName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.Property(e => e.LastName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.Property(e => e.Email).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.Property(e => e.HireDate).IsRequired();

            builder.Property(e => e.IsDeleted).IsRequired();
            //Relation One To Many  'for an employee there is one department and for each department there are many employees'

            builder.HasOne(e => e.Department)           // Employee has one Department
                   .WithMany(d => d.Employees)           // Department has many Employees
                   .HasForeignKey(e => e.DepartmentId)
                   .HasConstraintName("DepartmentId_FK")  // Foreign key in Employee model
                   .IsRequired(false);

            builder.HasQueryFilter(e => e.IsDeleted == false);//show row only IsDeleted == false

            builder.HasData(GenerateInitialData());
        }

        private List<Employee> GenerateInitialData()
        {
            //Note!!!!!! : Be careful not to enter values ​​that are not in the department tableas departmentId = 5
            var employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName ="zaid" ,LastName ="albaik" ,Email="zaid@g.com", PhoneNumber="0790000000" ,Salary=1000, HireDate=DateTime.Now ,DepartmentId= 1 },
                new Employee { Id = 2, FirstName ="ali" ,LastName ="albaik" ,Email="ali@g.com", PhoneNumber="0790000000" ,Salary=2000, HireDate=DateTime.Now ,DepartmentId= 2 },
                new Employee { Id = 3, FirstName ="ahmad" ,LastName ="albaik" ,Email="ahmad@g.com", PhoneNumber="0790000000" ,Salary=3000, HireDate=DateTime.Now ,DepartmentId= 3 },
                new Employee { Id = 4, FirstName ="mohammad" ,LastName ="albaik", Email="mohammad@g.com", PhoneNumber="0790000000", Salary=4000, HireDate=DateTime.Now ,DepartmentId= 4}
            };

            return employees;
        }
    }
}
