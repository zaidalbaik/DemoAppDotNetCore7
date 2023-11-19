using DemoAppDotNet7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAppDotNet7.Data.Config
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.DepartmentId);
            builder.Property(e => e.DepartmentId).HasColumnName("Id").ValueGeneratedNever();

            builder.Property(d => d.DepartmentName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.Property(d => d.DepartmentNumber).IsRequired(false);

            builder.ToTable("Departments");

            builder.HasData(GenerateInitialData());
        }

        private List<Department> GenerateInitialData()
        {
            var employees = new List<Department>()
            {
                new Department(){ DepartmentId =1 , DepartmentName ="Managing department" },
                new Department(){ DepartmentId =2 , DepartmentName ="Financial department" },
                new Department(){ DepartmentId =3 , DepartmentName ="IT department" },
                new Department(){ DepartmentId =4 , DepartmentName ="HRs department" },
            };

            return employees;
        }
    }
}
