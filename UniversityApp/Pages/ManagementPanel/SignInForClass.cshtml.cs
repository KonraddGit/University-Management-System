using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "student")]
    public class SignInForClassModel : PageModel
    {
        private readonly IDepartmentData departmentData;

        public SignInForClassModel(IDepartmentData departmentData)
        {
            this.departmentData = departmentData;
        }

        public async Task<IActionResult> OnGet(int departmentID)
        {
            await departmentData.AddStudentToClass(departmentID);

            return RedirectToPage($"./Index");
        }

        public async Task<IActionResult> OnPost(int departmentID)
        {
            return Page();
        }
    }
}
