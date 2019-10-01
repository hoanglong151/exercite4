using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool res03 = Program.IsOdd(3);
            Assert.AreEqual(true, res03);
            bool res04 = Program.IsOdd(4);
            Assert.AreEqual(false, res04);

        }
        [TestMethod]
        public void TestMethod2()
        {
            bool res03 = Program.IsEven(3);
            Assert.AreEqual(false, res03);
            bool res04 = Program.IsEven(4);
            Assert.AreEqual(true, res04);
        }
        [TestMethod]
        public void TestMethod3()
        {
            bool res03 = Program.IsPrime(3);
            Assert.AreEqual(true, res03);
            bool res04 = Program.IsPrime(4);
            Assert.AreEqual(false, res04);
        }

    }
}