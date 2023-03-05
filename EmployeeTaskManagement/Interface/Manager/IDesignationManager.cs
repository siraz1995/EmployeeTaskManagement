using System.Collections.Generic;
using EmployeeTaskManagement.Models;


namespace EmployeeTaskManagement.Interface.Manager
{
   public interface IDesignationManager : IBaseManager<Designation>
    {
        ICollection<Designation> GetDesignation();
        Designation GetDesignationById(int? id);
    }
}
