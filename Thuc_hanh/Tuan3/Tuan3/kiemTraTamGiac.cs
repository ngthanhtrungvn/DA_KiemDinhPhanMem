using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class kiemTraTamGiac
    {
        public string KiemTraTamGiac(double a, double b, double c)
        {
            // Kiểm tra điều kiện tam giác
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    return "đều";
                }
                else if (a == b || a == c || b == c)
                {
                    if (((a * a) + (b * b) == (int)(c * c) || ((a * a) + (c * c) == (int)(b * b) || ((b * b) + (c * c) == (int)(a * a)))))
                    {
                        return "vuông cân";
                    }
                    else
                    {
                        return "cân";
                    }
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    return "vuông";
                }
                else
                {
                    return "thường";
                }
            }
            else
            {
                return "Khong phai tam giac";
            }
        }
    }
}
