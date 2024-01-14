using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuan3;

namespace UnitTest_TimMaxMin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_TimMaxMin()
        {
            timMaxMin mm = new timMaxMin();
            int resultMax, resultMin;
            mm.TimMaxMin(3, 7, 2, out resultMax, out resultMin);
            Assert.AreEqual(7, resultMax);
            Assert.AreEqual(3, resultMin);
        }
        [TestMethod]
        public void TC2_TimMaxMin() 
        {
            timMaxMin mm = new timMaxMin();
            int resultMax, resultMin;
            mm.TimMaxMin(3, 7, 2, out resultMax, out resultMin);
            Assert.AreEqual(7, resultMax);
            Assert.AreEqual(2, resultMin);
        
        }
    }
}
