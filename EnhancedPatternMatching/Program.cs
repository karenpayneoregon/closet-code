using System.Runtime.CompilerServices;
using EnhancedPatternMatching.LanguageExtensions;
using EnhancedPatternMatching.Models;

namespace EnhancedPatternMatching;

class Program
{
    static void Main(string[] args)
    {
        //IterateCharactersInString();
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
        Console.WriteLine($"{Howdy.TimeOfDay()}, {visitor.Greetings()} {visitor.FirstName}");
    }
        
        
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample";
    }

}