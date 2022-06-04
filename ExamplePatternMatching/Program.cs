using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamplePatternMatching
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<string> allperiods = 
                Periods().OrderBy(x => x.ToString().Contains("FY")
                    ? x.ToString()[..4]
                    : x.ToString().Substring(3, 4))
                .ThenBy(y => y switch
                {
                    { } a when y.Contains("1Q") => 1,
                    { } b when y.Contains("2Q") => 2,
                    { } c when y.Contains("1H") => 3,
                    { } d when y.Contains("3Q") => 4,
                    { } e when y.Contains("4Q") => 5,
                    { } f when y.Contains("2H") => 6,
                    { } g when y.Contains("FY") => 7,
                    _ => 8
                }).ToList();

            Console.ReadLine();
        }

        public static List<string> Periods() => new()
        {
                "1H 2015",
                "1H 2014",
                "1Q 2015",
                "2Q 2015",
                "3Q 2015",
                "4Q 2015",
                "2015 FY",
                "1Q 2014",
                "2Q 2014",
                "3Q 2014",
                "4Q 2014",
                "2014 FY",
                "2010 FY",
                "2011 FY",
                "2012 FY",
                "2013 FY",
                "2H 2015",
                "2H 2014"
           };
    }
}
