using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Manager;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTaskManagement.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleManager _roleManager;
        public RoleController(EmployeeDbContext db)
        {
            _roleManager = new RoleManager(db);
        }
        public IActionResult Index()
        {
            ViewBag.SuccessMessage = TempData["Success"];
            ViewBag.ErrorMessage = TempData["Error"];
            ViewBag.DeleteMessage = TempData["Delete"];
            var roleList=_roleManager.GetAll();
            return View(roleList);
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            Role role = new Role();
            ViewBag.SuccessMessage = TempData["Message"];
            ViewBag.ErrorMessage = TempData["Error"];
            return View(role);
        }
        [HttpPost]
        public IActionResult CreateRole(Role role)
        {
            bool isSaved=_roleManager.Add(role);
            if (isSaved)
            {
                TempData["Success"] = "Role created successfully.";
            }
            else
            {
                TempData["Error"] = "Role does not create.Please try again.";
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}
