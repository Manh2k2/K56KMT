﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //lấy input của người dùng nhập trên webform
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(TextBox2.Text);
            double c = double.Parse(TextBox3.Text);

            //gọi tv, truyền ts-> kq
            libGPT.GPTB2 gptb2 = new libGPT.GPTB2(a, b, c);
            gptb2.Giai();  //gọi 1 method Giai để thu đc kq ko dấu, ko dùng

            //in ra form: dùng kq
            string kq = "";
            if (gptb2.loaiKQ == libGPT.LoaiKQ.KO_PHAI_PTB2)
                kq = "Hệ số a==0 thì vô lý!";
            else if (gptb2.loaiKQ == libGPT.LoaiKQ.VO_NGHIEM)
                kq = "Phương trình bậc 2 ko có nghiệm thực";
            else if (gptb2.loaiKQ == libGPT.LoaiKQ.NGHIEM_KEP)
                kq = $"Phương trình bậc 2 có 2 nghiệm thực bằng nhau x<sub>1</sub>=x<sub>2</sub>={gptb2.x1}";
            else if (gptb2.loaiKQ == libGPT.LoaiKQ.HAI_NGHIEM)
                kq = $"Phương trình bậc 2 có 2 nghiệm thực khác nhau<br> x<sub>1</sub>={gptb2.x1}<br> x<sub>2</sub>={gptb2.x2}";

            ketqua.InnerHtml = kq;
        }
    }
}