using System;
using System.Drawing;
using ExceptionStripPathsApp.Classes;

namespace ExceptionStripPathsApp
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var (provider, logger) = Logging.Configuration();
            serviceProvider = provider;
            _logger = logger;

            var services = new Services(serviceProvider);
            
            services.ReadFile("NonExistingFile.csv");
            services.ConvertDate(@"Ooops");

            Convert.ToDateTime(@"Ooops");


            Console.ReadLine();
        }
    }
}
