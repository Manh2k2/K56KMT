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
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(260, 25);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(103, 29);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(24, 25);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(203, 20);
            this.txtTen.TabIndex = 1;
            // 
            // numTuoi
            // 
            this.numTuoi.Location = new System.Drawing.Point(24, 73);
            this.numTuoi.Name = "numTuoi";
            this.numTuoi.Size = new System.Drawing.Size(94, 20);
            this.numTuoi.TabIndex = 3;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(260, 60);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(103, 29);
            this.cmdLoad.TabIndex = 11;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tuổi:";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(260, 95);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(103, 29);
            this.cmdClear.TabIndex = 12;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(24, 124);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(48, 20);
            this.txtToan.TabIndex = 5;
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(89, 124);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(48, 20);
            this.txtLy.TabIndex = 7;
            // 
            // txtHoa
            // 
            this.txtHoa.Location = new System.Drawing.Point(152, 124);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(48, 20);
            this.txtHoa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lý:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hoá:";
            // 
            // frmJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 164);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoa);
            this.Controls.Add(this.txtLy);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.numTuoi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.cmdSave);
            this.Name = "frmJson";
            this.Text = "demo JSON for 56kmt by Do Duy Cop";
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

