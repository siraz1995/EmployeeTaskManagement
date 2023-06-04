using EmployeeTaskManagement.Areas.Identity.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeTaskManagement.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
    }
}
