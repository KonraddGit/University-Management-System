using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize]
    public class AnnouncementModel : PageModel
    {
        public IAnnouncementData announcement { get; }
        
        [BindProperty]
        public IEnumerable<Announcement> Announcements { get; private set; }

        public AnnouncementModel(IAnnouncementData announcement)
        {
            this.announcement = announcement;
        }

        public void OnGet()
        {
            Announcements = announcement.GetAllAnnouncements();
        }
    }
}
