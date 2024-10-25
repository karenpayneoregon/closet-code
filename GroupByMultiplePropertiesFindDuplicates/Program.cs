using GroupByMultiplePropertiesFindDuplicates.Classes;
using GroupByMultiplePropertiesFindDuplicates.Models;

namespace GroupByMultiplePropertiesFindDuplicates;

internal partial class Program
{
    private static void Main()
    {
        var members = MemberOperations.MembersList();
        List<GroupedMember> groups = MemberOperations.GroupedMembers(members);
            
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


}