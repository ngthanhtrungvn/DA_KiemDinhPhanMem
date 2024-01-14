using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuan3;

namespace UnitTest_TinhTong
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_testTong2SoNguyen()
        {
            TinhTong t = new TinhTong();
            int Result_Actual = t.tinhTong(5, 7);
            int Result_Expect = 12;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }

        [TestMethod]
        public void TC2_testTong2SoNguyen()
        {
            TinhTong t = new TinhTong();
            int Result_Actual = t.tinhTong(2, 7);
            int Result_Expect = 12;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }
    }
}
