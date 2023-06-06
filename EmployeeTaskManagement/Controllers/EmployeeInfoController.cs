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
            return View();
        }
        [HttpGet]
        public IActionResult Create(int? id)
        {
            EmployeeInfo employeeInfo=new EmployeeInfo();
            if (id != null)
            {
                employeeInfo = _employeeInfoManager.GetById((int)id);
            }
            
            var departments = _departmentManager.GetAll().ToList();

            
            ViewBag.DepartmentList = new SelectList(departments, "Id", "Name");


            var designations = _designationManager.GetDesignation().ToList();


             ViewBag.designationList = new SelectList(designations, "DesignationId", "DesignationName");


             
            return View(employeeInfo);
           
        }

    }
}
