using DemoAppDotNet7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAppDotNet7.Data.Config
{
    public class TestViewConfigurations : IEntityTypeConfiguration<TestViewGetEmployees>
    {
        public void Configure(EntityTypeBuilder<TestViewGetEmployees> builder)
        {
            builder.HasNoKey();
            builder.Property(e => e.Id).HasColumnName("EmployeeId"); //لازم تعملها عشان يتطابق الاسماء عند استدعاء الفيو
            builder.ToView("SelectAllEmployees");
        }
    }
}
