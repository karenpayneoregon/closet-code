using System;
using System.Linq;
using LoginConsoleApp.Classes;

namespace LoginConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
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
                SpectreOperations.DrawGowayHeader();
            }
            else
            {
                SpectreOperations.DrawWelcomeHeader();
            }

            Console.ReadLine();
        }
    }
}
