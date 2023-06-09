using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTaskManagement.Models
{
    public class TaskAssign
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ModuleName { get; set; }
        public string WorkName { get; set; }
        public DateTime StartDate { get; set; }                     
        public DateTime EndDate { get; set; }
        [ForeignKey("EmployeeInfo")]
        public int EmployeeId { get; set; }
        public virtual EmployeeInfo EmployeeInfo { get; set; }
    }
}
