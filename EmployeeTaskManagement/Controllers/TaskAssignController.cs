using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Manager;
using EmployeeTaskManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTaskManagement.Controllers
{
    public class TaskAssignController : Controller
    {
        private readonly ITaskAssignManager _taskAssignManager;
        private readonly IEmployeeInfoManager _employeeInfoManager;
        public TaskAssignController(EmployeeDbContext dbContext)
        {
            _employeeInfoManager=new EmployeeInfoManager(dbContext);
            _taskAssignManager=new TaskAssignManager(dbContext);
        }
        public IActionResult Index()
        {
            ViewBag.SuccessMessage = TempData["Success"];
            ViewBag.ErrorMessage = TempData["Error"];
            ViewBag.DeleteMessage = TempData["Delete"];
            var list = _taskAssignManager.GetAll();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create(int? id)
        {
            TaskAssign taskAssign=new TaskAssign();
            if (id != null)
            {
                taskAssign = _taskAssignManager.GetById((int)id);
            }
            ViewBag.EmployeeList = _employeeInfoManager.GetAll();
            return View(taskAssign);
        }
        [HttpPost]
        public IActionResult Create(TaskAssign taskAssign,string btnValue)
        {
            //if(btnValue == "Save")
            //{
                var isSaved=_taskAssignManager.Add(taskAssign);
                if (isSaved)
                {
                    TempData["Success"] = "Task Assign complete successfully.";
                }
                else
                {
                    TempData["Error"] = "Task does not assign";
                }
            //}
            //else
            //{
            //    var checkId=_taskAssignManager.GetById(taskAssign.Id);
            //    if (checkId != null)
            //    {
            //        checkId.EmployeeId = taskAssign.EmployeeId;
            //        checkId.ProjectName= taskAssign.ProjectName;
            //        checkId.ModuleName=taskAssign.ModuleName;
            //        checkId.WorkName= taskAssign.WorkName;
            //        checkId.StartDate= taskAssign.StartDate;
            //        checkId.EndDate= taskAssign.EndDate;
            //        var result=_taskAssignManager.Update(checkId);
            //        if (result)
            //        {
            //            TempData["Success"] = "Successfully Update.";
            //        }
            //        else
            //        {
            //            TempData["Error"] = "Data not update.";
            //        }
            //    }
                //else
                //{
                //    TempData["Error"] = "Data not found.";
                //}
            //}
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var b = _taskAssignManager.GetById(id);

            bool isDeleted = _taskAssignManager.Delete(b);

            if (isDeleted)
            {
                TempData["Delete"] = "Assign Task deleted successfully.";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
