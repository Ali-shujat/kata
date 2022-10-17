using kataPrac;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kataPrac.Tests
{
    [TestClass()]
    public class katasTests
    {
        [TestMethod()]
        public void ToJadenCaseTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                    "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                    "Strings didn't match.");
        }

        [TestMethod()]
        public void PrinterErrorTest()
        {
            Assert.Fail();
        }
        // [TestMethod()]
        // public void PrinterErrorTest()
        // {
        //     string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
        //     Assert.AreEqual("3/56", s.PrinterError(), "Strings didn't match.");
        // }
    }
}