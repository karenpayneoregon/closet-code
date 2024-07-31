using System;
using System.Collections.Generic;

namespace ChangeImage.Classes
{
    /// <summary>
    /// Provides access to resource images by loading them once
    /// </summary>
    public sealed class ResourceImages
    {
        private static readonly Lazy<ResourceImages> Lazy =
            new Lazy<ResourceImages>(() => new ResourceImages());

        public static ResourceImages Instance => Lazy.Value;

        private List<ResourceItem> _images;

        public List<ResourceItem> Images() => _images ??= ImageHelper.ResourceItemList();
    }
}