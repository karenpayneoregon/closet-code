using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace RemoveMarkOfWeb.Classes
{
    class Utilities
    {
        public static async Task UnblockFiles(string folderName)
        {
            if (!Directory.Exists(folderName))
            {
                return ;
            }

            var start = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                RedirectStandardOutput = true,
                Arguments = $"Get-ChildItem -Path '{folderName}' -Recurse | Unblock-File",
                CreateNoWindow = true, 
                UseShellExecute = false
            };

            using (var process = Process.Start(start))
            {
                await process.WaitForExitAsync();
            }

        }
    }
}