using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Surname = "Zhuravchak";
            int result = laba6._2.Program.Get_Length(Surname);
            Assert.AreEqual(10, result);
        }
    }
}
