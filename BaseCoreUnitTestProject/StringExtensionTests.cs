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
using StringLanguageExtensions;

namespace BaseCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class StringExtensionTests : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.StringExtensions)]
        public void RemoveAllWhiteSpaceTest()
        {
            // arrange
            var sentence = " How well is the cat  ";
            var expected = "Howwellisthecat";

            // act
            var result = sentence.RemoveAllWhiteSpace();
            
            // assert
            Check.That(result).Equals(expected);

        }

    }

}