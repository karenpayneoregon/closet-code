using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeWithNoForesight_grouping.Classes
{
    class Operations
    {
        private static string _fileName = "books.json";

        public static void CreateFile()
        {
            File.WriteAllText(_fileName, 
                JsonSerializer.Serialize(Books, 
                    new JsonSerializerOptions { WriteIndented = true, }));
        }


        public static List<Book> BookList()
            => JsonSerializer.Deserialize<List<Book>>(
                File.ReadAllText(_fileName));

        private static List<Book> Books { get; } = new()
        {
            new Book { Id = 1, Name = "Learn EF Core", Price = 19.0000M },
            new Book { Id = 2, Name = "C# Basics", Price = 18.0000M },
            new Book { Id = 3, Name = "ASP.NET Core advance", Price = 30.0000M },
            new Book { Id = 4, Name = "VB.NET To C#", Price = 9.0000M, },
        };
    }
}
