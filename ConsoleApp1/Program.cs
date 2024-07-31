namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }


}


    public static class Helpers
    {
        public static bool IsWeekday1(this DateTime current) =>
            current.DayOfWeek switch
            {
                DayOfWeek.Saturday => false,
                DayOfWeek.Sunday => false,
                _ => true
            };

        public static bool IsWeekday2(this DateTime current)
        {
            switch (current.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return false;
                default:
                    return true;
            }
        }
        public static bool IsWeekday3(this DateTime current) 
            => current.DayOfWeek is not (DayOfWeek.Saturday or DayOfWeek.Sunday);

        public static bool IsWeekday4(this DateTime current)
        {
            if (current.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
