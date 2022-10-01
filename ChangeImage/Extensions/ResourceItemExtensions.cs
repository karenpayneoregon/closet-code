using System.Collections.Generic;
using System.Linq;
using ChangeImage.Classes;

namespace ChangeImage.Extensions
{
    public static class ResourceItemExtensions
    {
        /// <summary>
        /// Return resources of type Icon
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>list of icons or an empty list</returns>
        public static List<ResourceItem> Icons(this List<ResourceItem> sender) => sender.Where(item => item.IsIcon).ToList();
        /// <summary>
        /// Return resources of type Bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>list of bitmaps or an empty list</returns>        
        public static List<ResourceItem> BitMaps(this List<ResourceItem> sender) => sender.Where(item => !item.IsIcon).ToList();
    }
}
