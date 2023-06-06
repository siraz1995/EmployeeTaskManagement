using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Repository;

namespace EmployeeTaskManagement.Manager
{
    public class EmployeeInfoManager:BaseManager<EmployeeInfo>,IEmployeeInfoManager
    {
        public EmployeeInfoManager(EmployeeDbContext db):base(new BaseRepository<EmployeeInfo>(db))
        {

        }

        public ICollection<EmployeeInfo> GetAll()
        {
            return Get(c => true);
        }

        public EmployeeInfo GetById(int id)
        {
            return GetFirstOrDefault(c=>c.Id==id);
        }
    }
}
