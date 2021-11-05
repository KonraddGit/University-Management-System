using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityApp.Data.Interfaces;
using System.Linq;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "admin")]
    public class EditModel : PageModel
    {
        private readonly IUsersData usersData;
        private readonly IHtmlHelper htmlHelper;
        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty]
        public ApplicationUser UserId { get; set; }

        [BindProperty]
        public Roles Role { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }

        public EditModel(IUsersData usersData,
                         IHtmlHelper htmlHelper,
                         UserManager<ApplicationUser> userManager)
        {
            this.usersData = usersData;
            this.htmlHelper = htmlHelper;
            this.userManager = userManager;
        }
        public IActionResult OnGet(string userId)
        {
            Roles = htmlHelper.GetEnumSelectList<Roles>();

            if (userId != null)
                UserId = usersData.GetSpecificUser(userId);

            if (userId == null)
                return RedirectToPage("./NotFound");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Roles = htmlHelper.GetEnumSelectList<Roles>();
                return Page();
            }

            var user = await userManager.FindByIdAsync(UserId.Id);

            user.FirstName = UserId.FirstName;
            user.LastName = UserId.LastName;
            user.FullName = $"{UserId.FirstName} {UserId.LastName}";
            user.Email = UserId.Email;
            user.UserName = UserId.Email;

            await userManager.UpdateAsync(user);

            var role = @User.Claims.First(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").Value;

            await userManager.RemoveFromRoleAsync(UserId, role);
            await userManager.AddToRoleAsync(UserId, Role.ToString());

            usersData.Commit();

            return RedirectToPage("./UsersList");
        }
    }
}
