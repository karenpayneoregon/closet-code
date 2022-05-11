using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace DirectoryHelpersLibrary.Classes
{
    /// <summary>
    /// Provides code to iterate a folder forwards or backwards, see SolutionFolder()
    /// for how to use which when executed from a project in a Visual Studio solution
    /// will provide the solution folder path.
    /// </summary>
    public static class Folders
    {
        /// <summary>
        /// Get a parent folder by level
        /// </summary>
        /// <param name="folderName">folder to start with</param>
        /// <param name="level">level to traverse upwards </param>
        /// <returns>folder at level or root of drive</returns>
        public static string UpperFolder(this string folderName, int level)
        {
            var folderList = new List<string>();

            while (!string.IsNullOrWhiteSpace(folderName))
            {
                var parentFolder = Directory.GetParent(folderName);
                if (parentFolder == null) break;
                folderName = Directory.GetParent(folderName)?.FullName;
                folderList.Add(folderName);
            }

            return folderList.Count > 0 &&
                   level > 0 ? level - 1 <= folderList.Count - 1 ?
                folderList[level - 1] :
                folderName : folderName;
        }

        /// <summary>
        /// Jump one folder level towards root
        /// </summary>
        /// <param name="sender">Existing folder and file name</param>
        /// <returns></returns>
        public static string UpOneLevel(string sender)
            => UpperFolder(Path.GetDirectoryName(sender), 1);

        /// <summary>
        /// From project folder, get the solution folder path
        /// </summary>
        /// <returns>folder name</returns>
        public static string SolutionFolder()
            => AppDomain.CurrentDomain.BaseDirectory.UpperFolder(5);

        public static string CurrentSolutionName()
        {
            return Path.GetFileNameWithoutExtension(Directory.GetFiles(SolutionFolder(), "*.sln").FirstOrDefault());
        }
    }
}