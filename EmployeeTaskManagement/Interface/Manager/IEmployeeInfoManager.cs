using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Interface.Manager
{
    public interface IEmployeeInfoManager:IBaseManager<EmployeeInfo>
    {
        EmployeeInfo GetById(int id);
        ICollection<EmployeeInfo> GetAll();
    }
}
