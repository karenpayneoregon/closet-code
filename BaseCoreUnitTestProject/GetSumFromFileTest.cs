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
using LoopThroughFileLibrary.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace BaseCoreUnitTestProject
{
    /// <summary>
    /// Test functionality looping through a file using a StreamReader and
    /// getting total via cycling through each line
    /// </summary>
    [TestClass]
    public partial class GetSumFromFileTest : TestBase
    {
        /// <summary>
        /// Given a perfect file get total
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.LoopingFile)]
        public void CleanReadTest()
        {
            // arrange
            var fileName = _cleanFileName;
            decimal expected = 60.79m;

            // act
            var (total, _, _) = Operations.GetTotals(fileName);

            // assert
            Check.That(total).Equals(expected);
            
        }
        /// <summary>
        /// Given a perfect file assert no errors
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.LoopingFile)]
        public void CleanReadNoBadLinesTest()
        {
            // arrange
            var fileName = _cleanFileName;

            // act
            var (_, linesBad, _) = Operations.GetTotals(fileName);

            // assert
            Check.That(linesBad.Count).Equals(0);

        }

        /// <summary>
        /// Given one line can not be converted test
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.LoopingFile)]
        public void MalFormedLineTest()
        {
            // arrange
            var fileName = _malformedFileName;

            // act
            var (_, linesBad, _) = Operations.GetTotals(fileName);

            // assert
            Check.That(linesBad.Count).Equals(1);
        }


        /// <summary>
        /// Validate file was not found by checking type of exception
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.LoopingFile)]
        public void FileDoesNotExistsTest()
        {
            // arrange
            var fileName = "xyz_not.txt";

            // act
            var (_, _, exception) = Operations.GetTotals(fileName);
            
            // assert
            Check.That(exception.GetType()).IsEqualTo(typeof(FileNotFoundException));
        }

    }

}