namespace db_Json
{
    partial class frmJson
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.numTuoi = new System.Windows.Forms.NumericUpDown();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(347, 16);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(137, 53);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(23, 41);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(269, 22);
            this.txtTen.TabIndex = 1;
            // 
            // numTuoi
            // 
            this.numTuoi.Location = new System.Drawing.Point(23, 92);
            this.numTuoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTuoi.Name = "numTuoi";
            this.numTuoi.Size = new System.Drawing.Size(125, 22);
            this.numTuoi.TabIndex = 3;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(347, 77);
            this.cmdLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(137, 53);
            this.cmdLoad.TabIndex = 11;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tuổi:";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(347, 138);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(137, 53);
            this.cmdClear.TabIndex = 12;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(23, 143);
            this.txtToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(63, 22);
            this.txtToan.TabIndex = 5;
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(110, 143);
            this.txtLy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(63, 22);
            this.txtLy.TabIndex = 7;
            // 
            // txtHoa
            // 
            this.txtHoa.Location = new System.Drawing.Point(194, 143);
            this.txtHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(63, 22);
            this.txtHoa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lý:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hoá:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoa);
            this.groupBox1.Controls.Add(this.txtLy);
            this.groupBox1.Controls.Add(this.txtToan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numTuoi);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 181);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataBlock";
            // 
            // frmJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.cmdSave);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmJson";
            this.Text = "demo JSON for 56kmt by Do Duy Cop";
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.NumericUpDown numTuoi;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtLy;
        private System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

