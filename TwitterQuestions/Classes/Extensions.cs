namespace TwitterQuestions.Classes;
public static class Extensions
{
    public static void Deconstruct(this DateOnly date, out int day, out int month, out int year) =>
        (day, month, year) = (date.Day, date.Month, date.Year);

    public static void Deconstruct(this DateTime date, out int day, out int month, out int year) =>
        (day, month, year) = (date.Day, date.Month, date.Year);


    public static void Deconstruct(this Version version, out int major, out int minor, out int build, out int revision)
        => (major, minor, build, revision) = (version.Major, version.Minor, version.Build, version.Revision);
}
