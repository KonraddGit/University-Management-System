using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "admin")]
    public class LoggerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
