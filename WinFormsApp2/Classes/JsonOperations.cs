using System.Text.Json;
using System.Text.Json.Serialization;
using WinFormsApp2.Models;

namespace WinFormsApp2.Classes
{
    public class JsonOperations
    {
        private static string _fileName = "books.json";

        public static void CreateFile()
        {
            File.WriteAllText(_fileName, 
                JsonSerializer.Serialize(Books, 
                    new JsonSerializerOptions { WriteIndented = true, }));
        }


        public static List<Book> BookList()
        {
            JsonSerializerOptions jsonOptions = new()
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            return JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(_fileName), jsonOptions);
        }

        private static List<Book> Books { get; } =
        [
            new Book { Id = 1, Title = "Learn EF Core", Price = 19.0000M },
            new Book { Id = 2, Title = "C# Basics", Price = 18.0000M },
            new Book { Id = 3, Title = "ASP.NET Core advance", Price = 30.0000M },
            new Book { Id = 4, Title = "VB.NET To C#", Price = 9.0000M, }
        ];
    }
}
