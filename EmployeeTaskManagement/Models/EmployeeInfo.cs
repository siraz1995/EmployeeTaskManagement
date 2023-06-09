using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTaskManagement.Models
{
    public class EmployeeInfo
    {
        public int Id { get; set; } 
        public string EmployeeName { get; set; }
        public int EmployeeCode { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Designation")]
        public int DesignationId { get; set; }
        public DateTime JoiningDate { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
    }
}
