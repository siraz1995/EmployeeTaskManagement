using Microsoft.AspNetCore.Mvc;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Controllers
{
    public class DesignationController : Controller
    {
        private IDesignationManager _designationManager;
        public DesignationController(IDesignationManager designationManager)
        {
            _designationManager = designationManager;
        }

        public IActionResult Index()
        {
            var desiList = _designationManager.GetDesignation();
            return View(desiList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Designation designation)
        {
            bool isSaved = _designationManager.Add(designation);
            if (isSaved)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
