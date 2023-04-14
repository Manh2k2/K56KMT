using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //DÀNH CHO VIỆC THAO TÁC VỚI EXCEL
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace db_Excel
{
    public partial class frmExcel : Form
    {
        public frmExcel()
        {
            InitializeComponent();
        }

        DataTable GetData(String SQL)
        {
            //step1: kết nối dùng sqlConnection (sql server), với excel: OleDbConnection
            OleDbConnection cn = new OleDbConnection();
            //chuỗi kết nối: tham khảo mục Xlsx files / Microsoft ACE OLEDB 12.0 /  https://www.connectionstrings.com/excel/
            cn.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={txtExcelPath.Text};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";"; 
            cn.Open();

            //step2: chạy lệnh sql
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandText = SQL;
            OleDbDataReader dr=cmd.ExecuteReader();

            //step2.5 Tải dữ liệu đọc đc vào biến loại DataTable
            DataTable dt = new DataTable();
            dt.Load(dr);

            //giải phóng tài nguyên
            dr.Close();
            cn.Close();
            cn.Dispose();
            
            return dt;
        }

        private void cmdViewAll_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData("Select A.*,([stc môn1]*[điểm môn1]+[stc môn2]*[điểm môn2])/([stc môn1]+[stc môn2]) as [Điểm TBHK] from [Sheet1$] A order by 10 desc");
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData("Select * from [Sheet1$] where [ho] like 'Nguyễn%'");
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stt	ho	Tên	que quán	số điện thoại	stc môn1	điểm môn1	stc môn2	điểm môn2

            string sql = "insert into [Sheet1$]([stt],[ho],[Tên],[que quán],[số điện thoại],[stc môn1],[điểm môn1],[stc môn2],[điểm môn2])values(100,'Công tằng','Tôn nữ Nguyệt Hoa','Bắc Ninh','113',7,1,9,2.5)";
            GetData(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "update [Sheet1$] set ho='Dương' where ho='Phạm'";
            GetData(sql);
        }
    }
}
