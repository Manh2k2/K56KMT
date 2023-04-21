namespace QLDT
{
    partial class frmAddEditSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNS = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gtNam = new System.Windows.Forms.RadioButton();
            this.gtNu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNganh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSV:";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(154, 36);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(159, 22);
            this.txtMasv.TabIndex = 1;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(154, 73);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(297, 22);
            this.txtHoten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên sinh viên:";
            // 
            // dateNS
            // 
            this.dateNS.CustomFormat = "dd/MM/yyyy";
            this.dateNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNS.Location = new System.Drawing.Point(154, 110);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(119, 22);
            this.dateNS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày sinh:";
            // 
            // gtNam
            // 
            this.gtNam.AutoSize = true;
            this.gtNam.Checked = true;
            this.gtNam.Location = new System.Drawing.Point(154, 147);
            this.gtNam.Name = "gtNam";
            this.gtNam.Size = new System.Drawing.Size(57, 20);
            this.gtNam.TabIndex = 6;
            this.gtNam.TabStop = true;
            this.gtNam.Text = "Nam";
            this.gtNam.UseVisualStyleBackColor = true;
            // 
            // gtNu
            // 
            this.gtNu.AutoSize = true;
            this.gtNu.Location = new System.Drawing.Point(228, 147);
            this.gtNu.Name = "gtNu";
            this.gtNu.Size = new System.Drawing.Size(45, 20);
            this.gtNu.TabIndex = 7;
            this.gtNu.Text = "Nữ";
            this.gtNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính:";
            // 
            // cboNganh
            // 
            this.cboNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNganh.FormattingEnabled = true;
            this.cboNganh.Location = new System.Drawing.Point(154, 182);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Size = new System.Drawing.Size(264, 24);
            this.cboNganh.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngành học:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(154, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 44);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Add";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(267, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 44);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddEditSV
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(511, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboNganh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gtNu);
            this.Controls.Add(this.gtNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateNS);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEditSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton gtNam;
        private System.Windows.Forms.RadioButton gtNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}