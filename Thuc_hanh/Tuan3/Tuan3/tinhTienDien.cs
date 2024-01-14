using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class tinhTienDien
    {
        public double TinhTienDienSinhHoat(int soDien)
        {
            double giaDien = 0;
            //so dien am
            if (soDien < 0)
            {
                giaDien = 0;
            }
            // Bậc 1
            else if (soDien <= 50)
            {
                giaDien = soDien * 1678;
            }
            // Bậc 2
            else if (soDien <= 100)
            {
                giaDien = 50 * 1678 + (soDien - 50) * 1734;
            }
            // Bậc 3
            else if (soDien <= 200)
            {
                giaDien = 50 * 1678 + 50 * 1734 + (soDien - 100) * 2014;
            }
            // Bậc 4
            else if (soDien <= 300)
            {
                giaDien = 50 * 1678 + 50 * 1734 + 100 * 2014 + (soDien - 200) * 2536;
            }
            // Bậc 5
            else if (soDien <= 400)
            {
                giaDien = 50 * 1678 + 50 * 1734 + 100 * 2014 + 100 * 2536 + (soDien - 300) * 2834;
            }
            // Bậc 6
            else
            {
                giaDien = 50 * 1678 + 50 * 1734 + 100 * 2014 + 100 * 2536 + 100 * 2834 + (soDien - 400) * 2927;
            }

            // Tính thuế VAT
            double thueVAT = giaDien * 0.1;

            // Tổng số tiền cần thanh toán (bao gồm cước và VAT)
            double thanhTien = giaDien + thueVAT;

            return thanhTien;

            
        }
    }
}
