using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IUsersData usersData;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager;
        private readonly IAnnouncementData announcementData;
        private readonly IDepartmentData departmentData;

        public int UsersAmount { get; set; }
        public IEnumerable<Announcement> Announcement { get; set; }
        public ApplicationUser UserId { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<ApplicationUser> UsersNotConfirmed { get; set; }
        public int NotConfirmedAmount { get; private set; }
        public string Role { get; set; }

        public IndexModel(IUsersData usersData,
            Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager,
            IAnnouncementData announcementData,
            IDepartmentData departmentData)
        {
            this.usersData = usersData;
            this.userManager = userManager;
            this.announcementData = announcementData;
            this.departmentData = departmentData;
        }

        public IActionResult OnGet()
        {
            UserId = usersData.GetSpecificUser(User.Identity.GetUserId());
            UsersAmount = usersData.GetAllUsers().Count();
            UsersNotConfirmed = usersData.GetNotConfirmedUsers();
            NotConfirmedAmount = UsersNotConfirmed.Count();
            Announcement = announcementData.GetAllAnnouncements();
            Departments = departmentData.ReturnDepartments();

            return Page();
        }
    }
}
