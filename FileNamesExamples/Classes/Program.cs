using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using FileNamesExamples.Classes;
using StringLanguageExtensions;
// ReSharper disable CheckNamespace

namespace FileNamesExamples
{
    internal partial class Program
    {
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

            Operations.GetLast();
            Operations.RemoveAllFiles();
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Filename Code sample";
        }
    }
}
