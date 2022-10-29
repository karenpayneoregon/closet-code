using DotNetRunTimeProcessStartApp.Classes;

namespace DotNetRunTimeProcessStartApp;

internal partial class Program
{
    static async Task Main(string[] args)
    {
        Operations.OnProcessingData += OperationsOnOnProcessingData;
        var (success, segments, localException) = await Operations.Execute();
        if (success)
        {
            Table table = CreateTable();
            foreach (var segment in segments)
            {
                table.AddRow(segment.Name, segment.Version);
            }

            AnsiConsole.Write(table);
        }
        else if (localException is not null)
        {
            Console.WriteLine(localException.Message);
        }
        Console.ReadLine();
    }

    private static void OperationsOnOnProcessingData(string sender)
    {
        
    }
}