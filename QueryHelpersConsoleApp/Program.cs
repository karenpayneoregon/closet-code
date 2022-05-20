using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.WebUtilities;

namespace QueryHelpersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryHelperDemo();
            AlreadyCompleted();

            Console.ReadLine();

        }
        private static void QueryHelperDemo()
        {
            Console.WriteLine(nameof(QueryHelperDemo));

            Dictionary<string, string> queryArguments = new()
            {
                { "versionCode", "RTUK8L1" },
                { "language", "2" }
            };

            var results = QueryHelpers.AddQueryString(
                "api/GetCharacteristicsBulk", 
                queryArguments);

            Console.WriteLine(results);
        }
        private static void AlreadyCompleted()
        {
            Console.WriteLine(nameof(AlreadyCompleted));

            string language = "S";

            Dictionary<string, string> queryArguments = new()
            {
                { "transId", "64440952" },
                { "lang", "E" }
            };

            if (language == "S")
            {
                queryArguments["lang"] = language;
            }


            var results = QueryHelpers.AddQueryString(
                "advisoryNotice.kp", 
                queryArguments);

            Console.WriteLine(results);
            Console.WriteLine("");


        }

    }
}
