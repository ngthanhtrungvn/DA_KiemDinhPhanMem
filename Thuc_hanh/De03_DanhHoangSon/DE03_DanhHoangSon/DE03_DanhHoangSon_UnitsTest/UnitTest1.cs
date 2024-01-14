using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DE03_DanhHoangSon_Code;
namespace DE03_DanhHoangSon_UnitsTest
{
    [TestClass]
    public class TinhTienBaoHiemTests
    {
        [TestMethod]
        public void Test_TinhBHYT_Mien100Duoi6()
        {
            TinhTienBaoHiem tinhTienBaoHiem = new TinhTienBaoHiem();
            double tongChiPhiYTe = 2000000;
            bool laNgheo = false;
            bool laThamGiaLienTuc = false;
            int soNamThamGiaLienTuc = 0;
            int tuoi = 5;

            double result = tinhTienBaoHiem.TinhBHYT(tongChiPhiYTe, laNgheo, laThamGiaLienTuc, soNamThamGiaLienTuc, tuoi);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_TinhBHYT_Mien100()
        {
            TinhTienBaoHiem tinhTienBaoHiem = new TinhTienBaoHiem();
            double tongChiPhiYTe = 1500000;
            bool laNgheo = true;
            bool laThamGiaLienTuc = false;
            int soNamThamGiaLienTuc = 0;
            int tuoi = 30;

            double result = tinhTienBaoHiem.TinhBHYT(tongChiPhiYTe, laNgheo, laThamGiaLienTuc, soNamThamGiaLienTuc, tuoi);

            Assert.AreEqual(75000, (int)result);
        }

        [TestMethod]
        public void Test_TinhBHYT_Mien80()
        {
            TinhTienBaoHiem tinhTienBaoHiem = new TinhTienBaoHiem();
            double tongChiPhiYTe = 2000000;
            bool laNgheo = false;
            bool laThamGiaLienTuc = true;
            int soNamThamGiaLienTuc = 5;
            int tuoi = 35;

            double result = tinhTienBaoHiem.TinhBHYT(tongChiPhiYTe, laNgheo, laThamGiaLienTuc, soNamThamGiaLienTuc, tuoi);

            Assert.AreEqual(0, (int)result);
        }

        [TestMethod]
        public void Test_TinhBHYT_Mien95Ngheo()
        {
            TinhTienBaoHiem tinhTienBaoHiem = new TinhTienBaoHiem();
            double tongChiPhiYTe = 1800000;
            bool laNgheo = true;
            bool laThamGiaLienTuc = false;
            int soNamThamGiaLienTuc = 0;
            int tuoi = 50;

            double ketQua = tinhTienBaoHiem.TinhBHYT(tongChiPhiYTe, laNgheo, laThamGiaLienTuc, soNamThamGiaLienTuc, tuoi);
            ketQua = Math.Round(ketQua); // Làm tròn giá trị kết quả

            Assert.AreEqual(90000, ketQua);
        }

        [TestMethod]
        public void Test2_TinhBHYT_Mien80()
        {
            TinhTienBaoHiem tinhTienBaoHiem = new TinhTienBaoHiem();
            double tongChiPhiYTe = 200000;
            bool laNgheo = false;
            bool laThamGiaLienTuc = false;
            int soNamThamGiaLienTuc = 2;
            int tuoi = 60;

            double result = tinhTienBaoHiem.TinhBHYT(tongChiPhiYTe, laNgheo, laThamGiaLienTuc, soNamThamGiaLienTuc, tuoi);

            Assert.AreEqual(40000, (int)result);
        }
    }
}
