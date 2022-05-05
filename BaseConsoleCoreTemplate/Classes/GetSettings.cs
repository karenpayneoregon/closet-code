
using BaseConsoleCoreTemplate.Models;

namespace BaseConsoleCoreTemplate.Classes
{
    public class GetSettings
    {
        public static Settings ApplicationSettings() 
            => ConfigurationHelper.ApplicationSettings();
    }
}
