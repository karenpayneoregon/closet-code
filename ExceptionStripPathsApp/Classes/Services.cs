using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ExceptionStripPathsApp.Classes
{
    public class Services
    {
        private readonly ServiceProvider _provider;
        private readonly ILogger<Services> _logger;

        public Services()
        {

        }
        public Services(ServiceProvider provider)
        {
            _provider = provider;
            _logger = provider.GetService<ILoggerFactory>().CreateLogger<Services>();
        }

        public void ReadFile(string fileName)
        {
            _logger.LogInformation($"Starting work in {nameof(ReadFile)}");
            
            try
            {
                File.ReadAllText(fileName);
            }
            catch (Exception e)
            {
                EventId eventId = new(11, "KP2");

                _logger.LogCritical(eventId, e.ToString());
            }

        }

        public void ConvertDate(string sender)
        {
            _logger.LogInformation($"Starting work in {nameof(ConvertDate)}");

            try
            {
                _ = Convert.ToDateTime(sender);
            }
            catch (Exception e)
            {
                EventId eventId = new(11, "KP2");

                _logger.LogCritical(eventId, e.ToString());
            }
        }
    }
}
