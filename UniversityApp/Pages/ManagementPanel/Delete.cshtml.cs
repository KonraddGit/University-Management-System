using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "admin")]
    public class DeleteModel : PageModel
    {
        public IUsersData UsersData { get; }

        public ApplicationUser UserId { get; set; }
        public DeleteModel(IUsersData usersData)
        {
            UsersData = usersData;
        }
        public IActionResult OnGet(string userId)
        {
            UserId = UsersData.GetSpecificUser(userId);

            if (UserId == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(string userId)
        {
            var user = UsersData.Delete(userId);
            UsersData.Commit();

            if (user == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{user.FullName} deleted";
            return RedirectToPage("./UsersList");
        }
    }
}
