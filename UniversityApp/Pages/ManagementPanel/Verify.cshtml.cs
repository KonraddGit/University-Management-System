using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "admin")]
    public class VerifyModel : PageModel
    {
        private readonly IUsersData usersData;

        public VerifyModel(IUsersData usersData)
        {
            this.usersData = usersData;
        }

        public IActionResult OnGet(string userId)
        {
            usersData.ConfirmUser(userId);
            usersData.Commit();

            return RedirectToPage("./Verification");
        }
    }
}
