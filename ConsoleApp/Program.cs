using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //gioi thieu chuong trình làm gì
            Console.WriteLine("GIAI PHUONG TRINH BAC 2: AX^2+BX+C=0");

            //lấy input từ bàn phím
            Console.Write("Nhap he so A=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so B=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so C=");
            double c = double.Parse(Console.ReadLine());

            //sử dụng thư viện
            //khai báo biến : libGPT.GPTB2 gptb2
            //= new libGPT.GPTB2 <=> tạo đối tượng
            //GPTB2(a, b,c);  : truyền tham số cho hàm tạo của lớp  GPTB2

            libGPT.GPTB2 gptb2 = new libGPT.GPTB2(a, b,c);
            string kq = gptb2.Giai();  //gọi 1 method Giai để thu đc kq

            //in ra màn hình
            Console.WriteLine(kq);


            Console.ReadKey(true);  //đợi bấm 1 phím bất kì, ko show kí tự đó lên
        }
    }
}
