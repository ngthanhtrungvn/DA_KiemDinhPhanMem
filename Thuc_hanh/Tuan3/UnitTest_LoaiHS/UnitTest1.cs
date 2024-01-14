using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuan3;

namespace UnitTest_LoaiHS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_HocSinhKha()
        {
            LoaiHS hs = new LoaiHS();
            int Actual_result = hs.xepLoai(6, 9, 9, 8);
            int Expected_result = 1;
            Assert.AreEqual(Actual_result, Expected_result);
        }

        [TestMethod]
        public void TC2_HocSinhGioi()
        {
            LoaiHS hs = new LoaiHS();
            int Actual_result = hs.xepLoai(9, 9, 9, 8.5);
            int Expected_result = 0;
            Assert.AreEqual(Actual_result, Expected_result);
        }

        [TestMethod]
        public void TC3_HocSinhTrungBinh()
        {
            LoaiHS hs = new LoaiHS();
            int Actual_result = hs.xepLoai(5, 6, 5, 5.5);
            int Expected_result = 2;
            Assert.AreEqual(Actual_result, Expected_result);
        }

        [TestMethod]
        public void TC4_HocSinhYeu()
        {
            LoaiHS hs = new LoaiHS();
            int Actual_result = hs.xepLoai(4, 4.5, 4, 4.5);
            int Expected_result = 3;
            Assert.AreEqual(Actual_result, Expected_result);
        }

        [TestMethod]
        public void TC4_HocSinhKhongTimThay()
        {
            LoaiHS hs = new LoaiHS();
            int Actual_result = hs.xepLoai(-2, 9, 9, 4.5);
            int Expected_result = -1;
            Assert.AreEqual(Actual_result, Expected_result);
        }

        [TestMethod]
        [TestCategory("Failed")]
        public void TC4_HocSinhVuongDiemRenluyen()
        {
            LoaiHS hs = new LoaiHS();
            int Actual_result = hs.xepLoai(9, 9, 9, 4.5);
            int Expected_result = 0;
            Assert.AreEqual(Actual_result, Expected_result);
        }

    }
}
