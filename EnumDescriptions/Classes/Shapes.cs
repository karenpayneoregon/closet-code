using System.ComponentModel;

namespace EnumDescriptions.Classes
{
    public enum Shapes : int
    {
        [Description("A shape with 3 strokes")]
        Triangle,
        [Description("A rounded shape")]
        Circle,
        [Description("A shape with 4 corners")]
        Square,
        [Description("Other option")]
        Other
    }
}