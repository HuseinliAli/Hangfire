using SendGrid;
using SendGrid.Helpers.Mail;

namespace Hangfire.Web.Services;

public class EmailSender : IEmailSender
{
    public async Task SendEmailAsync()
    {
        var apiKey = "";
        var client = new SendGridClient(apiKey);
        var from = new EmailAddress("test@example.com", "User");
        var subject = "Hangfire with SendGrid";
        var to = new EmailAddress("ali.guseynoov@gmail.com", "User");
        var plainTextContent = "is easy";
        var htmlContent = "<strong>Saaalaaam</strong>";
        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        await client.SendEmailAsync(msg);
    }
}