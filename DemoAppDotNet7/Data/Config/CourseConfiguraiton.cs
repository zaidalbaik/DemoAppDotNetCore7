using DemoAppDotNet7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace DemoAppDotNet7.Data.Config
{
    public class CourseConfiguraiton : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("CourseId").ValueGeneratedNever();

            builder.Property(x => x.CourseName)
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(255).IsRequired();


            builder.Property(x => x.Price)
                .HasPrecision(15, 2);

            builder.ToTable("Courses");


            builder.HasData(LoadCourses());
        }
        private static List<Course> LoadCourses()
        {
            return new List<Course>
            {
                new Course { Id = 1, CourseName = "Mathmatics", Price = 1000m},
                new Course { Id = 2, CourseName = "Physics", Price = 2000m},
                new Course { Id = 3, CourseName = "Chemistry", Price = 1500m},
                new Course { Id = 4, CourseName = "Biology", Price = 1200m},
                new Course { Id = 5, CourseName = "CS-50", Price = 3000m},
            };
        }
    }
}
