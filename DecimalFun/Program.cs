using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DecimalFun;

class Program
{
    static void Main(string[] args)
    {
        List<int> grades = new List<int>() {99,85, 70, 65, 55};
        
        foreach (var item in grades)
        {
            var (grade, remarks) = item.GetGradeWithRemarks();
            Console.WriteLine($"{item, -3}{grade,-3}{remarks}");
        }
        

        //Console.WriteLine(value1.GetRank());
        Console.ReadLine();
        return;
        decimal value = 22_111.1111m;
        Console.WriteLine($"{value} has {value.CountDecimalPlaces()} places to the right");

        value = 111m;
        Console.WriteLine($"{value} has {value.CountDecimalPlaces()} places to the right");

        decimal fraction = 2.78m;

        Console.WriteLine($"{fraction.GetFraction()} from {fraction}");


        Console.ReadLine();
    }

    private static string Grade(int score) => score switch
    {
        > 90 => "A",
        >= 80 and < 90 => "B",
        >= 70 and < 80 => "C",
        >= 60 and < 70 => "D",
        >= 50 and < 60 => "F",
        _ => throw new ArgumentOutOfRangeException(
            nameof(score), score, "Unexpected value")
    };

    private string ExperienceLevel(int yearsOfExperience) => yearsOfExperience switch
    {
        0 => "Inexperienced",
        > 0 and <= 2 => "Beginner",
        > 2 and <= 5 => "Intermediate",
        _ => "Expert"
    };



    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample - Fun with decimals";
    }
}

public static class Example
{


}

public static class HelperExtensions
{
    public static string GetGrade(int score) => score switch
    {
        >= 90 => "A",
        >= 80 and < 90 => "B",
        >= 70 and < 80 => "C",
        >= 60 and < 70 => "D",
        >= 50 and < 60 => "F",
        _ => throw new ArgumentOutOfRangeException(
            nameof(score), score, "Unexpected value")
    };
    public static string GetRank(this int sender) => sender switch
    {
        > 70 => "7",
        > 50 => "5",
        > 30 => "3",
        > 20 => "2",
        _ => throw new ArgumentOutOfRangeException(nameof(sender), sender, "Unexpected value")
    };

    public static string GetExperienceLevel(this int yearsOfExperience) => yearsOfExperience switch
    {
        0 => "Inexperienced",
        > 0 and <= 2 => "Beginner",
        > 2 and <= 5 => "Intermediate",
        _ => "Expert"
    };
}