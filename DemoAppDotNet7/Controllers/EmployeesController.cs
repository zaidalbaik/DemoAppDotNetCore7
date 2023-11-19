using DemoAppDotNet7.Data;
using DemoAppDotNet7.Models;
using DemoAppDotNet7.Repository;
using DemoAppDotNet7.Repository.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DemoAppDotNet7.Controllers
{
    public class EmployeesController : Controller
    {
        //old
        //private readonly IRepository<Employee> _employeeRepository;

        //using unit of work and repositories patterns
        private readonly IUnitOfWork _unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var result = await _unitOfWork.Employees.FindAllAsync("Department");
            return View(result);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _unitOfWork.Employees.FindOneAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        //GET: Employees/Create
        public async Task<IActionResult> Create()
        {
            var departmentsList = await _unitOfWork.Departments.FindAllAsync();
            ViewData["DepartmentId"] = new SelectList(departmentsList, "DepartmentId", "DepartmentName");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,Email,Salary,HireDate,DepartmentId,IsDeleted,DateDeleted")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                //await _unitOfWork.Employees.CreateOrUpdateOneAsync(employee.Id, employee);
                //await _unitOfWork.CommiteChangesAsync();
                TempData["SuccessData"] = "Create Successfully";
                return RedirectToAction(nameof(Index));
            }
            var departmentsList = await _unitOfWork.Departments.FindAllAsync();
            ViewData["DepartmentId"] = new SelectList(departmentsList, "DepartmentId", "DepartmentName", employee.DepartmentId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _unitOfWork.Employees == null)
            {
                return NotFound();
            }
            var employee = await _unitOfWork.Employees.FindOneAsync(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            var departmentsList = await _unitOfWork.Departments.FindAllAsync();
            ViewData["DepartmentId"] = new SelectList(departmentsList, "DepartmentId", "DepartmentName", employee.DepartmentId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,Email,Salary,HireDate,DepartmentId,IsDeleted,DateDeleted")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _unitOfWork.Employees.UpdateEmployee(employee);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_unitOfWork.Employees.EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var departmentsList = await _unitOfWork.Departments.FindAllAsync();
            ViewData["DepartmentId"] = new SelectList(departmentsList, "DepartmentId", "DepartmentName", employee.DepartmentId);
            return View(employee);
        }

        //// GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _unitOfWork.Employees == null)
            {
                return NotFound();
            }

            var employee = await _unitOfWork.Employees.FindOneAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_unitOfWork.Employees == null)
            {
                return Problem("Entity set 'AppDbContext.Employees'  is null.");
            }
            var employee = await _unitOfWork.Employees.FindOneAsync(m => m.Id == id);

            if (employee != null)
            {
                await _unitOfWork.Employees.RemoveItemAsync(employee);
            }

            await _unitOfWork.CommiteChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
