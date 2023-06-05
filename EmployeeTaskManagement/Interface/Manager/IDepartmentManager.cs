using System.Collections.Generic;
using EmployeeTaskManagement.Models;


namespace EmployeeTaskManagement.Interface.Manager
{
   public interface IDepartmentManager : IBaseManager<Department>
    {
        ICollection<Department> GetDepartment();
        Department GetDepartmentById(int? id);
    }
}
