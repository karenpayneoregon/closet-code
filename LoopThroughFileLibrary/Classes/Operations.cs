using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoopThroughFileLibrary.Classes
{
    public class Operations
    {
        /// <summary>
        /// Get totals where each line is a decimal
        /// </summary>
        /// <param name="fileName">File to read from</param>
        /// <returns>
        /// Total from iterating lines
        /// List of lines which could not be converted to decimal
        /// Exception if a runtime exception is thrown
        /// </returns>
        public static (decimal total, List<int> linesBad, Exception exception) GetTotals(string fileName)
        {
            List<int> badLines = new();
            decimal total = 0;

            try
            {
                using (StreamReader reader = new(fileName))
                {
                    int index = 0;
                    while (!reader.EndOfStream)
                    {
                        if (decimal.TryParse(reader.ReadLine(), out var result))
                        {
                            total += result;
                        }
                        else
                        {
                            badLines.Add(index);
                        }

                        index++;
                    }
                }

                return (total, badLines, null);

            }
            catch (Exception ex)
            {
                return (total, badLines, ex);
            }
        }

        private static void ReadFile1(string fileName)
        {
            int counter = 0;

            using StreamReader reader = new(fileName);

            while ((reader.ReadLine()) is { } readLine)
            {
                Console.WriteLine(readLine);
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
