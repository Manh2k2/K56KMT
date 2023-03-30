using System;
using System.Collections.Generic;
using System.Text;

namespace libChuanHoaXau
{
    public class ChuanHoa
    {
        string fullname;

        /// <summary>
        /// contructor: ko có kiểu, trùng tên với class
        /// </summary>
        /// <param name="fullname">Đầu vào chưa chuẩn hoá</param>
        public ChuanHoa(string fullname)
        {
            this.fullname = fullname;
        }
        /// <summary>
        /// Hàm này sẽ chuẩn hoá xâu,
        ///  nó kill all spaces first and last,
        ///  nó cũng kill spaces at mid
        /// </summary>
        /// <returns>Chuỗi đã làm đẹp, đã chuẩn hoá, đã ok, viết thường, Hoa chữ cái đầu</returns>
        public String LamDep()
        {
            //loại bỏ dấu cách thừa 2 đầu chuỗi , rồi làm thành chuỗi chữ thường
            string ok = fullname.Trim().ToLower();
            string kq = "";
            bool vua_co_space = false; //đánh dấu vừa gặp space
            for (int i = 0; i < ok.Length; i++)
            {
                char x = ok[i];
                if (x != ' ' && (i == 0 || (i > 0 && ok[i - 1] == ' ')))
                {
                    //chuyển kí tự x thành chuỗi 1 kí tự,
                    //rồi gọi toUpper để chuyển thành chữ HOA
                    kq += $"{x}".ToUpper();
                }
                else
                {
                    //nếu kí tự trước là space và kí tự này cũng là space
                    //thì ko làm, phủ định điều này : ko phải 2 space liên tiếp
                    if (!(vua_co_space && x == ' '))
                        kq += x; //thì ghép x vào cuối chuỗi kq
                }
                vua_co_space = x == ' ';
            }
            return kq;  //trả về kết quả đã làm đẹp
        }
    }
}
