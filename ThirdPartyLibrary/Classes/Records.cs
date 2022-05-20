using System.Collections.Generic;

namespace ThirdPartyLibrary.Classes
{
    public class Records
    {
        public static List<CountryRecord> Countries()
        {
            List<CountryRecord> records = new()
            {
                new(1, "Argentina"),
                new(2, "Austria"),
                new(3, "Belgium"),
                new(4, "Brazil"),
                new(5, "Canada"),
                new(6, "Denmark"),
                new(7, "Finland"),
                new(8, "France"),
                new(9, "Germany"),
                new(10, "Ireland"),
                new(11, "Italy"),
                new(12, "Mexico"),
                new(13, "Norway"),
                new(14, "Poland"),
                new(15, "Portugal"),
                new(16, "Spain"),
                new(17, "Sweden"),
                new(18, "Switzerland"),
                new(19, "UK"),
                new(20, "USA"),
                new(21, "Venezuela")
            };

            return records;

        }
    }
}