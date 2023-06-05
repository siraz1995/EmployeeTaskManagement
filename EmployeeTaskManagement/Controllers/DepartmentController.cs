using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Manager;
using EmployeeTaskManagement.Models;

using Microsoft.AspNetCore.Mvc;

namespace EmployeeTaskManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentManager _departmentManager;
      
        public DepartmentController(IDepartmentManager departmentManager)
        {
          _departmentManager= departmentManager;          
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            bool isSaved = _departmentManager.Add(department);
            if (isSaved) 
            {
                return Ok("Department added successfully.");
            }
            else
            {
                return BadRequest("Department does not added.Please try again.");
            }
            
        }
    }
}
