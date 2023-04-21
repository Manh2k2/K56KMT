using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QLDT
{
    public class SV
    {
        public string masv, hoten;
        public bool gt;
        public DateTime ngaysinh;
        public int maNganh;
    }

    public class Nganh
    {
        public int maNganh;
        public string tenNganh;
    }
}
