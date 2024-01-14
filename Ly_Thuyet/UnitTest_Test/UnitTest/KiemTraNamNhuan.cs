using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unitest_Code;
namespace UnitTest
{
    [TestClass]
    public class KiemTraNamNhuan
    {
        [TestMethod]
        public void TestLeapYear()
        {
            // Arrange
            NamNhuan kiemTraNamNhuan = new NamNhuan();

            // Act
            bool isLeapYear = kiemTraNamNhuan.IsLeapYear(2000);

            // Assert
            Assert.IsTrue(isLeapYear, "Năm 2000 là năm nhuận và hàm không trả về đúng kết quả.");
        }

        [TestMethod]
        public void TestNonLeapYear()
        {
            // Arrange
            NamNhuan kiemTraNamNhuan = new NamNhuan();

            // Act
            bool isLeapYear = kiemTraNamNhuan.IsLeapYear(1900);

            // Assert
            Assert.IsFalse(isLeapYear, "Năm 1900 không phải là năm nhuận và hàm không trả về đúng kết quả.");
        }

        [TestMethod]
        public void TestCommonLeapYear()
        {
            // Arrange
            NamNhuan kiemTraNamNhuan = new NamNhuan();

            // Act
            bool isLeapYear = kiemTraNamNhuan.IsLeapYear(2020);

            // Assert
            Assert.IsTrue(isLeapYear, "Năm 2020 là năm nhuận và hàm không trả về đúng kết quả.");
        }

        [TestMethod]
        public void TestNegativeYear()
        {
            // Arrange
            NamNhuan kiemTraNamNhuan = new NamNhuan();

            // Act
            bool isLeapYear = kiemTraNamNhuan.IsLeapYear(-100); // Năm âm không hợp lệ

            // Assert
            Assert.IsFalse(isLeapYear, "Hàm không xử lý đúng với năm âm.");
        }

        [TestMethod]
        public void TestRandomNonLeapYear()
        {
            // Arrange
            NamNhuan kiemTraNamNhuan = new NamNhuan();

            // Act
            bool isLeapYear = kiemTraNamNhuan.IsLeapYear(2019); // Năm không nhuận ngẫu nhiên

            // Assert
            Assert.IsFalse(isLeapYear, "Năm 2019 không phải là năm nhuận và hàm không trả về đúng kết quả.");
        }

        [TestMethod]
        public void TestZeroYear()
        {
            // Arrange
            NamNhuan kiemTraNamNhuan = new NamNhuan();

            // Act
            bool isLeapYear = kiemTraNamNhuan.IsLeapYear(0); // Năm 0 không hợp lệ

            // Assert
            Assert.IsFalse(isLeapYear, "Hàm không xử lý đúng với năm 0.");
        }
    }
}
