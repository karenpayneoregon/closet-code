using System;
using System.IO;
using System.Text.Json;

namespace AppSettingsConsole1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Timeinterval[] result =
                JsonSerializer.Deserialize<RootSettings>(
                    File.ReadAllText("appsettings.json")).TimeInterval;

            foreach (var timeinterval in result)
            {
                Console.WriteLine($"{timeinterval.Title} - {timeinterval.Hours}");
            }

            Console.ReadLine();
        }
    }
}
