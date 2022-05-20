using System.Diagnostics;
using System.Threading.Tasks;

namespace EnvironmentUtility.Classes
{
    public class Operations
    {
        public static async Task SetOedEnvironment(string environment)
        {

            var start = new ProcessStartInfo
            {
                FileName = "setx",
                RedirectStandardOutput = true,
                Arguments = $"OED_ENVIRONMENT \"{environment}\"",
                CreateNoWindow = true
            };

            using var process = Process.Start(start);
            using var reader = process.StandardOutput;

            process.EnableRaisingEvents = true;
            await process.WaitForExitAsync();
        }
    }
}
