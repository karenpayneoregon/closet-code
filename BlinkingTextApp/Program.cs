namespace BlinkingTextApp
{
    internal partial class Program
    {
        static async Task Main(string[] args)
        {

            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = c;
                Console.WriteLine("!Hello World!");
                await Task.Delay(100);
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}