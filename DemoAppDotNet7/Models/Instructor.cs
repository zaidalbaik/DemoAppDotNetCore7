namespace DemoAppDotNet7.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? OfficeId { get; set; }  //optional , set null delete effect  as FK
        public Office? Office { get; set; } 

        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
