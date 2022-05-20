using System;
using System.IO;
using System.Linq;
using LoginConsoleApp.Classes;
using static LoginConsoleApp.Classes.ConsoleHelpers;

namespace LoginConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations.SerializeUsers();


            if (Operations.FileCheck())
            {
                Menu();
            }
            else
            {
                SpectreOperations.CanNotContinueHeader();
                Console.WriteLine("Contact support, press any key to terminate");
                Console.ReadLine();
            }
           
        }

        private static void Menu()
        {
            SpectreOperations.DrawHeader();

            var name = SpectreOperations.AskName();
            var password = SpectreOperations.AskPassword();

            var users = Operations.DeserializeUsers();

            var user = users.FirstOrDefault(user => user.Name == name && user.Password == password);

            Console.Clear();

            if (user is null)
            {
                SpectreOperations.DrawGoAwayHeader();
            }
            else
            {
                SpectreOperations.DrawWelcomeHeader();
            }

            ReadLineAsStringTimeout();
        }
    }
}
