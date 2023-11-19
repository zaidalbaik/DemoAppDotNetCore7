using DemoAppDotNet7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAppDotNet7.Data.Config
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).HasColumnName("InstractorId").ValueGeneratedNever();

            builder.Property(o => o.Name).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();


            builder.HasOne(x => x.Office)
                    .WithOne(x => x.Instructor)
                    .HasForeignKey<Instructor>(x => x.OfficeId)
                    .IsRequired(false);


            builder.ToTable("Instructors");

            builder.HasData(LoadInstructors());
        }
        private static List<Instructor> LoadInstructors()
        {
            return new List<Instructor>
            {
                new Instructor { Id = 1,Name= "Abdullah", OfficeId = 1},
                new Instructor { Id = 2,Name= "Yasmeen", OfficeId = 2},
                new Instructor { Id = 3,Name= "Hassan", OfficeId = 3},
                new Instructor { Id = 4,Name= "Ali", OfficeId = 4},
                new Instructor { Id = 5,Name= "Ali", OfficeId = 5},
            };
        }
    }
}
