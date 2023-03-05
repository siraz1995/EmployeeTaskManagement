using System.Collections.Generic;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Interface.Manager;

using EmployeeTaskManagement.Repository;

namespace EmployeeTaskManagement.Manager
{
    public class DesignationManager : BaseManager<Designation>, IDesignationManager
    {
        public DesignationManager(EmployeeDbContext db) : base(new BaseRepository<Designation>(db))
        {
        }

        public Designation GetDesignationById(int? id)
        {
            return GetFirstOrDefault(x => x.Id == id);
        }

        public ICollection<Designation> GetDesignation()
        {
            return Get(x =>true);
        }
    }
}
