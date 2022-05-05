using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace BaseConsoleCoreTemplate.Classes
{
    public class DataOperations
    {
        public static async Task DemoTask()
        {
            await using var cn = new SqlConnection(ConnectionString());
            await using var cmd = new SqlCommand { Connection = cn };

            /*
             * Fill in the rest
             */
        }
    }
}
