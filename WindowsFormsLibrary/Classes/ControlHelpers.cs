namespace WindowsFormsLibrary.Classes;
public static class ControlHelpers
{
    /// <summary>
    /// Determine if control is a ComboBox
    /// </summary>
    public static bool IsComboBox(this Control control) => control is ComboBox;
    /// <summary>
    /// Determine if control is a ListBox
    /// </summary>
    public static bool IsListBox(this Control control) => control is ListBox;
}
