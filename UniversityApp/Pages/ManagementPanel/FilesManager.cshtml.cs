using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office, student, teacher")]
    public class FilesManagerModel : PageModel
    {
        private readonly IFilesData filesData;

        public FilesManagerModel(IFilesData filesData)
        {
            this.filesData = filesData;
        }

        public IEnumerable<Files> Files { get; set; }

        public async Task<IActionResult> OnGet()
        {
            Files = await filesData.ReturnFilesAsync();
            return Page();
        }
    }
}
