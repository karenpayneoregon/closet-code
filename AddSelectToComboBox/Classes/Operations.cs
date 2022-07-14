using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AddSelectToComboBox.Models;

namespace AddSelectToComboBox.Classes
{
    public class Operations
    {
        public static List<MonthItem> Months()
        {
            List<MonthItem> list = new List<MonthItem>() { new MonthItem() { Index = -1, Name = "Select" } };
            list.AddRange(MonthList.Select((name, index) => new MonthItem() { Index = index + 1, Name = name }));

            return list;
        }

        public static List<string> MonthList
            => Enumerable.Range(1, 12).Select((index) =>
                DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList();

    }
}