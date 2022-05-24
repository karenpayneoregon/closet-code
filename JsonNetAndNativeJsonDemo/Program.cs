using System;
using JsonNetNativeJsonDemo1.Classes;

namespace JsonNetNativeJsonDemo1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            NativeDataOperations.Create();
            var list = NativeDataOperations.List();
            foreach (var model in list)
            {
                Console.WriteLine(model.FileName);
            }
            Console.ReadLine();
        }
    }
}
