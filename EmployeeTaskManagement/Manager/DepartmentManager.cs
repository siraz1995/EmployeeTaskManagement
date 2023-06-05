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
        public DepartmentManager(EmployeeDbContext db) : base(new BaseRepository<Department>(db))
        {
        }

        public Department GetDepartmentById(int? id)
        {
            return GetFirstOrDefault(x => x.Id == id);
        }

        public ICollection<Department> GetDepartment()
        {
            return Get(x =>true);
        }
    }
}
