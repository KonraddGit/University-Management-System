using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "admin")]
    public class UsersListModel : PageModel
    {
        private readonly IUsersData usersData;
        private readonly UserManager<ApplicationUser> userManager;

        public IEnumerable<ApplicationUser> Users { get; set; }

        public UserManager<ApplicationUser> Roles { get; set; }

        public UsersListModel(IUsersData usersData,
            UserManager<ApplicationUser> userManager)
        {
            this.usersData = usersData;
            this.userManager = userManager;
        }

        public void OnGet()
        {
            Users = usersData.GetAllUsers();
            Roles = userManager;
        }
    }
}
