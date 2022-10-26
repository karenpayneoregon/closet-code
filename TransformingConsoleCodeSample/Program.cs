using System.Linq;
using System;
using TransformingConsoleCodeSample.Classes.Transformers;
using TransformingConsoleCodeSample.LanguageExtensions;


namespace TransformingConsoleCodeSample
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var transformer = new StringToIntTransformer();
            string[] input = Enumerable.Range(1, 10).Select(value => value.ToString()).ToArray();

            input[0] = "";
            input[5] = "12.4";

            var result = input.Transform(transformer);
            input = input.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            Console.WriteLine($" In: {string.Join(", ", input)}");
            Console.WriteLine($"Out: {string.Join(", ", result)}");
            Console.ReadLine();
        }
    }
}
