using System.Diagnostics;

namespace Hangfire.Web.BackgroundJobs;
public class ContinuationJobs
{
    public static void WriteMarkStatus(string id, string fileName)
    {
        Hangfire.BackgroundJob.ContinueJobWith(id, () => Debug.WriteLine($"{fileName} is marked"));
    }
}

