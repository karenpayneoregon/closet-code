using System;

namespace LoginConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            SpectreOperations.DrawHeader();
            
            var name = SpectreOperations.AskName();
            if (name.Length < 8)
            {
                SpectreOperations.GoAway();
                return;
            }
            var password = SpectreOperations.AskPassword();
            if (password.Length < 8)
            {
                SpectreOperations.GoAway();
                return;
            }


            Console.WriteLine($"{name} - {password}");
            Console.ReadLine();
        }
    }
}
