using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppGPTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lấy input của người dùng nhập trên form
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

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
                kq = $"Phương trình bậc 2 có 2 nghiệm thực bằng nhau x1=x2={gptb2.x1}";
            else if (gptb2.loaiKQ == libGPT.LoaiKQ.HAI_NGHIEM)
                kq = $"Phương trình bậc 2 có 2 nghiệm thực khác nhau\r\n x1={gptb2.x1}\r\n x2={gptb2.x2}";

            textBoxKQ.Text = kq;

        }
    }
}
