using Hangfire.Web.Services;

namespace Hangfire.Web.BackgroundJobs
{
    public class FireAndForgetJobs
    {
        public static void EmailSendToUserJob()
        {
            BackgroundJob.Enqueue<IEmailSender>(x => x.SendEmailAsync());
        }
    }
}
