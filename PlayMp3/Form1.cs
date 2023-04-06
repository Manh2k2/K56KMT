using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlayMp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = "https://github.com/duycop/K56KMT/raw/master/PlayMp3/Heal%20The%20World%20(Michael%20Jackson).mp3";
        }
    }
}
