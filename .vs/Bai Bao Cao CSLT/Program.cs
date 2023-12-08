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
        static long Tongtien(object[] khach)
        {
            return (long)((int)khach[1] * (int)khach[3] + (int)khach[2] * (int)khach[4] + (int)khach[5]);
        }
        static long Tienan(object[] khach)
        {
            return (long)((int)khach[2] * (int)khach[4]);
        }
        static long Tieno(object[] khach)
        {
            return (long)((int)khach[1] * (int)khach[3]);
        }
        static void NhapTT1khach(object[] khach)
        {
            Console.WriteLine("Nhập tên khách hàng: ");
            khach[0] = Console.ReadLine();
            Console.WriteLine("Nhập số ngày ở: ");
            khach[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số bữa ăn: ");
            khach[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tiền ở 1 ngày: ");
            khach[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tiền ăn 1 bữa: ");
            khach[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phí phục vụ: ");
            khach[5] = int.Parse(Console.ReadLine());
        }
        static string XuatTT1khach(object[] khach)
        {
            long TongTien = (long)((int)khach[1] * (int)khach[3] + (int)khach[2] * (int)khach[4] + (int)khach[5]);
            long TienAn = (long)((int)khach[2] * (int)khach[4]);
            long TienO = (long)((int)khach[1] * (int)khach[3]);
            string result = "";
            result += "\n********************************************************************\n\t\t\tKHÁCH SẠN FIVE STAR\n";
            result += "Hóa đơn khách sạn: \n";
            result += $" Quí Ông(Bà): [{khach[0]}]\n";
            result += $" Số ngày ở [{khach[1]}]";
            result += $" \t\tSố bữa ăn [{khach[2]}]\n";
            result += $" Tiền ăn: {Tienan(khach)} VNĐ\n";
            result += $" \t\tTiền ở: {Tieno(khach)} VNĐ\n";
            result += $" \t\tPhí phục vụ [{khach[5]}] VNĐ\n";
            result += $" Tổng cộng: {Tongtien(khach)} VNĐ\n";
            result += "\t\t\tHân hạnh phục vụ quí khách\n********************************************************************\n";
            return result;
        }
        static void NhapTTcackhach(object[][] khachs)
        {
            for (int i = 0; i < khachs.Length; i++)
            {
                Console.WriteLine($">> Nhập thông tin khách hàng {i + 1}");
                NhapTT1khach(khachs[i]);
            }
        }
        static string XuatTTcackhach(object[][] khachs)
        {
            string result = "";
            for (int i = 0; i < khachs.Length; i++)
                result += XuatTT1khach(khachs[i]) + "\n\n";
            return result;
        }
        static object[][] KhoiTaoMangKhach(int n)
        {
            object[][] khachs = new object[n][];
            for (int i = 0; i < khachs.Length; i++)
                khachs[i] = new object[6];
            return khachs;
        }
        static void Bai6()
        {
            object[][] khachs = KhoiTaoMangKhach(6);
            NhapTTcackhach(khachs);
            Console.WriteLine(XuatTTcackhach(khachs));
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
            Console.WriteLine("BÀI 6: Cho mảng nhiều chiều gồm có các thông tin liên quan đến khách lưu trú ở khách sạn. Khách gồm các thông tin: họ tên, số ngày ở, số bữa an, tiền ở (1 ngày), tiền ăn (1 bữa), phí phục vụ. Phân tích và viết chương trình tính tiền trọ khách sạn. In hóa đơn tính tiền lên màn hình.");
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
