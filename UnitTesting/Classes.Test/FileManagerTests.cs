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
            Assert.Inconclusive();
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
