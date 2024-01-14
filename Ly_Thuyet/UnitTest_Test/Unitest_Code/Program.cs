using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitest_Code
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tạo một đối tượng của lớp KiemTraNamNhuan
            NamNhuan kiemTraNamNhuan = new NamNhuan();

            // Năm cần kiểm tra
            int yearToCheck = 2024;

            // Gọi hàm kiểm tra năm nhuận và hiển thị kết quả
            bool isLeapYear = kiemTraNamNhuan.IsLeapYear(yearToCheck);

            if (isLeapYear)
            {
                Console.WriteLine($"{yearToCheck} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"{yearToCheck} không là năm nhuận.");
            }
            //--------------------------------------------------------------------------------------------------------------------
            //kiểm tra mật khẩu

            PasswordValidator validator = new PasswordValidator();

            Console.WriteLine("Nhập mật khẩu: ");
            string password = Console.ReadLine();

            if (validator.IsValidPassword(password))
            {
                Console.WriteLine("Mật khẩu hợp lệ.");
            }
            else
            {
                Console.WriteLine("Mật khẩu không hợp lệ. Mật khẩu phải có ít nhất 8 ký tự, bao gồm ít nhất một chữ hoa, một chữ thường và một số.");
            }
            //--------------------------------------------------------------------------------------------------------------------

            // Âm lịch
            Console.Write("Nhập năm dương lịch: ");
            int namDuongLich = Convert.ToInt32(Console.ReadLine());

            string amLich = AmLich.ChuyenNamdDuongSangAmLich(namDuongLich);
            Console.WriteLine("Âm lịch tương ứng: " + amLich);
            //--------------------------------------------------------------------------------------------------------------------
            Console.ReadLine();
        }
    }
}
