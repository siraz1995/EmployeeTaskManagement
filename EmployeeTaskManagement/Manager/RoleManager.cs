using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Repository;
using NuGet.Protocol;

namespace EmployeeTaskManagement.Manager
{
    public class RoleManager : BaseManager<Role>,IRoleManager
    {
        public RoleManager(EmployeeDbContext db):base(new BaseRepository<Role>(db)) 
        {
        
        }

        public ICollection<Role> GetAll()
        {
            return Get(c => true);
        }

        public Role GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
