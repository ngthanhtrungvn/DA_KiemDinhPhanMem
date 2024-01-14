using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE03_DanhHoangSon_Code
{
    public class Program
    {
        static void Main(string[] args)
        {
            TinhTienBaoHiem tinhTienBaoHiem = new TinhTienBaoHiem();

            Console.WriteLine("Nhap tong chi phi y te: ");
            double tongChiPhiYTe = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nguoi nay la nguoi thuoc ho ngheo (true/false): ");
            bool laNgheo = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Nguoi nay tham gia BHYT lien tec (true/false): ");
            bool laThamGiaLienTuc = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Nhap so nam tham gia BHYT lien tuc: ");
            int soNamThamGiaLienTuc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap tuoi cua nguoi nay: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());

            double tongMienGiam = tinhTienBaoHiem.TinhBHYT(tongChiPhiYTe, laNgheo, laThamGiaLienTuc, soNamThamGiaLienTuc, tuoi);
            Console.WriteLine("So tien đuoc mien giam la: " + tongMienGiam + " VNĐ");

            Console.ReadLine();
        }
    }
}
