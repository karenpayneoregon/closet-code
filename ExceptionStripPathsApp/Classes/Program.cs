using System;
using System.Runtime.CompilerServices;
using ExceptionStripPathsApp.Classes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace ExceptionStripPathsApp
{
    public partial class Program
    {
        #region Logging configuration and private variables
        private static ServiceProvider serviceProvider;
        private static ILogger<Program> _logger;
        #endregion

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);

            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;




        }
        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            //Console.WriteLine(((Exception)e.ExceptionObject).ToString());

            EventId eventId = new(11, "KP2");

            _logger.LogCritical(eventId, ((Exception)e.ExceptionObject).ToString());

            _logger.LogInformation("Exit with unhandled error");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }

    public class Logging
    {
        public static (ServiceProvider, ILogger<Program>) Configuration()
        {

            var serviceProvider = new ServiceCollection()
                .AddLogging(builder =>
                {
                    builder.SetMinimumLevel(LogLevel.Trace);
                    builder.AddNLog(new NLogProviderOptions
                    {
                        CaptureMessageTemplates = true,
                        CaptureMessageProperties = true
                    });
                })
                .BuildServiceProvider();


            var _logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Program>();

            _logger.LogInformation("Starting application...");

            return (serviceProvider, _logger);

        }
    }
}





