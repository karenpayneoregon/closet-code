namespace TinyHelpersApp.Classes;

internal static class CollectionExtensions
{
    public static IEnumerable<WithIndex<T>> WithIndex<T>(this IEnumerable<T> source) where T : class
        => source.Select((item, index) => new WithIndex<T>(item, index));
}