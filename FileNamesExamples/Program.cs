using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using FileNamesExamples.Classes;
using StringLanguageExtensions;

namespace FileNamesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();

            Console.ReadLine();
        }

        private static void Run()
        {
            for (int index = 0; index < 4; index++)
            {
                File.WriteAllText(Operations.NextFileName(), "");
            }

            Directory.GetFiles(".", "*.txt")
                .ToList()
                .Select(item => new { FileName = Path.GetFileName(item), Index = item.SqueezeInt() })
                .OrderBy(anonymous => anonymous.Index)
                .ToList()
                .ForEach(x => Console.WriteLine(x.FileName));
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Filename Code sample";
        }

    }
}
