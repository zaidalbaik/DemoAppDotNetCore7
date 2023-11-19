namespace DemoAppDotNet7.Models
{
    public class Office
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Instructor Instructor { get; set; }
    }
}
