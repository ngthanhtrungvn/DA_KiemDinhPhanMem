using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class AmLich
    {
        public string ChuyenDoiAmLich(int namDuongLich)
        { 
            // Lấy can và chi từ số thứ tự
        int chi = (namDuongLich - 4) % 12;
        int can = (namDuongLich - 4) % 10;

        // Mảng chứa tên các can và chi
        string[] tenCan = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
        string[] tenChi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

        // Chuyển đổi năm dương lịch thành năm âm lịch
        string namAmLich = tenCan[can] + " " + tenChi[chi];

        return namAmLich;
        }
    }
}
