using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonNetNativeJsonDemo1.Models;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace JsonNetBlooper.Classes
{
    class NativeDataOperations
    {
        private static string _fileName = "Data.json";
        public static void Create()
        {
            List<Day30Model> list = new()
            {
                new Day30Model() { FileName = "First" },
                new Day30Model() { FileName = "Second" },
                new Day30Model() { FileName = "Third" },
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(_fileName, JsonSerializer.Serialize(list, options));
        }

        public static List<Day30Model> List()
            => JsonSerializer.Deserialize<List<Day30Model>>(
                File.ReadAllText(_fileName));
    }
}
