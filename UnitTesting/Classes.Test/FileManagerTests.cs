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
            //Arrange
            FileManager fileManager = new FileManager();
            bool fromCall;

            //Act
            fromCall = fileManager.IsFileExist(@"C:\Windows\ghost_file.exe");

            //Assert
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAtribute()
        {
            //Arrange
            FileManager fileManager = new FileManager();
            bool fromCall;

            //Act
            fromCall = fileManager.IsFileExist("");
                        
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            //Arrange
            FileManager fileManager = new FileManager();


            //Act
            try
            {
                fileManager.IsFileExist("");
            }

            catch (ArgumentNullException)
            {
                return;
            }
            //Assert
            Assert.Fail("Call to IsFileExist() did NOT throw an ArgumentNullException.");

        }
    }
}
