using DemoAppDotNet7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAppDotNet7.Data.Config
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedNever();

            builder.Property(o => o.Name).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.ToTable("Offices");

            builder.HasData(LoadOffecs());
        }

        private List<Office> LoadOffecs()
        {
            return new List<Office>()
            {
                new Office(){Id = 1, Name = "Zaid Albaik"},
                new Office(){Id = 2, Name = "test Albaik"},
                new Office(){Id = 3, Name = "waled Albaik"},
                new Office(){Id = 4, Name = "soso Albaik"},
                new Office(){Id = 5, Name = "Kamal Albaik"},
            };
        }
    }
}
