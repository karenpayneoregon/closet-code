namespace CharacterOccurrencesConsoleApp.Models;

/// <summary>
/// Character container for char and char count
/// </summary>
public class Container
{
    public char Char { get; }
    public int Count { get; }
    public bool IsDigit => char.IsDigit(Char);

    public Container(char c, int count)
    {
        Char = c;
        Count = count;
    }

    public override string ToString() => $"{Char,-3}{Count}";

}