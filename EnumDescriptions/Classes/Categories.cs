using System.ComponentModel;

namespace EnumDescriptions.Classes
{
    public enum Categories
    {
        [Description("Soft drinks, coffees, teas")]
        Beverages,
        [Description("Cheeses")]
        DairyProducts,
        [Description("Breads, crackers, pasta, and cereal")]
        GrainsCereals,
        [Description("Dried fruit and bean curd")]
        Produce
    }
}