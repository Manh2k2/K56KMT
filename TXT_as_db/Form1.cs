using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace db_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string TXT_DB = "TI_GIA.TXT";
        const string LOG_DB = "LOG.TXT";
        struct BlockData
        {
            public int tigia, dolar;
        }
        BlockData LoadDB()
        {
            BlockData data=new BlockData();
            try
            {
                string[] s = File.ReadAllLines(TXT_DB, System.Text.Encoding.UTF8);
                //s ở 2 line
                data.tigia = int.Parse(s[0]);
                data.dolar = int.Parse(s[1]);
            }
            catch
            {
                data.tigia = 0;
                data.dolar = 0;
            }
            return data;
        }
        void SaveDB(BlockData data)
        {
            string txt = $"{data.tigia}\r\n{data.dolar}";
            System.IO.File.WriteAllText(TXT_DB, txt, System.Text.Encoding.UTF8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //lấy tỉ giá
            //lưu tỉ giá -> db


            //lấy $ x tỉ giá => kq (vnd)
            BlockData data = new BlockData();
            data. tigia = int.Parse(txtTiGia.Text);
            data. dolar = int.Parse(txtDOLAR.Text);
            SaveDB(data);
            int vnd = data.dolar * data.tigia;
            txtVND.Text = $"{vnd}";

            string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string log = $"--------{time}------------\r\n{data.dolar} x {data.tigia} = {vnd}\r\n";
            System.IO.File.AppendAllText(LOG_DB, log, System.Text.Encoding.UTF8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //khi form tải lên Event frm_Load auto run
            //tải tỉ giá lưu trong db (lần cuối cập nhật) -> ô hiển thị tỉ giá txtTiGia

            BlockData data = LoadDB();
            txtTiGia.Text=$"{data.tigia}";
            txtDOLAR.Text = $"{data.dolar}";
        }
    }
}
