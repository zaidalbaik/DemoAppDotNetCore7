using DemoAppDotNet7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAppDotNet7.Data.Config
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("SectionId").ValueGeneratedNever();

            builder.HasOne(s => s.Instructor).WithMany(c => c.Sections).HasForeignKey(c => c.InstructorId).IsRequired(false);

            builder.HasOne(s => s.Course).WithMany(c => c.Sections).HasForeignKey(c => c.CourseId).IsRequired();

            builder.OwnsOne(s => s.TimeSlot, ts =>
            {
                ts.Property(p => p.StartTime).HasColumnType("time").HasColumnName("StartTime").IsRequired(false);
                ts.Property(p => p.EndTime).HasColumnType("time").HasColumnName("EndTime").IsRequired(false);
            });

            builder.ToTable("Sections");

            builder.HasData(LoadSections());
        }
        private static List<Section> LoadSections()
        {
            return new List<Section>
            {
                new Section { Id = 1, SectionName = "S_MA1", CourseId = 1, InstructorId = 1},
                new Section { Id = 2, SectionName = "S_MA2", CourseId = 1, InstructorId = 2},
                new Section { Id = 4, SectionName = "S_PH2", CourseId = 2, InstructorId = 3},
                new Section { Id = 7, SectionName = "S_BI1", CourseId = 4, InstructorId = 4},
                new Section { Id = 8, SectionName = "S_BI2", CourseId = 4, InstructorId = 5},
            };
        }
    }
}
