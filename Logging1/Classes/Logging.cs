using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLogForms1.Interfaces;

namespace NLogForms1.Classes
{
    public class Logging
    {
        public static (ServiceProvider, ILogger<Form1>) Configuration()
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICommonService, FooService>()
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


            var _logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Form1>();

            _logger.LogInformation("Starting application...");

            return (serviceProvider, _logger);

        }
    }
}
