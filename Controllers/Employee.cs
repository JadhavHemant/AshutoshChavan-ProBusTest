using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProbusTest.Data;
using ProbusTest.Models;

namespace ProbusTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public IActionResult Index()
        {
            var employees = _dbContext.Employees.ToList(); 
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(employee);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public IActionResult Edit(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }


        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _dbContext.Update(employee);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }


        public IActionResult Delete(int id)
        {
            var employee = _dbContext.Employees.Find(id) ;
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        
        
        [HttpPost]
       
        public IActionResult DeleteConfirmed(int id,string Salution)
        {
            var employee = _dbContext.Employees.Find(id);  
            
            if (employee == null)
            {
                return NotFound();
            }

            _dbContext.Employees.Remove(employee);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}


