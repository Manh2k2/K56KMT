namespace Racing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.timerRacing = new System.Windows.Forms.Timer(this.components);
            this.labelKQ1 = new System.Windows.Forms.Label();
            this.picRoad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.labelKQ2 = new System.Windows.Forms.Label();
            this.labelKQ3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(12, 12);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(154, 50);
            this.cmdLoad.TabIndex = 1;
            this.cmdLoad.Text = "Load Cars";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(172, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(154, 50);
            this.cmdStart.TabIndex = 2;
            this.cmdStart.Text = "START";
            this.toolTip1.SetToolTip(this.cmdStart, "OK");
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // timerRacing
            // 
            this.timerRacing.Interval = 10;
            this.timerRacing.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // labelKQ1
            // 
            this.labelKQ1.AutoSize = true;
            this.labelKQ1.Location = new System.Drawing.Point(358, 29);
            this.labelKQ1.Name = "labelKQ1";
            this.labelKQ1.Size = new System.Drawing.Size(24, 16);
            this.labelKQ1.TabIndex = 8;
            this.labelKQ1.Text = "1st";
            // 
            // picRoad
            // 
            this.picRoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRoad.Image = global::Racing.Properties.Resources.p1;
            this.picRoad.Location = new System.Drawing.Point(0, 68);
            this.picRoad.Name = "picRoad";
            this.picRoad.Size = new System.Drawing.Size(1298, 578);
            this.picRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoad.TabIndex = 7;
            this.picRoad.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Racing.Properties.Resources.p2;
            this.pictureBox1.Location = new System.Drawing.Point(1298, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timerBlink
            // 
            this.timerBlink.Interval = 1000;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // labelKQ2
            // 
            this.labelKQ2.AutoSize = true;
            this.labelKQ2.Location = new System.Drawing.Point(682, 29);
            this.labelKQ2.Name = "labelKQ2";
            this.labelKQ2.Size = new System.Drawing.Size(29, 16);
            this.labelKQ2.TabIndex = 12;
            this.labelKQ2.Text = "2nd";
            // 
            // labelKQ3
            // 
            this.labelKQ3.AutoSize = true;
            this.labelKQ3.Location = new System.Drawing.Point(1011, 29);
            this.labelKQ3.Name = "labelKQ3";
            this.labelKQ3.Size = new System.Drawing.Size(26, 16);
            this.labelKQ3.TabIndex = 13;
            this.labelKQ3.Text = "3rd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 645);
            this.Controls.Add(this.labelKQ3);
            this.Controls.Add(this.labelKQ2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelKQ1);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.picRoad);
            this.Name = "Form1";
            this.Text = "RACING CARS - 56KMT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.PictureBox picRoad;
        private System.Windows.Forms.Timer timerRacing;
        private System.Windows.Forms.Label labelKQ1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.Label labelKQ2;
        private System.Windows.Forms.Label labelKQ3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

