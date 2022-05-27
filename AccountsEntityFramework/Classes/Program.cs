using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AccountsHasConversion.Models;
using Newtonsoft.Json;


// ReSharper disable once CheckNamespace
namespace AccountsHasConversion
{
    partial class Program
    {
        /// <summary>
        /// Mock-up an <see cref="Account"/>
        /// </summary>
        static Account IncomingAccount()
        {
            Account account = new()
            {
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20),
                Email = "james@example.com",
                Roles = new[] { "User", "Admin" }
            };

            return JsonConvert.DeserializeObject<Account>(
                JsonConvert.SerializeObject(account, Formatting.Indented));
        }

        private static void ViewAccounts()
        {
            using var context = new Context.Context();
            var accountList = context.Account.ToList();

            foreach (var account in accountList)
            {
                Console.WriteLine($"Id: {account.Id}");
                foreach (var role in account.Roles)
                {
                    Console.WriteLine($"\t{role}");
                }

                Console.WriteLine();
            }

        }
        private static void NewAccountRecord()
        {
            using var context = new Context.Context();

            var account = IncomingAccount();
            context.Add(account);
            context.SaveChanges();

            Console.WriteLine($"Id for new account {account.Id}");


            var accountList = context.Account.ToList();

            foreach (var item in accountList)
            {
                Console.WriteLine($"Id: {item.Id}");
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($"\t{role}");
                }

                Console.WriteLine();
            }
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }


    }
}





