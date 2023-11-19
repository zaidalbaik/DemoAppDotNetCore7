using DemoAppDotNet7.Models;

namespace DemoAppDotNet7.Data
{
    //for using create & Drop 'API'
    public static class SeedData
    {
        public static List<Department> LoadDeparments() => new()
        {
            new Department(){ DepartmentId =1 , DepartmentName ="Managing department" },
            new Department(){ DepartmentId =2 , DepartmentName ="Financial department" },
            new Department(){ DepartmentId =3 , DepartmentName ="IT department" },
            new Department(){ DepartmentId =4 , DepartmentName ="HRs department" },
        };

        public static List<Employee> LoadEmployees() => new()
        {
            new Employee { Id = 1, FirstName ="zaid" ,LastName ="albaik" ,Email="zaid@g.com", PhoneNumber="0790000000" ,Salary=1000, HireDate=DateTime.Now ,DepartmentId= 1 },
            new Employee { Id = 2, FirstName ="ali" ,LastName ="albaik" ,Email="ali@g.com", PhoneNumber="0790000000" ,Salary=2000, HireDate=DateTime.Now ,DepartmentId= 2 },
            new Employee { Id = 3, FirstName ="ahmad" ,LastName ="albaik" ,Email="ahmad@g.com", PhoneNumber="0790000000" ,Salary=3000, HireDate=DateTime.Now ,DepartmentId= 3 },
            new Employee { Id = 4, FirstName ="mohammad" ,LastName ="albaik", Email="mohammad@g.com", PhoneNumber="0790000000", Salary=4000, HireDate=DateTime.Now ,DepartmentId= 4}
        };

        public static List<Course> LoadCourses() => new()
        {
            new Course { Id = 1, CourseName = "Mathmatics", Price = 1000m},
            new Course { Id = 2, CourseName = "Physics", Price = 2000m},
            new Course { Id = 3, CourseName = "Chemistry", Price = 1500m},
            new Course { Id = 4, CourseName = "Biology", Price = 1200m},
            new Course { Id = 5, CourseName = "CS-50", Price = 3000m},
        };

        public static List<Office> LoadOffeces() => new()
        {
            new Office(){Id = 1, Name = "Zaid Albaik"},
            new Office(){Id = 2, Name = "test Albaik"},
            new Office(){Id = 3, Name = "waled Albaik"},
            new Office(){Id = 4, Name = "soso Albaik"},
            new Office(){Id = 5, Name = "Kamal Albaik"},
        };

        public static List<Instructor> LoadInstructors() => new()
        {
            new Instructor { Id = 1,Name= "Abdullah", OfficeId = 1},
            new Instructor { Id = 2,Name= "Yasmeen", OfficeId = 2},
            new Instructor { Id = 3,Name= "Hassan", OfficeId = 3},
            new Instructor { Id = 4,Name= "Ali", OfficeId = 4},
            new Instructor { Id = 5,Name= "Ali", OfficeId = 5},
        }; 

        public static List<Section> LoadSecitons() => new()
        {
            new Section { Id = 1, SectionName = "S_MA1", CourseId = 1, InstructorId = 1},
            new Section { Id = 2, SectionName = "S_MA2", CourseId = 1, InstructorId = 2},
            new Section { Id = 4, SectionName = "S_PH2", CourseId = 2, InstructorId = 3},
            new Section { Id = 7, SectionName = "S_BI1", CourseId = 4, InstructorId = 4},
            new Section { Id = 8, SectionName = "S_BI2", CourseId = 4, InstructorId = 5},
        };
    }
}
