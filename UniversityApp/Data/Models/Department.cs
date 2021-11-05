using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityApp.Data.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Room OfficeRoom { get; set; }
        public bool SignInAvailable { get; set; }
        //public List<Subject> Subjects { get; set; }
        //public List<ApplicationUser> Students { get; set; }
        //public List<ApplicationUser> Teachers { get; set; }
    }
}
