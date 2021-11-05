using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class DeleteFileModel : PageModel
    {
        private readonly IFilesData filesData;

        public DeleteFileModel(IFilesData filesData)
        {
            this.filesData = filesData;
        }

        public async Task<IActionResult> OnGet(int fileId)
        {
            if (fileId <= 0)
                return RedirectToPage("./NotFound");

            return Page();
        }

        public async Task<IActionResult> OnPost(int fileId)
        {
            var file = await filesData.RemoveFileAsync(fileId);
            await filesData.CommitAsync();

            if (file == null)
                RedirectToPage("./NotFound");

            return RedirectToPage("./FilesManager");
        }
    }
}
