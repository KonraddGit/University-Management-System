using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class AddAnnouncementModel : PageModel
    {
        public IAnnouncementData AnnouncementData { get; }

        [BindProperty]
        public Announcement Announcement { get; set; }

        public AddAnnouncementModel(IAnnouncementData announcementData)
        {
            AnnouncementData = announcementData;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var topic = new Announcement
                {
                    Title = Announcement.Title,
                    Author = Announcement.Author,
                    Description = Announcement.Description
                };

                try
                {
                    AnnouncementData.AddAnnouncement(topic);
                    AnnouncementData.Commit();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }

            return RedirectToPage("./Announcement");
        }

    }
}
