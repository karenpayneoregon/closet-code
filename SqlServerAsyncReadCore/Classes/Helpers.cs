using System.Linq;
using Microsoft.Extensions.Configuration;

namespace SqlServerAsyncReadCore.Classes
{
    public class Helpers
    {
        protected static string ConnectionString()
        {

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var sections = configuration.GetSection("database").GetChildren().ToList();

            return
                $"Data Source={sections[1].Value};" +
                $"Initial Catalog={sections[0].Value};" +
                $"Integrated Security={sections[2].Value}";

        }
    }
}