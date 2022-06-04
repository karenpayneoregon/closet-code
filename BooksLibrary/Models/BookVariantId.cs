using System.ComponentModel;

namespace BooksLibrary.Models
{
    public enum BookVariantId : int
    {
        [Description("Space Travel")]
        SpaceTravel = 0,

        [Description("Adventure")]
        Adventure = 1,

        [Description("Sports")]
        Sports = 2,

        [Description("Automobile")]
        Automobile = 3,

        [Description("Computer Programming")]
        Programming = 4
    }
}