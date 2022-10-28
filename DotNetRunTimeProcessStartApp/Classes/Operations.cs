using System.Diagnostics;
using System.Text;

namespace DotNetRunTimeProcessStartApp.Classes;

internal class Operations
{
    public static async Task<(bool succcess, string, Exception localException)> Execute()
    {
        try
        {

            var start = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                RedirectStandardOutput = true,
                Arguments = "dotnet --list-runtimes",
                CreateNoWindow = true
            };

            using var process = Process.Start(start);
            using var reader = process!.StandardOutput;

            process.EnableRaisingEvents = true;

            var lineData = await reader.ReadToEndAsync();
            var items = lineData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder builder = new();
            foreach (var item in items)
            {
                if (item.Contains("["))
                {
                    builder.AppendLine("   " + item.Substring(0, item.IndexOf("[", StringComparison.Ordinal) - 1));
                }
            }

            return (true, builder.ToString(), null)!;
        }
        catch (Exception localException)
        {

            return (false, "Failed", localException);
        }
    }
}