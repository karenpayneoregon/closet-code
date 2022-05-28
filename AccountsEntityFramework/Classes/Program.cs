using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AccountsEntityFramework.Context;
using AccountsEntityFramework.Models;
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
                UserName = "karenpayne",
                Active = true,
                CreatedDate = new DateTime(2022, 5, 2),
                Email = "payne@gmail.com",
                Roles = new[]
                {
                    "User", 
                    "Admin", 
                    "Owner"
                }
            };

            return JsonConvert.DeserializeObject<Account>(
                JsonConvert.SerializeObject(account, Formatting.Indented));
        }

        private static void ViewAccounts()
        {
            using var context = new Context();
            var accountList = context.Account.ToList();

            foreach (var account in accountList)
            {
                Console.WriteLine($"Id: {account.Id,-5}{account.UserName}");
                foreach (var role in account.Roles)
                {
                    Console.WriteLine($"{role,14}");
                }

                Console.WriteLine();
            }

        }
        private static void NewAccountRecord()
        {
            using var context = new Context();

            var account = IncomingAccount();
            context.Add(account);
            context.SaveChanges();
            Console.WriteLine($"Id for new account {account.Id}");
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }


    }
}





