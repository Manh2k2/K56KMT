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

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CapNhatTime();
        }

        void CapNhatTime()
        {
            this.Text = "Demo for 56KMT - " + DateTime.Now.ToString("dd/MM/yyy - HH:mm:ss");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatTime();
        }
    }
}
