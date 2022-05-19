using System;
using System.Runtime.CompilerServices;
using Spectre.Console;

namespace LoginConsoleApp
{
    /// <summary>
    /// Basic code taken from their GitHub repo.
    /// </summary>
    public class SpectreOperations
    {
        public static string AskName()
        {
            var name = AnsiConsole.Ask<string>("[thistle1]Login name[/]?");
            return name;
        }
        public static string AskPassword()
        {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("[thistle1]Password[/]?")
                    .PromptStyle("grey50")
                    .Secret());
        }

        public static void DrawHeader()
        {
            Render(
                new Rule()
                    .RuleStyle(Style.Parse("green"))
                    .HeavyBorder()
                    .LeftAligned());

            AnsiConsole.Write(new FigletText("Enter credentials").Centered().Color(Color.Green));

            Render(
                new Rule()
                    .RuleStyle(Style.Parse("green"))
                    .HeavyBorder()
                    .LeftAligned());
        }
        public static void DrawWelcomeHeader()
        {
            Render(
                new Rule()
                    .RuleStyle(Style.Parse("yellow"))
                    .HeavyBorder()
                    .LeftAligned());

            AnsiConsole.Write(new FigletText("Welcome").Centered().Color(Color.Yellow));

            Render(
                new Rule()
                    .RuleStyle(Style.Parse("yellow"))
                    .HeavyBorder()
                    .LeftAligned());
        }
        public static void DrawGowayHeader()
        {
            Render(
                new Rule()
                    .RuleStyle(Style.Parse("red"))
                    .HeavyBorder()
                    .LeftAligned());

            AnsiConsole.Write(new FigletText("Guards, an intruder ").Centered().Color(Color.Yellow));

            Render(
                new Rule()
                    .RuleStyle(Style.Parse("red"))
                    .HeavyBorder()
                    .LeftAligned());
        }
        public static void Render(Rule rule)
        {
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Spectre.Console login";
        }
    }
}