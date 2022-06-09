using System;
using System.Collections.Generic;
using System.Linq;
using GroupByMultiplePropertiesFindDuplicates.Models;

namespace GroupByMultiplePropertiesFindDuplicates
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<GroupedMember> groups = GroupedMembers(MembersList());
            
            foreach (GroupedMember groupMember in groups)
            {
                Console.WriteLine(groupMember);
                foreach (Member member in groupMember.Lists)
                {
                    Console.WriteLine($"\t{member.Id,-3}{member.Active}");
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Group <see cref="Member"/> by first and last name and return a list of <see cref="GroupedMembers"/>
        /// The key for this to work properly is item.ToList() which is a list of <see cref="Member"/>
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static List<GroupedMember> GroupedMembers(IEnumerable<Member> list) =>
            list
                .Where(member => member.Active)
                .GroupBy(member => new { member.Name, member.Surname })
                .Select(item => 
                    new GroupedMember($"{item.Key.Name} {item.Key.Surname}", item.ToList()))
                .ToList();

        private static IEnumerable<Member> MembersList() =>
            new List<Member>()
            {
                new Member { Id = 1, Active = true,  Name = "Mary", Surname = "Adams" },
                new Member { Id = 2, Active = false, Name = "Sue", Surname = "Williams" },
                new Member { Id = 3, Active = true,  Name = "Jake", Surname = "Burns" },
                new Member { Id = 4, Active = true,  Name = "Jake", Surname = "Burns" },
                new Member { Id = 5, Active = true,  Name = "Clair", Surname = "Smith" },
                new Member { Id = 6, Active = true,  Name = "Mary", Surname = "Adams" },
            };
    }
}
