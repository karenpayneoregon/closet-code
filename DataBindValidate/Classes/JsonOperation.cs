using System.IO;
using DataBindValidate.Models;
using Newtonsoft.Json;

namespace DataBindValidate.Classes
{
    public class JsonOperation
    {
        public static void Serialize(Usuarios usuarios)
        {
            File.WriteAllText("SomeFile.json", JsonConvert.SerializeObject(usuarios));
        }
    }
}
