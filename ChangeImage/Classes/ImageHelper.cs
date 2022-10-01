using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using ChangeImage.Properties;

namespace ChangeImage.Classes
{
    public class ImageHelper
    {

        public static List<ResourceItem> ResourceItemList()
        {
            var items = new List<ResourceItem>();

            foreach (var name in ResourceImageNames())
            {
                
                var item = new ResourceItem() {Name = name, IsIcon = false};
                
                if (Resources.ResourceManager.GetObject(name) is Icon)
                {
                    item.Image  = ((Icon)Resources.ResourceManager.GetObject(name))?.ToBitmap();
                    item.IsIcon = true;
                }
                else
                {
                    item.Image = (Bitmap)Resources.ResourceManager.GetObject(name);
                }
                
                items.Add(item);


            }

            return items;
            
        }
        public static List<string> ResourceImageNames()
        {

            try
            {
                var names = new List<string>();
                var resourceSet = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
                names.AddRange(
                    from DictionaryEntry dictionaryEntry in resourceSet 
                    where dictionaryEntry.Value is Image || dictionaryEntry.Value is Icon 
                    select dictionaryEntry.Key.ToString());
                return names;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}