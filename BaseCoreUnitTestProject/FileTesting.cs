using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BaseCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using UtilityLibrary.Classes;

namespace BaseCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class FileTesting : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.FileSorting)]
        public void FileSortTest()
        {
            // arrange
            string[] expected = {
                "01.txt", "1.txt", "1A2.txt", "1Atxt.txt",
                "1a1.txt", "2.txt", "11.txt", "100.txt",
                "A1.txt", "Zoo.txt"
            };

            DirectoryInfo directoryInfo = new(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"TextFilesSorting"));

            // act
            List<FileInfo> fileInfoCollection = directoryInfo
                .GetFiles("*.txt")
                .OrderBy(x => x.Name, new AlphanumComparator()).ToList();

            var names = fileInfoCollection.Select(x => x.Name).ToArray();

            // assert
            CollectionAssert.AreEqual(expected, names);
        }

    }

}