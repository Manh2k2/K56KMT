using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace testIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test input multi numbers\nNhap 3 so nguyen: ");
            //int a=Console.Read(); //đợi nhập 1 ký tự (rồi enter), kq trả về là mã ascii của kí tự vừa nhập
            //Console.WriteLine($"a={a}");

            //String s = Console.ReadLine(); //nhập chuỗi
            //char[] sep = { ' ', ',' };
            //String[] Items = s.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            //int a = int.Parse(Items[0]);
            //int b = int.Parse(Items[1]);
            //int c = int.Parse(Items[2]);
            ////AI coPilot
            //int min = a;
            //if (b < min) min = b;
            //if (c < min) min = c;

            //Console.WriteLine($"min of a,b,c={min}");


            //NHập tên bạn, sau đó in ra chuỗi Chuẩn hoá
            //^K+D : làm đẹp code: thò thụt đúng chuẩn
            Console.Write("Nhap ten của ban: ");
            String fullname = Console.ReadLine(); //nhập chuỗi

            //KHAI BÁO BIẾN ch, thuộc namespace libChuanHoaXau, class ChuanHoa
            //=new ...(fullname) : khai báo biến ch có khởi tạo, truyền tham số cho hàm TẠO của class ChuanHoa
            libChuanHoaXau.ChuanHoa ch = new libChuanHoaXau.ChuanHoa(fullname);

            String kq = ch.LamDep();

            Console.WriteLine("Chuoi chuan hoa: [{0}]", kq);
            Console.ReadKey(true);
        }
    }
}
