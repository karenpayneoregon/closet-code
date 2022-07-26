using System;
using System.IO;
using System.Text.Json;
using JObjectQuestion.Classes;

namespace JObjectQuestion
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("data.json");
            RootData result = JsonSerializer.Deserialize<RootData>(json);
            var content = result.highlight.attachmentcontent;

            Console.ReadLine();
        }
    }
}
