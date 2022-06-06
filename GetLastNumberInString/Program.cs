using System;
using System.Text.RegularExpressions;
/*
 * Aliasing a class is a better idea than a static using statement.
 * In this case neither aliasing for static using statement helps,
 * it's here so those who stumble on this code can learn about it.
 */
using H = GetLastNumberInString.Classes.Helpers;

namespace GetLastNumberInString
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ResetExample();
            Console.WriteLine();
            RealisticExample();
            Console.WriteLine();
            RawExample();


            Console.ReadLine();
        }

        private static void RealisticExample()
        {
            var companyName = "SomeCompany";
            var companyIndex = 1;
            var invoiceNumber = $"{companyName}-{companyIndex}";
            Console.WriteLine(invoiceNumber);

            for (int index = 1; index < 14; index++)
            {
                invoiceNumber = PerformWork(companyName, index);
                Console.WriteLine(invoiceNumber);
            }
        }

        static string PerformWork(string companyName, int companyIndex)
        {

            var input = H.NextValue($"{companyName}-{companyIndex}");
            string[] numbers = Regex.Split(input, @"\D+");

            return int.TryParse(numbers[^1], out var value) ? 
                $"{companyName}-{value}" : 
                throw new Exception($"Failed to get index from input");
        }

        private static void RawExample()
        {
            string[] inputs = { "1 Of 1", "2 Of 4", "8 Of 10" };
            foreach (var input in inputs)
            {
                string[] numbers = Regex.Split(input, @"\D+");
                Console.WriteLine("Last Number from input \"{0}\" is: {1}", input, numbers[^1]);
            }
        }

        private static void ResetExample()
        {
            var companyName = "SomeCompany";
            var companyIndex = 1;
            var maxInvoiceNumberForYear = 5;

            var invoiceNumber = $"{companyName}-{companyIndex}";

            Console.WriteLine(invoiceNumber);

            for (int index = 0; index < 14; index++)
            {
                var input = H.NextValue(invoiceNumber);
                string[] numbers = Regex.Split(input, @"\D+");

                if (int.TryParse(numbers[^1], out var value))
                {
                    invoiceNumber = $"SomeCompany-{value}";

                    Console.WriteLine(invoiceNumber);
                    if (value >= maxInvoiceNumberForYear)
                    {
                        companyIndex = 0;
                        invoiceNumber = $"{companyName}-{companyIndex}";
                        Console.WriteLine("\tReset");
                    }
                }
            }
        }
    }
}
