using DemoAppDotNet7.Models.Contract;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAppDotNet7.Models
{
    public class Employee : ISoftDeleteable
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Phone, Required, Display(Name = "PhoneNumber"), StringLength(10, MinimumLength = 6)]
        public string? PhoneNumber { get; set; }

        [EmailAddress, Required, Display(Name = "Email"), StringLength(100, MinimumLength = 10)]
        public string? Email { get; set; }
        public float Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public int DepartmentId { get; set; } // Employee belongs to a Department

        //[BindNever]
        public Department? Department { get; set; } // Navigation property to represent the Department relationship
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

        public string? ImagePath { get; set; }

        //for upload only
        [NotMapped]
        public IFormFile? ClientFile { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} | FirstName : {FirstName} | LastName : {LastName} | Salary : {Salary} | PhoneNumber : {PhoneNumber} | HireDate : {HireDate} | IsDeleted {IsDeleted} | DateDeleted  {DateDeleted}";
        }
    }
}
