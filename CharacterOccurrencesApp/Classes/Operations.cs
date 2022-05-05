using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharacterOccurrencesApp.Classes
{
    public class Operations
    {

        public static List<Item> GetAllItems(string values) 
            => (from item in ProcessData(values) select item).ToList();

        public static List<List<Item>> ReadFromFile(string fileName)
        {
            var itemList = new List<List<Item>>();
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                itemList.Add((from item in ProcessData(line) select item).ToList());
            }

            return itemList;
        }

        /// <summary>
        /// Get occurrences for each char in a string
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static IOrderedEnumerable<Item> ProcessData(string values)
        {
            
            if (string.IsNullOrWhiteSpace(values))
            {
                throw new ArgumentException("String is empty");
            }

            var itemsGroup = (
                    from chr in values.ToCharArray()
                    group chr by chr
                    into grp
                    select new Item
                    {
                        Character = grp.Key,
                        Occurrences = grp.Count(),
                        Code = Convert.ToInt32((int)grp.Key)
                    })
                .ToList()
                .OrderBy(item => item.Character.ToString());

            return itemsGroup;
        }

        /// <summary>
        /// Get occurrences for <see cref="findChar"/>
        /// </summary>
        /// <param name="list">list of <see cref="Item"/></param>
        /// <param name="findChar">Char to find</param>
        /// <returns>results</returns>
        public static List<Item> GetInfo(List<List<Item>> list, int findChar)
        {
            var items =
            (
                from sublist in list
                from item in sublist
                where item.Character == findChar
                select item).ToList();
            return items;
        }
    }
}