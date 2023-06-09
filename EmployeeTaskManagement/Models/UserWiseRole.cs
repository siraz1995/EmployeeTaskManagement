using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTaskManagement.Models
{
    public class UserWiseRole
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        [ForeignKey("EmployeeInfo")]
        public int EmployeeId { get; set; }
        public virtual Role Role { get; set; }
        public virtual EmployeeInfo EmployeeInfo { get; set; }
    }
}
