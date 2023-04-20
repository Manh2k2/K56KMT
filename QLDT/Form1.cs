using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient; //app chúng ta là SQL_Client với SQL_Server

namespace QLDT
{
    public partial class Form1 : Form
    {
        const string cnStr = "Server=LAPTOP-DUYCOP\\SQLEXPRESS;Database=QLDT;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnListLop_Click(object sender, EventArgs e)
        {
            //step1: kết nối tới csdl
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();

            //step2: thực thi 1 sql: dạng Store Procedure
            SqlCommand cm = new SqlCommand("SP_MoLop", cn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@action", SqlDbType.NVarChar, 50).Value = "List_Lop";
            cm.Parameters.Add("@MinSL", SqlDbType.Int).Value = (int)MinSL.Value;
            cm.Parameters.Add("@MaxLop", SqlDbType.Int).Value = (int)MaxLop.Value;
            SqlDataReader dr = cm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            //step3: dọn dẹp
            dr.Close();
            cm.Dispose();
            cn.Close();
            cn.Dispose();

            //step4: display
            dataGridView1.DataSource = dt;
            dt.Dispose();
        }

        private void CmdMoLop_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();

            //step2: thực thi 1 sql: dạng Store Procedure
            SqlCommand cm = new SqlCommand("SP_MoLop", cn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@action", SqlDbType.NVarChar, 50).Value = "Mo_Lop";
            cm.Parameters.Add("@MinSL", SqlDbType.Int).Value = (int)MinSL.Value;
            cm.Parameters.Add("@MaxLop", SqlDbType.Int).Value = (int)MaxLop.Value;
            cm.Parameters.Add("@maDot", SqlDbType.Char, 5).Value = cboDot.Text;
            SqlDataReader dr = cm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            //step3: dọn dẹp
            dr.Close();
            cm.Dispose();
            cn.Close();
            cn.Dispose();

        }
    }
}
