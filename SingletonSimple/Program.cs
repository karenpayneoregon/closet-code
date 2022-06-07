using System;
using System.Threading.Tasks;
using SingletonSimple.Classes;

namespace SingletonSimple
{
    partial class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.DateTime);
            await Task.Delay(1000);
            Console.WriteLine(Singleton.Instance.DateTime);
            Singleton.Instance.SomeStringValue = nameof(Main);
            Peek();
            Console.WriteLine(Singleton.Instance.SomeStringValue);
            Console.ReadLine();
        }

        private static void Peek()
        {
            Console.WriteLine(Singleton.Instance.SomeStringValue);
            Singleton.Instance.SomeStringValue = nameof(Peek);
        }
    }
}
