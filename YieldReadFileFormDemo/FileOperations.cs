using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace YieldReadFileFormDemo
{
    public class FileOperations
    {
        public static IEnumerable<string> ReadYield(string fileName)
        {

            foreach (var line in File.ReadAllLines(fileName))
            {
                yield return line;
            }

        }

        public static List<string> Read(string fileName) 
            => File.ReadAllLines(fileName).ToList();
    }
}