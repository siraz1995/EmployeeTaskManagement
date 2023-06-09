using System.ComponentModel.DataAnnotations;

namespace EmployeeTaskManagement.ViewModels
{
    public class RolesVm
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
    }
}
