using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.DateTime;

namespace CreateRandomListConsoleApp.Classes
{
    class MockedData
    {
        public static List<int> IntegerList() => 
            Enumerable.Range(1, 11).ToList();

        public static List<DateTime> DateTimeList =>
            Enumerable.Range(2000, 11).Select(year => 
                new DateTime(year,Now.Month,Now.Day)).ToList();
    }
}
