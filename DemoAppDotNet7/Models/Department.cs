namespace DemoAppDotNet7.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string? DepartmentName { get; set; }

        public int? DepartmentNumber { get; set; }
        public List<Employee> Employees { get; set; } // Department has a collection of Employees    
    }
}
