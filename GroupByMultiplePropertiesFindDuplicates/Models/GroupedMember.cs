using System.Collections.Generic;

namespace GroupByMultiplePropertiesFindDuplicates.Models
{
    public class GroupedMember
    {
        public string Name { get; }
        public List<Member> Lists { get; }

        public GroupedMember(string name, List<Member> items)
        {
            Name = name;
            Lists = items;
        }

        public override string ToString() => Name;

    }
}