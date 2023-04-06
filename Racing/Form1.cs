using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sv = { "Đỗ Tuấn Anh", "Vũ Công Anh", "Nguyễn Tá Anh", "Vũ Ngọc Bình", "Nguyễn Duy Cao", "Hoàng Đức Chung", "Nguyễn Thế Định", "Phommaly Dobee", "Bùi Minh Đức", "Phạm Tuấn Dương", "Phương Minh Duy", "Ma Bách Duy", "Nguyễn Thị Mỹ Duyên", "Đặng Thị Hà", "Đỗ Văn Hiếu", "Hà Trung Hiếu", "Nguyễn Thị Minh Hoa", "Trần Thái Học", "Trần Quang Huy", "Hà Văn Khánh", "Triệu Văn Lương", "Nguyễn Đức Mạnh", "Kouson Mosaky", "Giáp Văn Nam", "Dương Thị Bích Nguyệt", "Dương Văn Ninh", "Hoàng Tràn Phâu", "Vi Duy Quốc", "Pon Sokphal", "Mao Sorakpheanukma", "Nguyễn Ngọc Thái", "Nguyễn Thị Thảo", "Lê Việt Tiến", "Hoàng Mạnh Tiến", "Lê Đức Toàn", "Nguyễn Phương Trâm", "Vũ Ngọc Trang", "Trần Nhật Trường", "Vi Anh Tuấn", "Kun Vengann", "Lưu Viết Vĩ", "Vilaphon Viengsavanh", "Xèn Đức Việt", "Nguyễn Phi Vũ" };
        private void cmdStart_Click(object sender, EventArgs e)
        {
            timerRacing.Enabled = !timerRacing.Enabled;
        }

        Random random = new Random(DateTime.Now.Millisecond);
        Bitmap rmCarColor()
        {
            int r = random.Next(1, 4);
            switch (r)
            {
                case 1:
                    return Properties.Resources.red_car;
                case 2:
                    return Properties.Resources.yellow_car;
                case 3:
                    return Properties.Resources.green_car;
            }
            return Properties.Resources.red_car;
        }
        PictureBox[] allCars;
        private void cmdLoad_Click(object sender, EventArgs e)
        {
            labelKQ1.Text = "1st";
            labelKQ2.Text = "2nd";
            labelKQ3.Text = "3rd";
            timerRacing.Stop();
            timerBlink.Stop();
            if (allCars != null && allCars.Length > 0)
            {
                foreach (PictureBox car in allCars)
                {
                    car.Dispose();
                }
            }
            max = 0;
            int w = 65, h = 13, dw = 35, dh = 50, n = 44;
            allCars = new PictureBox[n];
            for (int i = 0; i < n; i++)
            {
                PictureBox p = new PictureBox();
                p.BackColor = Color.Transparent;
                p.Image = rmCarColor();
                p.Size = new Size(w, h);
                p.Location = new Point(dw, dh + (h + 1) * i);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Tag = i;
                this.toolTip1.SetToolTip(p, $"sv[{i+1}] = {sv[i]}");
                picRoad.Controls.Add(p);
                allCars[i] = p;
            }
        }

        int max,i1, i2, i3;
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (allCars != null && allCars.Length > 0)
            {
                foreach (PictureBox car in allCars)
                {
                    int dx = random.Next(0, 22);
                    car.Left += dx;

                    if (car.Left > max)
                    {
                        max = car.Left;
                        if (max + car.Width > picRoad.Width)
                        {
                            timerRacing.Stop();
                            win = car;
                            timerBlink.Start();
                            break;
                        }
                    }
                }
                PictureBox p1 = GetMaxBelow(this.Width,null);
                i1 = (int)p1.Tag;
                labelKQ1.Text = $"1st: sv[{i1 + 1}] = {sv[i1]}";
                PictureBox p2 = GetMaxBelow(p1.Left,p1);
                i2 = (int)p2.Tag;
                labelKQ2.Text = $"2nd: sv[{i2 + 1}] = {sv[i2]}";
                PictureBox p3 = GetMaxBelow(p2.Left,p2);
                i3 = (int)p3.Tag;
                labelKQ3.Text = $"3rd: sv[{i3 + 1}] = {sv[i3]}";
            }
        }
        PictureBox GetMaxBelow(int MAX, PictureBox box)
        {
            int max = 0;
            PictureBox p = null;
            foreach (PictureBox car in allCars) if (car != box)
                {
                    int x = car.Left;
                    if (x > max && x <= MAX)
                    {
                        max = x;

                        p = car;
                    }
                }
            return p;
        }
        PictureBox win;
        private void timerBlink_Tick(object sender, EventArgs e)
        {
            win.Visible = !win.Visible;
            timerBlink.Interval = win.Visible ? 1000 : 40;
        }
    }
}
