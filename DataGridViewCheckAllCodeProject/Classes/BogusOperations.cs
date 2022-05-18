using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace SelectAll.Classes
{
    public class BogusOperations
    {
        public static List<Item> Items(int count = 10)
        {
            var fake = new Faker<Item>()
                .RuleFor(item => item.IsChecked, f => false)
                .RuleFor(item => item.RandomNo, f => f.Random.Double(100, 500))
                .RuleFor(item => item.Date, f => f.Date.Between(new DateTime(2022, 1, 1), 
                    new DateTime(2022, 12, 1)))
                .RuleFor(item => item.Time, f => f.Date.Timespan());

            return fake.Generate(count);
        }
    }

    public class Item
    {
        public bool IsChecked { get; set; }
        public double RandomNo { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
    }
}
