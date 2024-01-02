
using System.ComponentModel;
using System.Reflection;

namespace Setters.Models;


        public record PersonRecord(
            [property: Description("Id")] int Id,
            [property: Description("First Name")] string FirstName,
            [property: Description("Middle Name")] string MiddleName,
            [property: Description("Last Name")] string LastName,
            [property: Description("Phone list")] List<string> PhoneList
            );








public static class TypeExtensionMethods
{
    public static List<(PropertyInfo Info, T Attribute)> GetPropertyWithAttribute<T>(this Type type) where T : Attribute =>
        type.GetProperties()
            .Select(x => (Info: x, Attribute: GetAttribute<T>(x)))
            .Where(x => x.Attribute != default)
            .ToList();

    private static T? GetAttribute<T>(PropertyInfo info) where T : Attribute =>
        (T)info.GetCustomAttributes(typeof(T), true)
            .FirstOrDefault();
}