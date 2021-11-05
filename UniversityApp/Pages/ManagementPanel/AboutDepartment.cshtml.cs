using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office, student")]
    public class AboutDepartmentModel : PageModel
    {

        private readonly IDepartmentData department;

        public AboutDepartmentModel(IDepartmentData department)
        {
            this.department = department;
        }

        public Department Department { get; set; }
        public IEnumerable<ApplicationUser> Students {get;set;}
        public IActionResult OnGet(int departmentId)
        {
            if (departmentId <= 0)
                RedirectToPage("./DepartmentList");

            Department = department.GetSpecificDepartment(departmentId);
            Students = department.StudentsList(departmentId);

            return Page();
        }

        public IActionResult OnPost(int Id)
        {
            return Page();
        }
    }
}
