using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Interface.Manager
{
    public interface IRoleManager:IBaseManager<Role>
    {
        Role GetById(int id);
        ICollection<Role> GetAll();
    }
}
