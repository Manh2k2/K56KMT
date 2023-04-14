using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace db_SqlServer
{
    public partial class frmSqlServer : Form
    {
        public frmSqlServer()
        {
            InitializeComponent();
        }


        //view all ds sv
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            //gọi hàm để sql->data
            DataTable dt = getData("select *  from sv order by stt");
            dataGridView1.DataSource = dt; //data -> display
        }


        //hàm dùng nhiều lần
        DataTable getData(string sql, int id_dd = 0, CommandType loaiSQL = CommandType.Text, string masv = null, int target=-1)
        {
            /* quy trình lấy data from sql server
            * step1: kết nối tới db, dùng đối tượng kết nối: SqlConnection
            *   tạo đt
            *   gắn chuỗi kết nối: tra cứu https://www.connectionstrings.com/
            *   open() : đây là kết nối
            * step2: sử dụng đối tượng thực thi lệnh SQL : SqlCommand
            *   tạo đối tượng, gắn với đối tượng kết nối
            *   gắn chuỗi sql: chuỗi này sẽ quyết định lấy data gì
            *   truyền tham số (nếu có)
            *   gọi phương thức để lấy dữ liệu -> biến
            * step3: view kết quả
            *   xứ lý biến nhận được -> chuyển về dạng dataTable
            *   đưa lên đối tượng hiển thị: DataGridView
            */

            //step1:
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=LAPTOP-DUYCOP\\SQLEXPRESS;Database=svKMT_tnut;Trusted_Connection=True;";
            sqlConnection.Open();

            //step2
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = loaiSQL;
            sqlCommand.CommandText = sql;
            if (id_dd != 0)
            {
                //truyền tham số
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id_dd;
            }
            if (target != -1)
            {
                //truyền tham số
                sqlCommand.Parameters.Add("@target", SqlDbType.Int).Value = target;
            }
            if (masv != null)
            {
                //truyền tham số
                sqlCommand.Parameters.Add("@masv", SqlDbType.NVarChar, 50).Value = masv;
            }
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            //step3
            DataTable dt = new DataTable();
            dt.Load(sdr); //lấy toàn bộ dữ liệu trong sdr vào dt

            //giải phóng bộ nhớ
            sqlCommand.Dispose();
            sqlConnection.Close();
            sqlConnection.Dispose();

            //trả về dữ liệu
            return dt;
        }
        List<int> MangID = new List<int>();
        private void cmdLoadID_DD_Click(object sender, EventArgs e)
        {
            DataTable dt_dd = getData("select * from DiemDanh");
            comboBox1.Items.Clear(); //xoá sạch
            MangID.Clear();
            foreach (DataRow dr in dt_dd.Rows)
            {
                comboBox1.Items.Add($"id={dr["id"]} ngày {dr["ngay"]}");
                MangID.Add((int)dr["id"]);
            }
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            int firstView = dataGridView1.FirstDisplayedScrollingRowIndex;
            int index_selected = -1;
            bool dang_selected = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dang_selected = true;
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                index_selected = r.Index;
            }

            int index = comboBox1.SelectedIndex;
            int id = MangID[index];
            DataTable dt = getData("SP_DiemDanh", id, CommandType.StoredProcedure);
            dataGridView1.DataSource = dt;

            if (dang_selected && index_selected > -1)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = firstView;
                dataGridView1.Rows[index_selected].Selected = true;
            }
        }

        private void btnUpdateMuon_Click(object sender, EventArgs e)
        {
            BienDoi("Vắng mặt", 2);
        }

        void BienDoi(string From, int target) { 

            //target=0: đi học
            //       1: vắng
            //       2: muộn
            //   ko lưu (null) đi học
            //chọn 1 dòng trên lưới
            //nếu dòng đó nói sv Vắng mặt
            //thì: lấy masv, id buổi điểm danh
            //trường: Vang ==1 <=> Vắng mặt
            //change: Vang -> 2 <=> Muộn

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int firstView = dataGridView1.FirstDisplayedScrollingRowIndex;

                //bỏ multi: nên chỉ có 1 row đc chọn
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                int index_selected = r.Index; //lưu index của thằng -> Muộn
                string masv = r.Cells["masv"].Value.ToString();

                int index = comboBox1.SelectedIndex;
                int id = MangID[index];

                string kq = r.Cells["Điểm Danh"].Value.ToString();

                if (kq == From)
                {
                    //tương tác db để biến sv này Vắng -> Muộn
                    string sql = "sp_biendoi";
                    getData(sql, id, CommandType.StoredProcedure, masv, target);

                    //tự động tải lại ds, 
                    btnChiTiet_Click(null, null);
                    //dòng update->Muộn vẫn là dòng đang chọn
                    dataGridView1.Rows[index_selected].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = firstView;
                   //MessageBox.Show("OK");
                }
                else
                    MessageBox.Show($" sv massv = {masv} : {kq}", "Không xử lý");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                btnChiTiet_Click(sender, e);
            }
        }

        private void mnuVang_Muon_Click(object sender, EventArgs e)
        {
            BienDoi("Vắng mặt", 2);
        }

        private void mnuMuon_Vang_Click(object sender, EventArgs e)
        {
            BienDoi("Đi muộn", 1);
        }

        private void mnuVang_diHoc_Click(object sender, EventArgs e)
        {
            BienDoi("Vắng mặt", 0);
        }

        private void mnuDihoc_Vang_Click(object sender, EventArgs e)
        {
            BienDoi("Đi học", 1);
        }
    }
}
