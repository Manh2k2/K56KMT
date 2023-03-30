using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testNhieuForm
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// sự kiện (event) _FormClosing được tự động chạy khi form này đóng lại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cho frm bố (đã được tạo từ hàm main trong program.cs)
            Program.papa.Show();
        }
    }
}
