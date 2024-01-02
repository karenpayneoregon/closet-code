using GroupByMultiplePropertiesFindDuplicates.Models;

namespace GroupByMultiplePropertiesFindDuplicates.Classes;

public class MemberOperations
{
    // mock-up
    public static IEnumerable<Member> MembersList() =>
        new List<Member>()
        {
            new() { Id = 1, Active = true,  Name = "Mary", Surname = "Adams" },
            new() { Id = 2, Active = false, Name = "Sue", Surname = "Williams" },
            new() { Id = 3, Active = true,  Name = "Jake", Surname = "Burns" },
            new() { Id = 4, Active = true,  Name = "Jake", Surname = "Burns" },
            new() { Id = 5, Active = true,  Name = "Clair", Surname = "Smith" },
            new() { Id = 6, Active = true,  Name = "Mary", Surname = "Adams" },
        };

    /// <summary>
    /// Get active members strongly typed
    /// </summary>
    /// <param name="list">List of <see cref="Member"/></param>
    /// <returns></returns>
    public static List<GroupedMember> GroupedMembers(IEnumerable<Member> list) => list
            .Where(member => member.Active)
            .GroupBy(member => new { member.Name, member.Surname })
            .Select(item =>
                new GroupedMember($"{item.Key.Name} {item.Key.Surname}", item.ToList()))
            .ToList();
}