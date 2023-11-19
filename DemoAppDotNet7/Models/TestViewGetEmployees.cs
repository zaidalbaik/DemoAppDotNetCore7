namespace DemoAppDotNet7.Models
{
    public class TestViewGetEmployees
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public float Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public int DepartmentId { get; set; } // Employee belongs to a Department
        public Department Department { get; set; } // Navigation property to represent the Department relationship
        public override string ToString()
        {
            return $"Id : {Id} | FirstName : {FirstName} | LastName : {LastName} | Salary : {Salary} | PhoneNumber : {PhoneNumber} | HireDate : {HireDate}";
        }
    }
}
