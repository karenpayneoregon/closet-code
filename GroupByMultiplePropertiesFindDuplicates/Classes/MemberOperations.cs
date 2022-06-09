using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupByMultiplePropertiesFindDuplicates.Models;

namespace GroupByMultiplePropertiesFindDuplicates.Classes
{
    public class MemberOperations
    {
        // mock-up
        public static IEnumerable<Member> MembersList() =>
            new List<Member>()
            {
                new Member { Id = 1, Active = true,  Name = "Mary", Surname = "Adams" },
                new Member { Id = 2, Active = false, Name = "Sue", Surname = "Williams" },
                new Member { Id = 3, Active = true,  Name = "Jake", Surname = "Burns" },
                new Member { Id = 4, Active = true,  Name = "Jake", Surname = "Burns" },
                new Member { Id = 5, Active = true,  Name = "Clair", Surname = "Smith" },
                new Member { Id = 6, Active = true,  Name = "Mary", Surname = "Adams" },
            };
        public static List<GroupedMember> GroupedMembers(IEnumerable<Member> list) =>
            list
                .Where(member => member.Active)
                .GroupBy(member => new { member.Name, member.Surname })
                .Select(item =>
                    new GroupedMember($"{item.Key.Name} {item.Key.Surname}", item.ToList()))
                .ToList();
    }
}
