using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuan3;

namespace UnitTest_AmLich
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_ChuyenNamAmLich()
        {
            AmLich al = new AmLich();
            string Actual_Result = al.ChuyenDoiAmLich(2023);
            string Expected_Result= "Quý Mão";
            Assert.AreEqual(Actual_Result, Expected_Result);
        }
        [TestMethod]
        public void TC2_ChuyenNamAmLich()
        {
            AmLich al = new AmLich();
            string Actual_Result = al.ChuyenDoiAmLich(2022);
            string Expected_Result = "Nhâm Dần";
            Assert.AreEqual(Actual_Result, Expected_Result);
        }
        
    }
}
