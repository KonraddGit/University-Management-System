using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class DeleteStudentFromClassModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IDepartmentData departmentData;

        public DeleteStudentFromClassModel(
            UserManager<ApplicationUser> userManager,
            IDepartmentData departmentData)
        {
            this.userManager = userManager;
            this.departmentData = departmentData;
        }
        [BindProperty]
        public ApplicationUser UserInClass { get; set; }
        public async Task<IActionResult> OnGet(string Id)
        {
            if (Id == null)
                return Page();

            UserInClass = await userManager.FindByIdAsync(Id);

            return Page();
        }

        public async Task<IActionResult> OnPost(string Id)
        {
            if (Id == null)
                return Page();

            UserInClass = await userManager.FindByIdAsync(Id);
            UserInClass.SignedToDepartment = 0;
            await userManager.UpdateAsync(UserInClass);
            departmentData.Commit();

            return RedirectToPage("./DepartmentList");
        }
    }
}
