using System;
using CreateLocalDb.Classes;

namespace CreateLocalDb
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // run once then comment out
            DataOperations.Create();
            DataOperations.Open();
            Console.ReadLine();

        }
    }
}
