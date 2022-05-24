using System.Collections.Generic;
using System.IO;
using JsonNetNativeJsonDemo1.Models;
using Newtonsoft.Json;

namespace JsonNetNativeJsonDemo1.Classes
{
    class NewtonDataOperations
    {
        private static string _fileName = "Data.json";
        public static void Create()
        {
            List<Day30Model> list = new()
            {
                new Day30Model() {FileName = "First"},
                new Day30Model() {FileName = "Second"},
                new Day30Model() {FileName = "Third"},
            };

            File.WriteAllText(_fileName, JsonConvert.SerializeObject(list));
        }

        public static List<Day30Model> List() 
            => JsonConvert.DeserializeObject<List<Day30Model>>(
                File.ReadAllText(_fileName));
    }
}