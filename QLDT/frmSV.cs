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
    public partial class frmSV : Form
    {
        const string cnStr = "Server=LAPTOP-DUYCOP\\SQLEXPRESS;Database=QLDT;Trusted_Connection=True;";
        LibDB.SqlServer db = new LibDB.SqlServer(cnStr);
        public frmSV()
        {
            InitializeComponent();
        }
        void Display(SqlCommand cm)
        {
            dgv.DataSource = db.Query(cm);
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        void ListAll()
        {
            //có sẵn SP_SV, action='LIST_ALL' sẽ có kq như ý
            SqlCommand cm = db.GetCmd("SP_SV", "LIST_ALL");
            Display(cm);
        }
        void Search(string q)
        {
            SqlCommand cm = db.GetCmd("SP_SV", "SEARCH_SV");
            cm.Parameters.Add("@q", SqlDbType.NVarChar, 50).Value = q;
            Display(cm);
        }

        void PassParameters(ref SqlCommand cm, SV sv)
        {
            cm.Parameters.Add("@masv", SqlDbType.VarChar, 13).Value = sv.masv;
            cm.Parameters.Add("@hoten", SqlDbType.NVarChar, 50).Value = sv.hoten;
            cm.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = sv.ngaysinh;
            cm.Parameters.Add("@gt", SqlDbType.Bit).Value = sv.gt;
            cm.Parameters.Add("@maNganh", SqlDbType.Int).Value = sv.maNganh;
        }
        int AddSV(SV sv)
        {
            SqlCommand cm = db.GetCmd("SP_SV", "ADD_SV");
            PassParameters(ref cm, sv);
            return db.RunSQL(cm);
        }
        int EditSV(SV sv, string masv_cu)
        {
            SqlCommand cm = db.GetCmd("SP_SV", "Edit_SV");
            PassParameters(ref cm, sv);
            cm.Parameters.Add("@masv_cu", SqlDbType.VarChar, 13).Value = masv_cu;
            return db.RunSQL(cm);
        }
        DateTime GetDate(string strDate)
        {
            try
            {
                if (strDate == null || strDate == "")
                    return DateTime.Now;
                else
                    return
                         DateTime.Parse(strDate);
            }
            catch
            {
                return DateTime.Now;
            }
        }
        SV Get1SV(string masv)
        {
            SqlCommand cm = db.GetCmd("SP_SV", "GET_1_SV");
            cm.Parameters.Add("@masv", SqlDbType.VarChar, 13).Value = masv;
            DataTable dt = db.Query(cm);
            SV sv = new SV();
            sv.masv = (string)dt.Rows[0]["masv"];
            sv.hoten = (string)dt.Rows[0]["hoten"];
            sv.ngaysinh = GetDate(dt.Rows[0]["ngaysinh"].ToString());
            sv.gt = (bool)dt.Rows[0]["GT"];
            sv.maNganh = (int)dt.Rows[0]["maNganh"];
            return sv;
        }
        private void btnListAll_Click(object sender, EventArgs e)
        {
            ListAll();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditSV f = new frmAddEditSV();
            f.db = db; //truyền đối tượng thao tác csdl sang cho f
            if (f.ShowAdd(this) == DialogResult.OK)
            {
                try
                {
                    SV sv = f.sv; //đây là data fcon nhập đc, bố add vào db
                    int kq = AddSV(sv);
                    if (kq == 1)
                        ListAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //phải lấy đc key==masv của row đang chọn
            if (dgv.SelectedRows.Count > 0)
            {
                string masv = (string)(dgv.SelectedRows[0].Cells["masv"].Value);
                //gọi form con lên để edit
                //cần truyền những thứ có sẵn
                //bố lấy all info of row selected => SV để truyền sang
                SV sv = Get1SV(masv);

                frmAddEditSV f = new frmAddEditSV();
                f.db = db;
                f.sv = sv; //truyền đối tượng cần sửa sang form sửa
                if (f.ShowEdit(this) == DialogResult.OK)
                {
                    try
                    {
                        //cập nhật lại thông tin trong db
                        //nợ SP action=EDIT_SV
                        int kq = EditSV(f.sv, sv.masv);
                        if (kq == 1) ListAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR");
                    }
                }
            }
        }
    }
}
