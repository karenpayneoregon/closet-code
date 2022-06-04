using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using GenericExtensionsForFormControls.Models;

namespace GenericExtensionsForFormControls.Classes
{
    public class JsonOperations
    {
        public static List<Product> Products()
            => JsonSerializer.Deserialize<List<Product>>(
                File.ReadAllText("Products.json"));

        public static List<Category> Categories()
            => JsonSerializer.Deserialize<List<Category>>(
                File.ReadAllText("Categories.json"));
    }
}
