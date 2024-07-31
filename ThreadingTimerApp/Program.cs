using ThreadingTimerApp.Classes;

namespace ThreadingTimerApp
{
    internal partial class Program
    {
        static Task Main(string[] args)
        {
            
            TimerHelper.Message += OnMessageReceived;
            TimerHelper.Interval = 1000;
            TimerHelper.Start(FormWork);
            AnsiConsole.MarkupLine("[yellow]Started, press ENTER to stop[/]");
            Console.ReadLine();
            TimerHelper.Stop();
            AnsiConsole.MarkupLine("[yellow]Stopped, press ENTER to exit[/]");
            Console.ReadLine();
            return Task.CompletedTask;
        }


        private static void OnMessageReceived(string message)
        {
            AnsiConsole.MarkupLine($"[white on blue]{message}[/]");
        }
    }
}