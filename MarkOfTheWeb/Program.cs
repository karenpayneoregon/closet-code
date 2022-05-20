using System;
using System.Diagnostics;
using CommandLine.Text;
using MarkOfTheWeb.Classes;

namespace MarkOfTheWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = new HeadingInfo(programName: "Mark of the web remover", version: "1.0.0");
            Debug.WriteLine(title);
            CommandLineHelp.ParseArguments(args);
        }
    }
}
