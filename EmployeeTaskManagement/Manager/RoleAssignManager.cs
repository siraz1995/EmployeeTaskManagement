using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Repository;

namespace EmployeeTaskManagement.Manager
{
    public class RoleAssignManager:BaseManager<UserWiseRole>,IRoleAssignManager
    {
        public RoleAssignManager(EmployeeDbContext db):base(new BaseRepository<UserWiseRole>(db)) 
        { 
        
        }

        public ICollection<UserWiseRole> GetAll()
        {
            return Get(c => true,c=>c.Role,c=>c.EmployeeInfo);
        }

        public UserWiseRole GetById(int id)
        {
           return GetFirstOrDefault(c=>c.Id==id);
        }

        //public UserWiseRole GetByName(string name)
        //{
        //    return GetFirstOrDefault(c => c.Name == name);
        //}
    }
}
