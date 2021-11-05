using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class DeleteSubjectModel : PageModel
    {
        private readonly ISubjectData subjectData;

        public DeleteSubjectModel(ISubjectData subject)
        {
            subjectData = subject;
        }

        [BindProperty]
        public Subject Subjects { get; set; }

        public async Task<IActionResult> OnGet(int subjectId)
        {
            if (subjectId <= 0)
                return RedirectToPage("./NotFound");

            Subjects = await subjectData.GetSpecificSubject(subjectId);

            return Page();
        }

        public async Task<IActionResult> OnPost(int subjectId)
        {
            var subject = await subjectData.RemoveSubjectAsync(subjectId);
            await subjectData.CommitAsync();

            if (subject == null)
                RedirectToPage("./NotFound");

            return RedirectToPage("./SubjectList");
        }
    }
}