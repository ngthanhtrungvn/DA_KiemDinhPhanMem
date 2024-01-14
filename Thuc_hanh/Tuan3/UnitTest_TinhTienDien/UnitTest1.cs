using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuan3;

namespace UnitTest_TinhTienDien
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_TinhTienDienBac1()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(50);
            double Expected_Result = 92290;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }

        [TestMethod]
        public void TC2_TinhTienDienBac2()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(100);
            double Expected_Result = 187660;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }
        [TestMethod]
        public void TC3_TinhTienDienBac3()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(150);
            double Expected_Result = 298430;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }

        [TestMethod]
        public void TC4_TinhTienDienBac4()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(200);
            double Expected_Result = 409200;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }

        [TestMethod]
        public void TC5_TinhTienDienBac5()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(350);
            double Expected_Result = 844030;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }

        [TestMethod]
        public void TC5_TinhTienDienBac6()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(500);
            double Expected_Result = 1321870;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }

        [TestMethod]
        public void TC6_TinhTienDienVoiSo0()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(0);
            double Expected_Result = 0;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }

        [TestMethod]
        public void TC7_TinhTienDienVoiSoAm()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(-50);
            double Expected_Result = 0;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }

        [TestMethod]
        public void TC8_TinhTienDienVoSoDienBatKy()
        {
            tinhTienDien td = new tinhTienDien();
            double Actual_Result = td.TinhTienDienSinhHoat(1000);
            double Expected_Result = 2931720;
            Assert.AreEqual(Actual_Result, Expected_Result);
        }
    }
}
