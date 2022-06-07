
namespace AccountsLibrary
{
    public static class Extensions
    {
        public static T ToEnum<T>(this int value) where T : struct => (T)(object)value;
    }
}
