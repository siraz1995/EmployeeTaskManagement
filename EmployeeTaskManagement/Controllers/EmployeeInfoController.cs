using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Manager;
using EmployeeTaskManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTaskManagement.Controllers
{
    public class EmployeeInfoController : Controller
    {
        private readonly IEmployeeInfoManager _employeeInfoManager;
        private readonly IDepartmentManager _departmentManager;
        private readonly IDesignationManager _designationManager;
        private readonly EmployeeDbContext _dbContext;
        public EmployeeInfoController(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
            _employeeInfoManager=new EmployeeInfoManager(dbContext);
            _departmentManager=new DepartmentManager(dbContext);
            _designationManager=new DesignationManager(dbContext);
        }
        public IActionResult Index()
        {
           // ViewBag.employee = _employeeInfoManager.GetAll.ToList();
            var list = _employeeInfoManager.GetAll();
            return View(list);
           
        }
        [HttpGet]
        public IActionResult Create(int? id)
        {
            EmployeeInfo employeeInfo=new EmployeeInfo();
            if (id != null)
            {
                employeeInfo = _employeeInfoManager.GetById((int)id);
            }

            ViewBag.DepartmentList = _departmentManager.GetDepartment();

            ViewBag.designationList = _designationManager.GetDesignation();

            return View(employeeInfo);
           
        }
        [HttpPost]
        public IActionResult Create(EmployeeInfo employeeInfo)
        {
            var result = _employeeInfoManager.Add(employeeInfo);
            if (result)
            {
                TempData["Success"] = "Successfully Added";
            }
            else
            {
                TempData["Error"] = "Failed to save";
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
