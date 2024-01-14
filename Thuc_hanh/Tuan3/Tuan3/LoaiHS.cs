using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class LoaiHS
    {
        /*
        -1:failed
        0:Giỏi
        1:Khá
        2:Trung bình
        3:Yếu          
       */

        public int xepLoai(double Toan, double Ly, double Hoa, double renLuyen)
        {
            if (Toan < 0 || Toan > 10 || Ly < 0 || Ly > 10 || Hoa < 0 || Hoa > 10)
                return -1;
            if (Toan < 3 || Ly < 3 || Hoa < 3)
                return 3;
            double hocLuc = (Toan + Ly + Hoa) / 3;
            if (hocLuc < 5 || renLuyen < 5)
                return 3;
            if (hocLuc < 6.5 || renLuyen < 6.5)
                return 2;
            if (hocLuc < 8 || renLuyen < 8)
            {
                if (Toan >= 5 && Ly >= 5 && Hoa >= 5)
                    return 1;
                return 2;
            }
            if (Toan >= 6.5 && Ly >= 6.5 && Hoa >= 6.5)
                return 0;
            return 1;
        }
    }
}
