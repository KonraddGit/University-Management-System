using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class SubjectListModel : PageModel
    {
        private readonly ISubjectData subjectData;

        public SubjectListModel(ISubjectData subject)
        {
            this.subjectData = subject;
        }

        [BindProperty]
        public IEnumerable<Subject> Subjects { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Subjects = await subjectData.GetSubjectsAsync();
            
            return Page();
        }
    }
}