using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FaceUnikey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//ket thuc form1 <=> close app
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //bé: h=207
            //to: h=491
            button7.Text = $"w={this.Width}  h={this.Height} ";
        }
        const int H_BE = 276;
        const int H_TO = 491;
        bool kt_be;
        void change_size(bool lam_luon = false)
        {
            if (kt_be)
            {
                if (lam_luon) this.Height = H_BE;
                btn_ToNho.Text = "&Phóng to";
                btn_ToNho.Image = Properties.Resources.mui_ten_xuong;
                g2.Hide();
                g3.Hide();
                g4.Hide();
            }
            else //to
            {
                if (lam_luon) this.Height = H_TO;
                btn_ToNho.Text = "Thu &nhỏ"; //& trước kí tự nào thì GUI: ALT+kí tự đó <=> click vào đấy
                btn_ToNho.Image = Properties.Resources.mui_ten_len;
                g2.Show();
                g3.Show();
                g4.Show();
            }

            //g2.Visible = g3.Visible = g4.Visible = !kt_be;
            if (!lam_luon)
                timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kt_be = true;
            change_size(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kt_be = !kt_be;
            change_size();
        }

        const int DELTA_H = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kt_be)
            {
                //đang size to -> muốn về size bé
                if (this.Height > H_BE)
                {
                    if (this.Height - DELTA_H > H_BE)
                        this.Height -= DELTA_H;
                    else
                    {
                        this.Height = H_BE;
                        timer1.Stop();
                    }
                }
            }
            else
            {
                //đang size bé -> muốn về size to
                if (this.Height + DELTA_H < H_TO)
                    this.Height += DELTA_H;
                else
                {
                    this.Height = H_TO;
                    timer1.Stop();
                }
            }
        }
    }
}
