using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Classes.Test
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            //Arrange
            FileManager fileManager = new FileManager();
            bool fromCall;

            //Act
            fromCall = fileManager.IsFileExist(@"C:\Windows\notepad.exe");

            //Assert
            Assert.IsTrue(fromCall);

        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAtribute()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            Assert.Inconclusive();
        }
    }
}
