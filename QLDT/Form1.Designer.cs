namespace QLDT
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
            this.btnListLop = new System.Windows.Forms.Button();
            this.MinSL = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxLop = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cboDot = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListLop
            // 
            this.btnListLop.Location = new System.Drawing.Point(548, 64);
            this.btnListLop.Margin = new System.Windows.Forms.Padding(5);
            this.btnListLop.Name = "btnListLop";
            this.btnListLop.Size = new System.Drawing.Size(269, 84);
            this.btnListLop.TabIndex = 0;
            this.btnListLop.Text = "Liệt kê các lớp sẽ mở";
            this.btnListLop.UseVisualStyleBackColor = true;
            this.btnListLop.Click += new System.EventHandler(this.btnListLop_Click);
            // 
            // MinSL
            // 
            this.MinSL.Location = new System.Drawing.Point(237, 54);
            this.MinSL.Margin = new System.Windows.Forms.Padding(5);
            this.MinSL.Name = "MinSL";
            this.MinSL.Size = new System.Drawing.Size(152, 34);
            this.MinSL.TabIndex = 1;
            this.MinSL.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sĩ số tối thiểu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sv học tối đa:";
            // 
            // MaxLop
            // 
            this.MaxLop.Location = new System.Drawing.Point(237, 114);
            this.MaxLop.Margin = new System.Windows.Forms.Padding(5);
            this.MaxLop.Name = "MaxLop";
            this.MaxLop.Size = new System.Drawing.Size(152, 34);
            this.MaxLop.TabIndex = 3;
            this.MaxLop.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 375);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok, mở ngay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CmdMoLop_Click);
            // 
            // cboDot
            // 
            this.cboDot.FormattingEnabled = true;
            this.cboDot.Location = new System.Drawing.Point(126, 584);
            this.cboDot.Name = "cboDot";
            this.cboDot.Size = new System.Drawing.Size(172, 37);
            this.cboDot.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đợt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 648);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinSL);
            this.Controls.Add(this.btnListLop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MinSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListLop;
        private System.Windows.Forms.NumericUpDown MinSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboDot;
        private System.Windows.Forms.Label label5;
    }
}

