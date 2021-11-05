using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class AddFileModel : PageModel
    {
        private readonly IFilesData filesData;
        private readonly IUsersData usersData;
        private readonly ISubjectData subjectData;
        private readonly IHtmlHelper htmlHelper;
        private readonly IViewRenderService viewRenderService;

        public AddFileModel(IFilesData filesData,
            IUsersData usersData,
            ISubjectData subjectData,
            IHtmlHelper htmlHelper,
            IViewRenderService viewRenderService)
        {
            this.filesData = filesData;
            this.usersData = usersData;
            this.subjectData = subjectData;
            this.htmlHelper = htmlHelper;
            this.viewRenderService = viewRenderService;
        }

        [BindProperty]
        public GenerateFileHelper GenerateFile { get; set; }
        public string FileName { get; set; }
        public IEnumerable<SelectListItem> Teachers { get; set; }
        public IEnumerable<SelectListItem> Subjects { get; set; }

        public async Task<IActionResult> OnGet()
        {
            Teachers = (await usersData.GetTeachersAsync()).Select(c => new SelectListItem
            {
                Text = c.FullName,
            }).ToList();

            Subjects = (await subjectData.GetSubjectsAsync()).Select(c => new SelectListItem
            {
                Text = c.SubjectName,
            }).ToList();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            //PageExtensions.WebPage = this.RenderViewAsync("AddFile").Result;
            return RedirectToPage("./Document", GenerateFile);
        }
    }
}
