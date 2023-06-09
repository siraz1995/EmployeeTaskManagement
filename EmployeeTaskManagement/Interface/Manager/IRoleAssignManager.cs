using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Interface.Manager
{
    public interface IRoleAssignManager:IBaseManager<UserWiseRole>
    {
        UserWiseRole GetById(int id);
        ICollection<UserWiseRole> GetAll();
        //UserWiseRole GetByName(string name);
    }
}
