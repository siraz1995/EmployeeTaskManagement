using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Repository;

namespace EmployeeTaskManagement.Manager
{
    public class TaskAssignManager : BaseManager<TaskAssign>, ITaskAssignManager
    {
        public TaskAssignManager(EmployeeDbContext db) : base(new BaseRepository<TaskAssign>(db))
        {
        }

        public ICollection<TaskAssign> GetAll()
        {
            return Get(c => true);
        }

        public TaskAssign GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
