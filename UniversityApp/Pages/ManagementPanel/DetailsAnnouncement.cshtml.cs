using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize]
    public class DetailsAnnouncementModel : PageModel
    {
        public Announcement Announcement { get; set; }
        public IAnnouncementData AnnouncementData { get; }

        public DetailsAnnouncementModel(IAnnouncementData announcementData)
        {
            AnnouncementData = announcementData;
        }

        public IActionResult OnGet(string topic)
        {
            if (topic == null)
                RedirectToPage("./Announcement");

            Announcement = AnnouncementData.GetSpecificAnnouncement(topic);

            return Page();
        }
    }
}
