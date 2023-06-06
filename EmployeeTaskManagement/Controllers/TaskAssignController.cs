using Microsoft.AspNetCore.Mvc;

namespace EmployeeTaskManagement.Controllers
{
    public class TaskAssignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
