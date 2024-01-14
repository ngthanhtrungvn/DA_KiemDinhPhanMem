using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuan3;

namespace UnitTest_KiemTraTamGiac
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_KiemTraTamGiacDeu()
        {
            kiemTraTamGiac tg = new kiemTraTamGiac();
            string result_Actual = tg.KiemTraTamGiac(9, 9, 9);
            string result_Expect = "đều";
            Assert.AreEqual(result_Actual, result_Expect);
        }

        [TestMethod]
        public void TC2_KiemTraTamGiacCan()
        {
            kiemTraTamGiac tg = new kiemTraTamGiac();
            string result_Actual = tg.KiemTraTamGiac(4, 4, 5);
            string result_Expect = "cân";
            Assert.AreEqual(result_Actual, result_Expect);
        }

        [TestMethod]
        public void TC3_KiemTraTamGiacVuong()
        {
            kiemTraTamGiac tg = new kiemTraTamGiac();
            string result_Actual = tg.KiemTraTamGiac(3, 4, 5);
            string result_Expect = "vuông";
            Assert.AreEqual(result_Actual, result_Expect);
        }

        [TestMethod]
        public void TC3_KiemTraTamGiacVuongCan()
        {
            kiemTraTamGiac tg = new kiemTraTamGiac();
            string result_Actual = tg.KiemTraTamGiac(Math.Sqrt(2), 1, 1);
            string result_Expect = "vuông cân";
            Assert.AreEqual(result_Actual, result_Expect);
        }

        [TestMethod]
        public void TC3_KiemTraKhongPhaiTamGiac()
        {
            kiemTraTamGiac tg = new kiemTraTamGiac();
            string result_Actual = tg.KiemTraTamGiac(1, 2, 3);
            string result_Expect = "Khong phai tam giac";
            Assert.AreEqual(result_Actual, result_Expect);
        }

        [TestMethod]
        public void TC3_KiemTraTamGiacThuong()
        {
            kiemTraTamGiac tg = new kiemTraTamGiac();
            string result_Actual = tg.KiemTraTamGiac(2, 5, 6);
            string result_Expect = "thường";
            Assert.AreEqual(result_Actual, result_Expect);
        }
    }
}
