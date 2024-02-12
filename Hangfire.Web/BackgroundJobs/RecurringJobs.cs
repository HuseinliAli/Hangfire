using System.Diagnostics;

namespace Hangfire.Web.BackgroundJobs;
public class RecurringJobs
{
    public static void ReportingJob()
    {
        var id = Guid.NewGuid().ToString();
        Hangfire.RecurringJob.AddOrUpdate(id,()=>Report(),Cron.Minutely);
    }
    public static void Report()
    {
        Debug.WriteLine("Report sent with debug");
    }
}