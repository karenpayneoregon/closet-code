using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryHelpersLibrary.Classes
{
    public class Utilities
    {
        /// <summary>
        /// Filter files in a folder on multiple extensions 
        /// </summary>
        /// <param name="path">Path to filter</param>
        /// <param name="extensions">One or more file extensions</param>
        /// <returns></returns>
        /// <remarks>
        /// Setup to include sub-folders
        /// </remarks>
        public static IEnumerable<string> FilterFiles(string path, params string[] extensions)
            => extensions
                .Select(filter => $"*.{filter}")
                .SelectMany(item => 
                    Directory.EnumerateFiles(
                        path, 
                        item, 
                        SearchOption.AllDirectories));
    }
}
