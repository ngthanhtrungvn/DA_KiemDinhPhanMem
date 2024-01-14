using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unitest_Code;
namespace UnitTest
{
    [TestClass]
    public class AmLichTest
    {
        [TestMethod]
        public void TC1_TestNam2000()
        {
            string amLich = AmLich.ChuyenNamdDuongSangAmLich(2000);
            Assert.AreEqual("Canh Thìn", amLich);
        }

        [TestMethod]
        public void TC2_TestNam2023()
        {
            string amLich = AmLich.ChuyenNamdDuongSangAmLich(2023);
            Assert.AreEqual("Nhâm Tuất", amLich);
        }

        [TestMethod]
        public void TC3_TestNam2020()
        {
            string amLich = AmLich.ChuyenNamdDuongSangAmLich(2020);
            Assert.AreEqual("Canh Tý", amLich);
        }

        [TestMethod]
        public void TC4_TestNam2023()
        {
            string amLich = AmLich.ChuyenNamdDuongSangAmLich(2023);
            Assert.AreEqual("Qúy Mão", amLich);
        }

        [TestMethod]
        public void TC5_TestNam2000()
        {
            string amLich = AmLich.ChuyenNamdDuongSangAmLich(2000);
            Assert.AreEqual("Canh Thân", amLich);
        }
    }
}
