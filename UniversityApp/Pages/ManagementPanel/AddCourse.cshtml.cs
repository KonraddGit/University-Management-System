using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class AddCourseModel : PageModel
    {
        public AddCourseModel(IDepartmentData departmentData)
        {
            DepartmentData = departmentData;
        }

        [BindProperty]
        public Department Department { get; set; }
        public IDepartmentData DepartmentData { get; }

        public IActionResult OnGet(int departmentId)
        {
            if (departmentId <= 0)
                return RedirectToPage("./NotFound");

            Department = DepartmentData.GetSpecificDepartment(departmentId);

            return Page();
        }
        public IActionResult OnPost(int departmentId)
        {
            var department = DepartmentData.OpenDepartment(departmentId);
            DepartmentData.Commit();

            if (department == false)
                RedirectToPage("./NotFound");

            return RedirectToPage("./DepartmentList");
        }
    }
}
