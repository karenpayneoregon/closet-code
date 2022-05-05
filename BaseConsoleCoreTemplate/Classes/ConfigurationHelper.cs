using BaseConsoleCoreTemplate.Models;
using ConfigurationLibrary.Classes;
using Microsoft.Extensions.Configuration;

namespace BaseConsoleCoreTemplate.Classes
{
    public class ConfigurationHelper
    {
        public static Settings ApplicationSettings() => 
            new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Settings")
                .Get<Settings>();
    }
}
