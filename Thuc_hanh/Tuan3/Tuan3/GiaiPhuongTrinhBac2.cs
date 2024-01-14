using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class GiaiPhuongTrinhBac2
    {
        public void giaiPhuongTrinhBac2(double a, double b, double c)
    {
        if (a == 0)
        {
            // Phương trình bậc 1
            if (b != 0)
            {
                double x = -c / b;
                Console.WriteLine("Phuong trinh co nghiem duy nhat: x = {0}", x);
            }
            else if (c == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem.");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }
        else
        {
            // Phương trình bậc 2
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: x = {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co hai nghiem phan biet: x1 = {0}, x2 = {1}",x1,x2);
            }
        }
    }
    }
}
