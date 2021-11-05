using System.Collections.Generic;
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
    public class VerificationModel : PageModel
    {
        private readonly IUsersData usersData;
        public IEnumerable<ApplicationUser> Users { get; set; }

        public VerificationModel(IUsersData usersData)
        {
            this.usersData = usersData;
        }

        public void OnGet()
        {
            Users = usersData.GetAllUsers();
        }
    }
}

