using System;
using System.Linq;
using System.Runtime.CompilerServices;
using SimpleEmailValidationDataAnnotations.Classes;
using static SimpleEmailValidationDataAnnotations.Classes.Annotate;

namespace SimpleEmailValidationDataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {

            var humans = Mocked.Humans;
            
            var results = humans
                .Select(human => new EmailItem(human, ValidEmail(human.Email)))
                .ToList();

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Human.Name,-15}{result.IsValid}");
            }

            Console.ReadLine();

        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Email valid";
        }

    }
}
