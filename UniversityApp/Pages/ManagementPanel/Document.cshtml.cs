using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Models;
using UniversityApp.Data.Helpers;
using Microsoft.AspNetCore.Authorization;
using UniversityApp.Data.Interfaces;
using System.Threading.Tasks;
using System;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class DocumentModel : PageModel
    {
        private readonly IFilesData filesData;

        public DocumentModel(IFilesData filesData)
        {
            this.filesData = filesData;
        }

        [BindProperty]
        public string PageAsString { get; set; }
        public GenerateFileHelper GenerateFile { get; set; }
        public string JsonString { get; set; }
        public async Task<IActionResult> OnGetAsync(GenerateFileHelper generateFile)
        {
            GenerateFile = generateFile;
            JsonString = GenerateFile.ToJson();

            var file = new Files
            {
                Date = DateTime.Now,
                AcademicYear = generateFile.AcademicYear,
                Content = JsonString
            };

            await filesData.AddFileAsync(file);
            await filesData.CommitAsync();

            return Page();
        }
    }
}
