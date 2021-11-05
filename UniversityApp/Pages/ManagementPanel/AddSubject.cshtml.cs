using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class AddSubjectModel : PageModel
    {
        private readonly ISubjectData subjectData;

        public AddSubjectModel(ISubjectData subject)
        {
            subjectData = subject;
        }

        [BindProperty]
        public Subject Subject { get; set; }

        public async Task<IActionResult> OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var subject = new Subject
            {
                SubjectName = Subject.SubjectName,
                Room = new Room { Building = Subject.Room.Building, RoomNumber = Subject.Room.RoomNumber }
            };

            await subjectData.AddSubjectAsync(subject);
            await subjectData.CommitAsync();

            return RedirectToPage("./SubjectList");
        }
    }
}