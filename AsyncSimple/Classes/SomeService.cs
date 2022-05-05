using System.Diagnostics;
using System.Threading;

namespace AsyncSimple.Classes
{
    public class SomeService
    {
        public int Calculate()
        {
            static void BusyWait(int milliseconds)
            {
                var sw = Stopwatch.StartNew();

                while (sw.ElapsedMilliseconds < milliseconds)
                {
                    Thread.SpinWait(1000);
                }
            }
            // Tons of work to do in here!
            for (int index = 0; index < 10; index++)
            {
                BusyWait(1000);
            }

            return 42;
        }
    }
}