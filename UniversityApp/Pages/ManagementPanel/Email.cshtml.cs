using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Models.Email;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize]
    public class EmailModel : PageModel
    {
        public IEmailSender EmailSender { get; set; }
        public EmailModel(IEmailSender emailSender)
        {
            EmailSender = emailSender;
        }

        [BindProperty]
        [Display(Name = "Odbiorca")]
            public string MailReceiver { get; set; }

        [BindProperty]
        [Display(Name = "Temat")]
        public string MailSubject { get; set; }

        [BindProperty]
        [Display(Name = "Treœæ")]
        public string MailBody { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await EmailSender.SendEmailAsync(MailReceiver, MailSubject, MailBody);
            return Page();
        }
    }
}
