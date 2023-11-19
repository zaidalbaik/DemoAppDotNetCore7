namespace DemoAppDotNet7.Models
{
    public class Result
    {
        public int InstractorId { get; set; }
        public string Name { get; set; }
        public int OfficeId { get; set; }
        public string OffeceName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Instructor ID: {InstractorId}\t\t, Instructor Name: {Name}\t\t, Office ID: {OfficeId}\t\t, Office Name: {OffeceName}\t\t, Course ID: {CourseId}\t\t, Course Name: {CourseName}\t\t, Price: {Price:C}";
        }
    }
}
