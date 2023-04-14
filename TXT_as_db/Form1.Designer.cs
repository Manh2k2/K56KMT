namespace db_Text
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTiGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDOLAR = new System.Windows.Forms.TextBox();
            this.txtVND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xử lý tính toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTiGia
            // 
            this.txtTiGia.Location = new System.Drawing.Point(235, 82);
            this.txtTiGia.Name = "txtTiGia";
            this.txtTiGia.Size = new System.Drawing.Size(159, 20);
            this.txtTiGia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tỉ giá VND/$";
            // 
            // txtDOLAR
            // 
            this.txtDOLAR.Location = new System.Drawing.Point(112, 244);
            this.txtDOLAR.Name = "txtDOLAR";
            this.txtDOLAR.Size = new System.Drawing.Size(164, 20);
            this.txtDOLAR.TabIndex = 3;
            // 
            // txtVND
            // 
            this.txtVND.Location = new System.Drawing.Point(332, 244);
            this.txtVND.Name = "txtVND";
            this.txtVND.Size = new System.Drawing.Size(164, 20);
            this.txtVND.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "VND";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVND);
            this.Controls.Add(this.txtDOLAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiGia);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTiGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDOLAR;
        private System.Windows.Forms.TextBox txtVND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

