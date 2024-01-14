using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class timMaxMin
    {
        public void TimMaxMin(int a, int b, int c, out int max, out int min)
        {
            // Tìm giá trị lớn nhất
            max = Math.Max(a, Math.Max(b, c));

            // Tìm giá trị nhỏ nhất
            min = Math.Min(a, Math.Min(b, c));
        }
    }
}
