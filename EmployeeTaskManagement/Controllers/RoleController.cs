using EmployeeTaskManagement.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTaskManagement.Controllers
{
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            var roleList=_roleManager.Roles.ToList();
            List<RolesVm> roles = new List<RolesVm>();
            foreach(var role in roleList)
            {
                RolesVm r = new RolesVm();
                r.Id = role.Id;
                r.Name = role.Name;
                roles.Add(r);
            }
            ViewBag.SuccessMessage = TempData["Message"];
            ViewBag.ErrorMessage = TempData["Error"];
            return View(roles);
        }
        [HttpPost]
        public IActionResult CreateRole(RolesVm rolesVm)
        {
            return View(rolesVm);
        }
    }
}
