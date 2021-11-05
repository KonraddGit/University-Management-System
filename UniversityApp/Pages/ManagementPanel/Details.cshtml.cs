using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "admin")]
    public class DetailsModel : PageModel
    {
        private readonly IUsersData usersData;
        public ApplicationUser UserId { get; set; }

        public DetailsModel(IUsersData usersData)
        {
            this.usersData = usersData;
        }

        public IActionResult OnGet(string userId)
        {
            if (userId == null)
                RedirectToPage("./UsersList");

            UserId = usersData.GetSpecificUser(userId);

            return Page();
        }
    }
}
