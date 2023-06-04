using System.Collections.Generic;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;

using EmployeeTaskManagement.Repository;

namespace EmployeeTaskManagement.Manager
{
    public class DepartmentManager : BaseManager<Department>, IDepartmentManager
    {
        public DepartmentManager(EmployeeDbContext db) : base(new BaseRepository<Wing>(db))
        {
        }

        public Wing GetWingById(int? id)
        {
            return GetFirstOrDefault(x => x.Id == id);
        }

        public ICollection<Wing> GetWings()
        {
            return Get(x => x.IsActive);
        }
    }
}
