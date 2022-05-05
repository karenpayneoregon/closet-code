using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationLibrary.Models
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
