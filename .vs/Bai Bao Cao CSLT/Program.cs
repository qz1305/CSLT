using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Bao_Cao_CSLT
{
    internal class Program
    {
        static double XacDinhGoc(double a, double b, double c)
        {
            double GiatriGoc = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            return Math.Acos(GiatriGoc) * (180 / Math.PI);
        }
        static void Bai1()
        {
            Console.Write("Nhập giá trị a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị c = ");
            double c = double.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double gocA = XacDinhGoc(a, b, c);
                double gocB = XacDinhGoc(b, a, c);
                double gocC = XacDinhGoc(c, a, b);

                Console.WriteLine($"Ba cạnh {a}, {b}, và {c} tạo thành một tam giác.");
                Console.WriteLine($"Góc A: {gocA} độ");
                Console.WriteLine($"Góc B: {gocB} độ");
                Console.WriteLine($"Góc C: {gocC} độ");
            }
            else
            {
                Console.WriteLine($"Ba cạnh {a} {b} {c} không tạo thành tam giác.");
            }
        }
        static void Bai2()
        {
            Console.Write("Nhập m: ");
            int m = int.Parse(Console.ReadLine());
            double s = 0;
            for (int i = m + 1; i >= 1; i--)
            {
                s = Math.Pow(i + s, 1.0 / (m + 1));
            }
            Console.WriteLine($"gia tri tong la : {s}");
        }
        static void InMang(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
        static void Bai3()
        {
            Console.Write("Nhập số hạng n của dãy Fibonacci: ");
            int n = int.Parse(Console.ReadLine());
            int[] Mangfibonacci = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    Mangfibonacci[i] = i;
                }
                else
                {
                    Mangfibonacci[i] = Mangfibonacci[i - 1] + Mangfibonacci[i - 2];
                }
            }
            Console.Write($"{n} số hạng đầu tiên của dãy Fibonacci là:\t");
            InMang(Mangfibonacci);
        }
        static void Bai5()
        {
            Console.WriteLine("Nhập chuỗi: ");
            string input = Console.ReadLine();
            string kq = "";
            bool KiTuKeTiep = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (KiTuKeTiep)
                {
                    kq += char.ToUpper(input[i]);
                    KiTuKeTiep = false;
                }
                else
                {
                    if (char.IsWhiteSpace(input[i]))
                    {
                        kq += input[i];
                        KiTuKeTiep = true;
                    }
                    else
                    {
                        kq += char.ToLower(input[i]);
                    }
                }
            }
            Console.WriteLine("Kết quả: " + kq);
        }
        static void Bai6()
        {
            Console.Write("Mời nhập họ tên quí ông/bà : ");
            string tendaydu = Console.ReadLine();
            Console.Write("Số ngày quí ông/bà ở khách sạn : ");
            int SoNgayO = int.Parse(Console.ReadLine());
            Console.Write("Số bữa ăn của quí ông/bà : ");
            int SoBuaAn = int.Parse(Console.ReadLine());
            Console.Write("Tiền ở một ngày của quí ông/bà : ");
            int TienOMotNgay = int.Parse(Console.ReadLine());
            Console.Write("Tiền ăn mỗi bữa của quí ông/bà : ");
            int TienAnMoiBua = int.Parse(Console.ReadLine());
            Console.Write("Phí dịch vụ của quí ông/bà : ");
            int PhiDichVu = int.Parse(Console.ReadLine());
            int TienO = SoNgayO * TienOMotNgay;
            int TienAn = SoBuaAn * TienAnMoiBua;
            int TongCong = TienO + TienAn + PhiDichVu;
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("Khách sạn Five Stars");
            Console.WriteLine("Hóa đơn khách sạn");
            Console.WriteLine("Quý ÔNG(BÀ): " + tendaydu);
            Console.WriteLine("Số ngày ở: " + SoNgayO + "\t\t| Số bữa ăn: " + SoBuaAn);
            Console.WriteLine("Tiền ở: " + TienO + "\t\t| Tiền ăn: " + TienAn + "\t\t| Phí phục vụ: " + PhiDichVu);
            Console.WriteLine($"Tổng cộng: {TongCong} VNĐ");
            Console.WriteLine("\t\t\tHân hạnh phục vụ quý khách ");
            Console.WriteLine("********************************************************************************************");
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t\t\t\t\t\tĐỒ ÁN: CƠ SỞ LẬP TRÌNH");
            Console.WriteLine("\t\t\t\t     SINH VIÊN: NGUYỄN VIỆT QUANG, LỚP: CY0001");
            Console.WriteLine("\t\t\t\t     SINH VIÊN: THÓNG PHƯƠNG DOANH, LỚP: CY0001");
        bắtđầu:
            Console.WriteLine("\t\t\tMENU");
            Console.WriteLine("BÀI 1: Nhập vào 3 số,kiểm tra chúng có tạo thành 3 cạnh của một tam giác không?Tính ba góc của tam giác đó(nếu thỏa mãn)");
            Console.WriteLine("BÀI 2: Tính P ");
            Console.WriteLine("BÀI 3: Dùng mảng 1 chiều để in ra n số hạng đầu tiên của dãy số Fibonacci");
            Console.WriteLine("BÀI 5: Đọc vào một chuỗi, đổi sang chuỗi chữ hoa đầu mỗi từ\nVí dụ S=”Cong nghe thong tin KINH doaNH”\nKết quả in ra ”Cong Nghe Thong Tin Kinh Doanh”");
            Console.WriteLine("BÀI 6: In hóa đơn tính tiền");
            Console.Write("Vui lòng chọn yêu cầu của bạn: ");
            char input = Console.ReadKey().KeyChar;
            Console.Clear();
            if (input == '1')
            {
                Console.WriteLine("BÀI 1: Nhập vào 3 số,kiểm tra chúng có tạo thành 3 cạnh của một tam giác không?Tính ba góc của tam giác đó(nếu thỏa mãn)");
                Bai1();
                Console.WriteLine("\n\n\n!!!!!!!!!!\tHãy bấm Enter để quay về menu\t!!!!!!!!!!!");
                Console.ReadKey();
                Console.Clear();
                goto bắtđầu;
            }
            else if (input == '2')
            {
                Console.WriteLine("BÀI 2: Tính P");
                Bai2();
                Console.WriteLine("\n\n\n!!!!!!!!!!\tHãy bấm Enter để quay về menu\t!!!!!!!!!!!");
                Console.ReadKey();
                Console.Clear();
                goto bắtđầu;
            }
            else if (input == '3')
            {
                Console.WriteLine("BÀI 3: Dùng mảng 1 chiều để in ra n số hạng đầu tiên của dãy số Fibonacci");
                Bai3();
                Console.WriteLine("\n\n\n!!!!!!!!!!\tHãy bấm Enter để quay về menu\t!!!!!!!!!!!");
                Console.ReadKey();
                Console.Clear();
                goto bắtđầu;
            }
            else if (input == '5')
            {
                Console.WriteLine("BÀI 5: Đọc vào một chuỗi, đổi sang chuỗi chữ hoa đầu mỗi từ\nVí dụ S=”Cong nghe thong tin KINH doaNH”\nKết quả in ra ”Cong Nghe Thong Tin Kinh Doanh”");
                Bai5();
                Console.WriteLine("\n\n\n!!!!!!!!!!\tHãy bấm Enter để quay về menu\t!!!!!!!!!!!");
                Console.ReadKey();
                Console.Clear();
                goto bắtđầu;
            }
            else if (input == '6')
            {
                Console.WriteLine("BÀI 6: In hóa đơn tính tiền");
                Bai6();
                Console.WriteLine("\n\n\n!!!!!!!!!!\tHãy bấm Enter để quay về menu\t!!!!!!!!!!!");
                Console.ReadKey();
                Console.Clear();
                goto bắtđầu;
            }
            Console.ReadKey();
        }
    }
}
