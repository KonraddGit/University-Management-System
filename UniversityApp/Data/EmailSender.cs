using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System.Threading.Tasks;
using UniversityApp.Data.Models.Email;

namespace UniversityApp.Data.Models
{
    [Authorize(Roles = "office")]
    public class EmailSender : IEmailSender
    {
        public EmailSenderOptions Options { get; }
        public EmailSender(IOptions<EmailSenderOptions> options)
        {
            Options = options.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
            => await Execute(email, subject, htmlMessage);

        private async Task Execute(string receiversEmail, string subject, string htmlMessage)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(Options.Sender_Email);

            if (!string.IsNullOrEmpty(Options.Sender_Name))
                email.Sender.Name = Options.Sender_Name;

            email.From.Add(email.Sender);
            email.To.Add(MailboxAddress.Parse(receiversEmail));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = htmlMessage };

            using var stmp = new SmtpClient();

            await stmp.ConnectAsync(Options.Host_Address,
                                    Options.Host_Port,
                                    Options.Host_SecureSocketOptions);

            await stmp.AuthenticateAsync(Options.Host_Username,
                                         Options.Host_Password);

            await stmp.SendAsync(email);
            await stmp.DisconnectAsync(true);
        }
    }
}
