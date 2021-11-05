using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class DeleteDepartmentModel : PageModel
    {
        public IDepartmentData DepartmentData { get; }

        [BindProperty]
        public Department Id { get; set; }

        public DeleteDepartmentModel(IDepartmentData Department)
        {
            DepartmentData = Department;
        }

        public IActionResult OnGet(int departmentId)
        {
            if (departmentId <= 0)
                return RedirectToPage("./NotFound");

            Id = DepartmentData.GetSpecificDepartment(departmentId);

            return Page();
        }

        public IActionResult OnPost(int departmentId)
        {
            var department = DepartmentData.RemoveDepartment(departmentId);
            DepartmentData.Commit();

            if (department == null)
                RedirectToPage("./NotFound");

            return RedirectToPage("./DepartmentList");
        }
    }
}
