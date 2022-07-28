using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace AppSettingsConsole1
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }
    }


    public class Logging
    {
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string MicrosoftAspNetCore { get; set; }
    }

    public class Timeinterval
    {
        public string Title { get; set; }
        public int Hours { get; set; }
    }

}





