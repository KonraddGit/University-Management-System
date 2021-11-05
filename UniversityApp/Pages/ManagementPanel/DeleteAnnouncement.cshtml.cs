using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class DeleteAnnouncementModel : PageModel
    {
        public IAnnouncementData AnnouncementData { get; }

        [BindProperty]
        public Announcement Topic { get; set; }
        public DeleteAnnouncementModel(IAnnouncementData announcementData)
        {
            AnnouncementData = announcementData;
        }

        public IActionResult OnGet(string topic)
        {
            Topic = AnnouncementData.GetSpecificAnnouncement(topic);

            if (topic == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(string topic)
        {
            var topicTitle = AnnouncementData.RemoveAnnouncement(topic);
            AnnouncementData.Commit();

            if (topicTitle == null)
            {
                RedirectToPage("./NotFound");
            }

            return RedirectToPage("./Announcement");
        }
    }
}
