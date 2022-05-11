using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using RulesUnitTestProject.Base;
using RulesUnitTestProject.Classes;
using RulesUnitTestProject.Models;

namespace RulesUnitTestProject
{
    [TestClass]
    public partial class ExistingFileNameAttributeTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.CustomAnnotationAttribute)]
        public void FileAttachmentTest()
        {
            // arrange
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShakeMe1.gif");
            FileAttachment attachment = new ()
            {
                FileName = fileName,
                Description = "Shake me"
            };

            // act
            var (success, _ ) = ValidationOperations.IsValidEntity(attachment);

            // assert

            Check.That(success).IsTrue();

        }

        [TestMethod]
        [TestTraits(Trait.CustomAnnotationAttribute)]
        public void FileAttachmentMissingDescriptionTest()
        {
            // arrange
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShakeMe1.gif");
            FileAttachment attachment = new()
            {
                FileName = fileName,
                Description = null
            };

            // act
            var (success, _) = ValidationOperations.IsValidEntity(attachment);

            // assert

            Check.That(success).IsFalse();
        }

        [TestMethod]
        [TestTraits(Trait.CustomAnnotationAttribute)]
        public void FileAttachmentFileExistsTest()
        {
            // arrange
            var expected = "Sorry but there is already an image with this name please rename your image";
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShakeMe.gif");
            FileAttachment attachment = new()
            {
                FileName = fileName,
                Description = null
            };

            // act
            var ( _ , errorMessages) = ValidationOperations.IsValidEntity(attachment);

            // assert
            Check.That(errorMessages).Contains(expected);
        }

    }
}
