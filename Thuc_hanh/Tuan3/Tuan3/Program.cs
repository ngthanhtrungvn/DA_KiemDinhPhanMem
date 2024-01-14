using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    class Program
    {
        static void Main(string[] args)
        {
            //tinhTienDien td = new tinhTienDien();
            //int soDien = 1000; // Số điện tiêu thụ

            //double thanhTien = td.TinhTienDienSinhHoat(soDien);

            //Console.WriteLine("Số tiền điện phải trả (bao gồm VAT): {0} VND", thanhTien);
            //Console.ReadLine();

            //AmLich al = new AmLich();

            //int namDuongLich = 2022;

            //string namAmLich = al.ChuyenDoiAmLich(namDuongLich);

            //Console.WriteLine("Năm trong âm lịch là: {0}",namAmLich);

            // Ví dụ sử dụng hàm giải phương trình bậc 2
            GiaiPhuongTrinhBac2 td = new GiaiPhuongTrinhBac2();

            td.giaiPhuongTrinhBac2(0, -3,2);
            Console.ReadLine();

        }
    }
}
