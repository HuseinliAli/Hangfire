namespace Hangfire.Web.BackgroundJobs;

using System.ComponentModel;
using System.Drawing;
public class DelayedJobs
{
    public static string AddMarkJob(string fileName,string markText)
    {
        return Hangfire.BackgroundJob.Schedule(
            ()=>ApplyMark(fileName,markText),TimeSpan.FromSeconds(30));;
    }

    public static void ApplyMark(string fileName, string markText)
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imgs", fileName);
        using (var bitmap = Bitmap.FromFile(path))
        {
            using(var tempBitmap = new Bitmap(bitmap.Width, bitmap.Height))
            {
                using (var graphic = Graphics.FromImage(tempBitmap))
                {
                    graphic.DrawImage(bitmap, 0, 0);
                    var font = new Font(FontFamily.GenericSansSerif, 5, FontStyle.Bold);

                    var color = Color.FromArgb(255, 0, 0);

                    var brush = new SolidBrush(color);

                    var point = new Point(20, bitmap.Height-20);

                    graphic.DrawString(markText, font, brush, point);

                    tempBitmap.Save(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imgs/markeds", fileName));
                }
            }
        }
    }
}

