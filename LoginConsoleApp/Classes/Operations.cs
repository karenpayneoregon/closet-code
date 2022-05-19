using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using LoginConsoleApp.Models;

namespace LoginConsoleApp.Classes
{
    public class Operations
    {
        public static string _fileName => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataLibrary.dll");

        /// <summary>
        /// Create encrypted file with users
        /// </summary>
        public static void SerializeUsers()
        {
            CryptoSerializer<User> cryptoSerializer = new(Secrets.Key);
            
            using FileStream fileStream = new(_fileName, FileMode.OpenOrCreate);
            cryptoSerializer.Serialize(Users, fileStream);

        }

        /// <summary>
        /// Read users from encrypted file
        /// </summary>
        /// <returns></returns>
        public static List<User> DeserializeUsers()
        {
            CryptoSerializer<User> cryptoSerializer = new CryptoSerializer<User>(Secrets.Key);
            using FileStream fileStream = new FileStream(_fileName, FileMode.Open);
            return cryptoSerializer.Deserialize(fileStream);
        }

        /// <summary>
        /// Mocked users
        /// </summary>
        public static List<User> Users => new()
        {
            new() { Name = "karenpayne", Password = "@miata2019" },
            new() { Name = "bartsimpson", Password = "StupidPassword" },
            new() { Name = "betsy", Password = "myFlag" },
        };

        public static void CreateReadUsers()
        {
            SerializeUsers();
            var users = DeserializeUsers();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} {user.Password}");
            }
        }
    }
}
