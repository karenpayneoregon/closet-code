using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TransformingConsoleCodeSample.Classes;
using TransformingConsoleCodeSample.Classes.Transformers;
using TransformingConsoleCodeSample.LanguageExtensions;


// ReSharper disable once CheckNamespace
namespace TransformingConsoleCodeSample
{
    partial class Program
    {

        private static void StringToIntPersevere()
        {
            Console.WriteLine(nameof(StringToIntPersevere));
            var transformer = new StringToIntTransformer();
            string[] input = Enumerable.Range(1, 10).Select(value => value.ToString()).ToArray();
            
            input[0] = "";
            input[5] = "12.4";

            var result = input.Transform(transformer);
            
            Console.WriteLine($" In: {string.Join(", ", input)}");
            Console.WriteLine($"Out: {string.Join(", ", result)}");

            Console.ReadLine();
        }

        private static void SplitCamelCase()
        {
            
            Console.WriteLine(nameof(SplitCamelCase));

            var transformer = new CamelCaseTransformer();
            string[] input = { "FirstName", "LastName", "JoinDate" };
            var result = input.Transform(transformer);
            Console.WriteLine($" In: {string.Join(", ", input)}");
            Console.WriteLine($"Out: {string.Join(", ", result)}");
            Console.ReadLine();
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }
    }
}





