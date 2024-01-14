using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitest_Code
{
    public class AmLich
    {
        private static string[] can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
        private static string[] chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };

        public static string ChuyenNamdDuongSangAmLich(int namDuongLich)
        {
            int canIndex = namDuongLich % 10;
            int chiIndex = namDuongLich % 12;

            string canChiAmLich = can[canIndex] + " " + chi[chiIndex];
            return canChiAmLich;
        }
    }
}
