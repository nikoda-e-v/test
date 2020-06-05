using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
           string enc =  lab5.Program.encrypt(@"D:/4.txt");
           string dec = lab5.Program.decrypt(enc);

            //act
            string text = File.ReadAllText(@"D:/4.txt");

            //Assert
            Assert.AreEqual(text, dec);
        }
    }
}
