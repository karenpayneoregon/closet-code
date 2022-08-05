using System;

namespace ExceptionStripPathsApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Convert.ToDateTime(@"Ooops");
            
        }
    }
}
