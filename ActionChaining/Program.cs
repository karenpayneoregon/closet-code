using System;
using static System.DateTime;

namespace ActionChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Action greetings = () => Console.Write($"{TimeOfDay()} ");
            greetings += GetUserName;
            greetings += () => Console.Write(" !!!");

            greetings();

            Console.ReadLine();
        }

        static void GetUserName()
        {
            Console.Write(Environment.UserName);
        }

        public static string TimeOfDay() =>
            Now.Hour switch
            {
                <= 12 => "Good Morning",
                <= 16 => "Good Afternoon",
                <= 20 => "Good Evening",
                _ => "Good Night"
            };
    }
}
