using System;
using System.Runtime.CompilerServices;
using EnhancedPatternMatching.LanguageExtensions;

namespace EnhancedPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            IterateCharactersInString();
            WelcomePerson();

            Console.ReadLine();
        }

        private static void IterateCharactersInString()
        {
            var value = "Karen Payne is At the zoo";

            foreach (var character in value)
            {
                Console.WriteLine($"{character} is a character: {character.IsLetterOrSeparator()}");
            }
        }

        private static void WelcomePerson()
        {
            var visitor = new Visitor() { FirstName = "Karen", Country = "Mexico" };
            Console.WriteLine($"{Greetings(visitor)} {visitor.FirstName}");
        }

        static string Greetings(Visitor visitor) => visitor switch
            {
                { Country: "USA" } => "Hello",
                { Country: "Germany" } => "hallo",
                { Country: "Mexico" } => "Hola",
                _ => "Whazzup"
            };


        
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }

    }

    public class Visitor
    {
        public string FirstName { get; set; }
        public string Country { get; set; }
    }
}
