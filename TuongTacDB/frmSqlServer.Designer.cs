namespace db_SqlServer
{
    partial class frmSqlServer
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
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMuon_Vang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVang_diHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVang_Muon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDihoc_Vang = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdLoadID_DD = new System.Windows.Forms.Button();
            this.btnUpdateMuon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(12, 44);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(176, 45);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "View ALL SV";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 460);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMuon_Vang,
            this.mnuVang_diHoc,
            this.mnuVang_Muon,
            this.mnuDihoc_Vang});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 92);
            // 
            // mnuMuon_Vang
            // 
            this.mnuMuon_Vang.Name = "mnuMuon_Vang";
            this.mnuMuon_Vang.Size = new System.Drawing.Size(154, 22);
            this.mnuMuon_Vang.Text = "Muộn -> Vắng";
            this.mnuMuon_Vang.Click += new System.EventHandler(this.mnuMuon_Vang_Click);
            // 
            // mnuVang_diHoc
            // 
            this.mnuVang_diHoc.Name = "mnuVang_diHoc";
            this.mnuVang_diHoc.Size = new System.Drawing.Size(154, 22);
            this.mnuVang_diHoc.Text = "Vắng -> Đi học";
            this.mnuVang_diHoc.Click += new System.EventHandler(this.mnuVang_diHoc_Click);
            // 
            // mnuVang_Muon
            // 
            this.mnuVang_Muon.Name = "mnuVang_Muon";
            this.mnuVang_Muon.Size = new System.Drawing.Size(154, 22);
            this.mnuVang_Muon.Text = "Vắng -> Muộn";
            this.mnuVang_Muon.Click += new System.EventHandler(this.mnuVang_Muon_Click);
            // 
            // mnuDihoc_Vang
            // 
            this.mnuDihoc_Vang.Name = "mnuDihoc_Vang";
            this.mnuDihoc_Vang.Size = new System.Drawing.Size(154, 22);
            this.mnuDihoc_Vang.Text = "Đi học -> Vắng";
            this.mnuDihoc_Vang.Click += new System.EventHandler(this.mnuDihoc_Vang_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmdLoadID_DD
            // 
            this.cmdLoadID_DD.Location = new System.Drawing.Point(219, 16);
            this.cmdLoadID_DD.Name = "cmdLoadID_DD";
            this.cmdLoadID_DD.Size = new System.Drawing.Size(136, 46);
            this.cmdLoadID_DD.TabIndex = 3;
            this.cmdLoadID_DD.Text = "Lấy data diemDanh";
            this.cmdLoadID_DD.UseVisualStyleBackColor = true;
            this.cmdLoadID_DD.Click += new System.EventHandler(this.cmdLoadID_DD_Click);
            // 
            // btnUpdateMuon
            // 
            this.btnUpdateMuon.Location = new System.Drawing.Point(489, 43);
            this.btnUpdateMuon.Name = "btnUpdateMuon";
            this.btnUpdateMuon.Size = new System.Drawing.Size(136, 46);
            this.btnUpdateMuon.TabIndex = 5;
            this.btnUpdateMuon.Text = "Vắng -> Đi muộn";
            this.btnUpdateMuon.UseVisualStyleBackColor = true;
            this.btnUpdateMuon.Click += new System.EventHandler(this.btnUpdateMuon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.btnUpdateMuon);
            this.Controls.Add(this.cmdLoadID_DD);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnViewAll);
            this.Name = "Form1";
            this.Text = "demo C# + Sql + Sql Server . (Note: Run Script.sql để tạo db, dữ liệu và  sp_)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdLoadID_DD;
        private System.Windows.Forms.Button btnUpdateMuon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMuon_Vang;
        private System.Windows.Forms.ToolStripMenuItem mnuVang_diHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuVang_Muon;
        private System.Windows.Forms.ToolStripMenuItem mnuDihoc_Vang;
    }
}

