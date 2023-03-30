using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testNhieuForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] sep = { '\n', '\r' }; //sep này sẽ tách các dòng với nhau
            string[] dsTen = textBox1.Text.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            textBox1.Clear();
            foreach (string ten in dsTen)
            {
                libChuanHoaXau.ChuanHoa ch = new libChuanHoaXau.ChuanHoa(ten);
                string kq = ch.LamDep();
                textBox1.AppendText(kq + "\r\n");
            }
        }

        frmAbout fAbout;  //fAbout khai báo như này thì fAbout==null
        private void button2_Click(object sender, EventArgs e)
        {
            if (fAbout == null || fAbout.IsDisposed) 
                fAbout = new frmAbout(); //chỉ tạo mới khi chưa có hoặc đã đóng
            this.Hide(); //ẩn form1 đi
            fAbout.Show();  //hiển frm About
        }
    }
}
