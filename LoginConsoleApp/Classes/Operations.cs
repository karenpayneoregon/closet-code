using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LoginConsoleApp.Models;

namespace LoginConsoleApp.Classes
{
    public class Operations
    {
        public static string FileName => 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataLibrary.dll");

        public static bool FileCheck()
        {
            try
            {
                DeserializeUsers();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        /// <summary>
        /// Create encrypted file with users
        /// </summary>
        public static void SerializeUsers()
        {
            CryptoSerializer<User> cryptoSerializer = new(Secrets.Key);
            using FileStream fileStream = new(FileName, FileMode.OpenOrCreate);
            cryptoSerializer.Serialize(Users, fileStream);
        }

        /// <summary>
        /// Read users from encrypted file
        /// </summary>
        /// <returns></returns>
        public static List<User> DeserializeUsers()
        {
            CryptoSerializer<User> cryptoSerializer = new(Secrets.Key);
            using FileStream fileStream = new(FileName, FileMode.Open);
            return cryptoSerializer.Deserialize(fileStream);

        }

        /// <summary>
        /// Mocked users
        /// </summary>
        public static List<User> Users => new()
        {
            new() { Name = "karenpayne", Password = "@miata2019" },
            new() { Name = "bartsimpson", Password = "StupidPassword" },
            new() { Name = "betsy", Password = "@myFlag1776" },
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
