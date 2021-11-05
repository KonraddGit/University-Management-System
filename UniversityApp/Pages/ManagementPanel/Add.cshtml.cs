using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "admin")]
    public class AddModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHtmlHelper htmlHelper;
        public IEnumerable<SelectListItem> Roles { get; set; }

        [BindProperty]
        public Roles Role { get; set; }
        public AddModel(UserManager<ApplicationUser> _userManager,
            IHtmlHelper htmlHelper)
        {
            this._userManager = _userManager;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet()
        {
            Roles = htmlHelper.GetEnumSelectList<Roles>();
            
            return Page();
        }

        [BindProperty]
        public ApplicationUser UserId { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [PersonalData]
            [DataType(DataType.Password)]
            [Display(Name = "Has³o")]
            public string Password { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Roles = htmlHelper.GetEnumSelectList<Roles>();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = new ApplicationUser { FirstName = UserId.FirstName, LastName = UserId.LastName, UserName = UserId.Email, Email = UserId.Email };
            var result = await _userManager.CreateAsync(user, Input.Password);

            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, $"{Role}");

            return RedirectToPage("./UsersList");
        }

    }
}
