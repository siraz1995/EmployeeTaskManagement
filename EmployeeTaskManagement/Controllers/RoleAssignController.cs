using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Manager;
using EmployeeTaskManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Permissions;

namespace EmployeeTaskManagement.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly IRoleAssignManager _roleAssignManager;
        private readonly IEmployeeInfoManager _employeeInfoManager;
        private readonly IRoleManager _roleManager;
        public RoleAssignController(EmployeeDbContext db)
        { 
        _roleAssignManager=new RoleAssignManager(db);
        _employeeInfoManager=new EmployeeInfoManager(db);
        _roleManager=new RoleManager(db);
        }
        public IActionResult Index()
        {
            ViewBag.SuccessMessage = TempData["Success"];
            ViewBag.ErrorMessage = TempData["Error"];
            ViewBag.DeleteMessage = TempData["Delete"];
            var list=_roleAssignManager.GetAll();
            return View(list);
        }
        [HttpGet]
       public IActionResult AssignRole()
        {
           UserWiseRole userWiseRole=new UserWiseRole();
            
            ViewBag.EmployeeList=_employeeInfoManager.GetAll();
            ViewBag.RoleList= _roleManager.GetAll();
            return View(userWiseRole);
        }

        [HttpPost]
        
        public IActionResult AssignRole(UserWiseRole userWiseRole)
        {
           
                var result =  _roleAssignManager.Add(userWiseRole);
                if (result)
                {
                    TempData["Success"] = "Role assigned successfully.";
                }
                else
                {
                    TempData["Error"] = "Role assigned Failed";
                }
           return RedirectToAction(nameof(Index));
            

        }

        [HttpPost]
        
        public  IActionResult DeleteRole(int id)
        {
            var getRole = _roleAssignManager.GetById(id);
            if (getRole != null)
            {
                _roleAssignManager.Delete(getRole);
                TempData["Delete"] = "Successfully Deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
