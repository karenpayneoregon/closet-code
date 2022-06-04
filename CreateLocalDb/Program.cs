using System;
using CreateLocalDb.Classes;

namespace CreateLocalDb
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //DataOperations.Create();
            DataOperations.Open();
            Console.ReadLine();

        }
    }
}
