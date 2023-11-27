using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace DemoAppDotNet7.Models
{
    public class CustomEmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fEmail = "zaidalbake2@gmail.com";
            var fPassword = "2r2c829jg_zaid2";

            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(fEmail);

            mailMessage.Subject = subject;
            mailMessage.Body = $"<html><body>{htmlMessage}</body></html>";
            mailMessage.IsBodyHtml = true;

            mailMessage.To.Add(new MailAddress(email));

            var smtpClient = new SmtpClient("smtp-mail.outlook.com")
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fEmail, fPassword),
                Port = 587,
            };

            smtpClient.Send(mailMessage);
        }
    }
}
