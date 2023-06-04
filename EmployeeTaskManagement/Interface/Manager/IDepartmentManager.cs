using System.Collections.Generic;
using EmployeeTaskManagement.Models;


namespace EmployeeTaskManagement.Interface.Manager
{
    interface IDepartmentManager : IBaseManager<Department>
    {
        ICollection<Department> GetWings();
        Department GetWingById(int? id);
    }
}
