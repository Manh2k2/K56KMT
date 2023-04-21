using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLDT
{
    public partial class frmAddEditSV : Form
    {
        public frmAddEditSV()
        {
            InitializeComponent();
        }
        public LibDB.SqlServer db; //để bố truyền sang
        public SV sv;
        List<Nganh> listNganh = new List<Nganh>();
        public DialogResult ShowAdd(Form papa)
        {
            this.Text = "Thêm 1 sv mới";
            btnOK.Text = "Thêm SV";
            LoadNganh();
            return this.ShowDialog(papa);
        }
        public DialogResult ShowEdit(Form papa)
        {
            this.Text = "Sửa thông tin 1 sv cũ";
            btnOK.Text = "Cập nhật";
            //cập nhật các giá trị lên form
            txtMasv.Text = sv.masv;
            txtHoten.Text = sv.hoten;
            dateNS.Value = sv.ngaysinh;
            if (sv.gt)
                gtNam.Checked = true;
            else
                gtNu.Checked = true;

            LoadNganh();
            foreach (var item in listNganh)
            {
                if (item.maNganh == sv.maNganh)
                {
                    //show nó lên
                    cboNganh.Text = item.tenNganh;
                    break;
                }
            }
            return this.ShowDialog(papa);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //thêm sv
            //đưa toàn bộ data người dùng nhập vào 1 obj SV
            sv = new SV();
            sv.masv = txtMasv.Text;
            sv.hoten = txtHoten.Text;
            sv.gt = gtNam.Checked;
            sv.ngaysinh = dateNS.Value;
            int index = cboNganh.SelectedIndex;
            sv.maNganh = listNganh[index].maNganh;
            //việc thêm sv để bố làm
        }
        

        void LoadNganh()
        {
            SqlCommand cm = db.GetCmd("SP_SV", "LIST_NGANH");
            DataTable dt = db.Query(cm);
            //list dt -> combo Nganh
            foreach (DataRow r in dt.Rows)
            {
                Nganh n = new Nganh();
                n.maNganh = (int)r["maNganh"];
                n.tenNganh = (string)r["tenNganh"];
                listNganh.Add(n);
                cboNganh.Items.Add(n.tenNganh);
            }
            cboNganh.SelectedIndex = 0;//first is show
        }
        
    }
}
