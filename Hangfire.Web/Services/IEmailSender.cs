namespace Hangfire.Web.Services;

public interface IEmailSender
{
    Task SendEmailAsync();
}
