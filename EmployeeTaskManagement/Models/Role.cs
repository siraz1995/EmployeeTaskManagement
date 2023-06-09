using System.ComponentModel.DataAnnotations;

namespace EmployeeTaskManagement.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
    }
}
