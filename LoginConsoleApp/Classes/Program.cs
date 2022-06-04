﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginConsoleApp.Classes;
using static LoginConsoleApp.Classes.ConsoleHelpers;

// ReSharper disable once CheckNamespace
namespace LoginConsoleApp
{
    partial class Program
    {
        private static void Menu()
        {
            SpectreOperations.DrawHeader();

            var name = SpectreOperations.AskLoginName();
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
