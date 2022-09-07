
namespace CharacterOccurrencesConsoleApp.Classes;

internal class TableHelper
{
    /// <summary>
    /// Create table to display character results
    /// </summary>
    public static Table CreateViewTable()
    {
        return new Table()
            .Border(TableBorder.Square)
            .BorderColor(Color.DarkViolet)
            .Centered()
            .Title(ColorHelpers.Paint("Results"))
            .AddColumn(new TableColumn("[b]Char[/]"))
            .AddColumn(new TableColumn("[b]Count[/]"));
    }
}