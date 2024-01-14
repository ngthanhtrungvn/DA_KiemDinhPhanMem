using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tuan3;

namespace UnitTest_GiaiPhuongTrinhBac2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TH1_PhuongTrinhCo2NghiemPB()
        {
            GiaiPhuongTrinhBac2 pt = new GiaiPhuongTrinhBac2();

            // Act
            var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            pt.giaiPhuongTrinhBac2(1, -3, 2);
            string result = sw.ToString().Trim();

            // Assert
            Assert.AreEqual("Phuong trinh co hai nghiem phan biet: x1 = 2, x2 = 1", result);
        }

        [TestMethod]
        public void TH2_PhuongTrinhVoNghiem()
        {
            GiaiPhuongTrinhBac2 pt = new GiaiPhuongTrinhBac2();

            // Act
            var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            pt.giaiPhuongTrinhBac2(1, 2, 5);
            string result = sw.ToString().Trim();

            // Assert
            Assert.AreEqual("Phuong trinh vo nghiem.", result);
        }

        [TestMethod]
        public void TH3_PhuongTrinhCoNghiemDuyNhat()
        {
            GiaiPhuongTrinhBac2 pt = new GiaiPhuongTrinhBac2();

            // Act
            var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            pt.giaiPhuongTrinhBac2(0, -3, 2);
            string result = sw.ToString().Trim();

            // Assert
            Assert.AreEqual("Phuong trinh co nghiem duy nhat: x = 0,666666666666667", result);
        }

        [TestMethod]
        public void TH4_PhuongTrinhCoNghiemKep()
        {
            GiaiPhuongTrinhBac2 pt = new GiaiPhuongTrinhBac2();


            // Act
            var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            pt.giaiPhuongTrinhBac2(1, -2, 1);
            string result = sw.ToString().Trim();

            // Assert
            Assert.AreEqual("Phuong trinh co nghiem kep: x = 1", result);
        }

        [TestMethod]
        public void TH5_PhuongTrinhVoNghiem()
        {
            GiaiPhuongTrinhBac2 pt = new GiaiPhuongTrinhBac2();


            // Act
            var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            pt.giaiPhuongTrinhBac2(2, 0, 5);
            string result = sw.ToString().Trim();

            // Assert
            Assert.AreEqual("Phuong trinh vo nghiem.", result);
        }

        [TestMethod]
        public void TH6_PhuongTrinhVoNghiem()
        {
            GiaiPhuongTrinhBac2 pt = new GiaiPhuongTrinhBac2();


            // Act
            var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            pt.giaiPhuongTrinhBac2(0, 0, 5);
            string result = sw.ToString().Trim();

            // Assert
            Assert.AreEqual("Phuong trinh vo nghiem.", result);
        }
    }
}
