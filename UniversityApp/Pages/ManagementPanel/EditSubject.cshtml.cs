using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class EditSubjectModel : PageModel
    {
        private readonly ISubjectData subjectData;

        public EditSubjectModel(ISubjectData subjectData)
        {
            this.subjectData = subjectData;
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            var subject = await subjectData.GetSpecificSubject(Subjects.SubjectId);
            subject.SubjectName = Subjects.SubjectName;

            subjectData.Update(subject);
            await subjectData.CommitAsync();

            return RedirectToPage("./SubjectList");
        }
    }
}