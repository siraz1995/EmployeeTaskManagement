using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Xml.Linq;
using EmployeeTaskManagement.Models;
using Microsoft.AspNetCore.Identity;
using static System.Collections.Specialized.BitVector32;

namespace EmployeeTaskManagement.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    [PersonalData]
    public string Name { get; set; }
    public string EmployeeCode { get; set; }
   
    public int DepartmentId { get; set; }
    
    public int DesignationId { get; set; }
    public bool IsActive { get; set; }
    public DateTime JoiningDate { get; set; }
    public string Gender { get; set; }
    public virtual Designation Designation { get; set; }
    
    public virtual Department Department { get; set; }
    public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
    public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
    public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
}

