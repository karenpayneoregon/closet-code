using System.Diagnostics;
using System.Text;

namespace DotNetRunTimeProcessStartApp.Classes;

internal class Operations
{
    public delegate void ProcessHandler(string sender);
    public static event ProcessHandler OnProcessingData;
    public static async Task<(bool succcess, List<Segments>, Exception localException)> Execute()
    {
        List<Segments> list = new List<Segments>();

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
                    var parts = item.Substring(0, item.IndexOf("[", StringComparison.Ordinal) - 1).Split(' ');
                    list.Add(new Segments() {Name = parts[0], Version = parts[1] });
                    builder.AppendLine("   " + item.Substring(0, item.IndexOf("[", StringComparison.Ordinal) - 1));
                    OnProcessingData?.Invoke(parts[0]);
                }
            }

            return (true, list, null)!;
        }
        catch (Exception localException)
        {

            return (false, list, localException);
        }
    }
}

internal class Segments
{
    public string Name { get; set; }
    public string Version { get; set; }
}