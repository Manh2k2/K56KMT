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
            string ok = fullname.Trim().ToLower();
            string kq = "";
            bool vua_co_space = false;
            for (int i = 0; i < ok.Length; i++)
            {
                char x = ok[i];
                if (x != ' ' && (i == 0 || (i > 0 && ok[i - 1] == ' ')))
                {
                    kq += $"{x}".ToUpper();
                }
                else
                {
                    if (!(vua_co_space && x == ' '))
                        kq += x;
                }
                vua_co_space = x == ' ';
            }
            return kq;
        }
    }
}
