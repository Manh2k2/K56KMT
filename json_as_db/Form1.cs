using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace db_Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class SV
        {
            public string ten;
            public int tuoi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SV sv1 = new SV();
            sv1.ten = textBox1.Text;
            sv1.tuoi = (int)numericUpDown1.Value;

            string json = JsonConvert.SerializeObject(sv1);
            //lưu json text to file
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //đọc json text từ file
            string json = ".....";
            SV sv = JsonConvert.DeserializeObject<SV>(json);
            textBox1.Text = sv.ten;
            numericUpDown1.Value = sv.tuoi;
        }
    }
}
