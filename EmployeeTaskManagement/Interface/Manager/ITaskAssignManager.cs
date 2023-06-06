using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Interface.Manager
{
    public interface ITaskAssignManager:IBaseManager<TaskAssign>
    {
        TaskAssign GetById(int id);
        ICollection<TaskAssign> GetAll();
    }
}
