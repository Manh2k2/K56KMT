using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace db_Json
{
    public partial class frmJson : Form
    {
        public frmJson()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SV sv = new SV();  //tạo đối tượng

            //gán giá trị theo form người dùng nhập vào
            sv.ten = txtTen.Text;
            sv.tuoi = (int)(numTuoi.Value);
            sv.diem = SV.Gen3Diem(txtToan.Text, txtLy.Text, txtHoa.Text);

            //lưu file mà data dưới dạng json
            sv.SaveDB();

            MessageBox.Show(sv.ToJson(),"Json review");
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            SV sv = new SV();           //tạo đối tượng
            sv.LoadDB();                //load dữ liệu

            txtTen.Text = sv.ten;       //show lên form
            numTuoi.Value = sv.tuoi;    //show lên form
            if (sv.diem != null && sv.diem.Count == 3) //riêng List thì check trước
            {
                txtToan.Text = sv.diem[0].ToString();
                txtLy.Text = sv.diem[1].ToString();
                txtHoa.Text = sv.diem[2].ToString();
            }

            MessageBox.Show(sv.ToJson(), "Json review");
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            //xoá mọi thứ trên form
            txtTen.Clear();
            numTuoi.Value = 0;
            txtToan.Clear();
            txtLy.Clear();
            txtHoa.Clear();
        }
    }
}
