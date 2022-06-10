using ConfigurationLibrary.Classes;
using DependencyInjectionForms1.Interfaces;

namespace DependencyInjectionForms1.Services
{
    public class DataConnectionService : IDataConnection
    {
        public string GetConnection() => ConfigurationHelper.ConnectionString();
    }
}