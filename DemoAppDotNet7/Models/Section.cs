namespace DemoAppDotNet7.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }

        public int CourseId { get; set; }//required
        public Course Course { get; set; }//required

        public int? InstructorId { get; set; } //optional يعني ممكن يكون للقسم معلم وممكن نفتح قسم من دون معلم 
        public Instructor? Instructor { get; set; }//optional

        public TimeSlot TimeSlot { get; set; }
    }
    public class TimeSlot
    {
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

    }
}