using System.Collections.Generic;

namespace GroupByMultiplePropertiesFindDuplicates.Models
{
    public class GroupedMember
    {
        public string FullName { get; }
        public List<Member> Lists { get; }

        public GroupedMember(string name, List<Member> items)
        {
            FullName = name;
            Lists = items;
        }

        public override string ToString() => FullName;

    }
}