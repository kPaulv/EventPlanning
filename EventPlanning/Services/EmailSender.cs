using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
//using SendGrid.Helpers.Mail;
//using SendGrid;
using EventPlanning.Models.Email;
using System.Net.Mail;
using System.Net;
using System.Linq.Expressions;

namespace EventPlanning.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger _logger;

        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor,
                           ILogger<EmailSender> logger)
        {
            Options = optionsAccessor.Value;
            _logger = logger;
        }

        public AuthMessageSenderOptions Options { get; } //Set with Secret Manager.

        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            if (string.IsNullOrEmpty(Options.SendEmailKey))
            {
                throw new Exception("Null SendEmailKey");
            }
            await Execute(Options.SendEmailKey, subject, message, toEmail);
        }

        public async Task Execute(string apiKey, string subject, string message, string toEmail)
        {
            //var client = new SendGridClient(apiKey);
            //var msg = new SendGridMessage()
            //{
            //    From = new EmailAddress("Joe@contoso.com", "Password Recovery"),
            //    Subject = subject,
            //    PlainTextContent = message,
            //    HtmlContent = message
            //};
            //msg.AddTo(new EmailAddress(toEmail));

            //// Disable click tracking.
            //// See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            //msg.SetClickTracking(false, false);
            //var response = await client.SendEmailAsync(msg);

            bool response = true;

            try
            {
                MailMessage mm = new MailMessage("btc.eventplanner@gmail.com", toEmail);
                mm.Subject = subject;
                mm.Body = message;
                mm.IsBodyHtml = true;
                using (SmtpClient client = new SmtpClient())
                {
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    NetworkCredential networkCred = new NetworkCredential("btc.eventplanner@gmail.com", "kzsb elpd pqqc mqdt");
                    client.UseDefaultCredentials = false;
                    client.Credentials = networkCred;
                    client.Port = 587;
                    await Task.Run(() => { client.Send(mm); });
                }
            }
            catch (Exception ex)
            {
                response = false;
            }

            //MailMessage mail = new MailMessage();
            //mail.To.Add(toEmail);
            //mail.From = new MailAddress(_objModelMail.From);
            //mail.Subject = _objModelMail.Subject;
            //string Body = _objModelMail.Body;
            //mail.Body = Body;
            //mail.IsBodyHtml = true;
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtp.gmail.com";
            //smtp.Port = 587;
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new System.Net.NetworkCredential("username", "password"); // Enter seders User name and password       
            //smtp.EnableSsl = true;
            //smtp.Send(mail);

            _logger.LogInformation(/*response.IsSuccessStatusCode*/response
                                   ? $"Email to {toEmail} queued successfully!"
                                   : $"Failure Email to {toEmail}");
        }
    }
}
