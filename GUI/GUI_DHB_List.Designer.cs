namespace GUI
{
    partial class frmDHB_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDHB_List));
            this.dgvDHB = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.rdoTheoNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoTheoThang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoTheoNgay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpNgayBan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLamMoiHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemHD = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDHB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDHB
            // 
            this.dgvDHB.AllowUserToAddRows = false;
            this.dgvDHB.AllowUserToDeleteRows = false;
            this.dgvDHB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDHB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDHB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDHB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDHB.ColumnHeadersHeight = 30;
            this.dgvDHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDHB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDHB.EnableHeadersVisualStyles = false;
            this.dgvDHB.Location = new System.Drawing.Point(0, 0);
            this.dgvDHB.Name = "dgvDHB";
            this.dgvDHB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDHB.RowHeadersVisible = false;
            this.dgvDHB.RowHeadersWidth = 50;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDHB.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDHB.RowTemplate.Height = 40;
            this.dgvDHB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDHB.Size = new System.Drawing.Size(856, 496);
            this.dgvDHB.TabIndex = 4;
            this.dgvDHB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDHB_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.rdoTheoNam);
            this.panel1.Controls.Add(this.rdoTheoThang);
            this.panel1.Controls.Add(this.rdoTheoNgay);
            this.panel1.Controls.Add(this.dtpNgayBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 64);
            this.panel1.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoRoundedCorners = true;
            this.btnTimKiem.BorderRadius = 18;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(117, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(43, 39);
            this.btnTimKiem.TabIndex = 87;
            this.toolTip1.SetToolTip(this.btnTimKiem, "Tìm kiếm");
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdoTheoNam
            // 
            this.rdoTheoNam.AutoSize = true;
            this.rdoTheoNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rdoTheoNam.CheckedState.BorderThickness = 0;
            this.rdoTheoNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoTheoNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoTheoNam.CheckedState.InnerOffset = -4;
            this.rdoTheoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdoTheoNam.Location = new System.Drawing.Point(717, 25);
            this.rdoTheoNam.Name = "rdoTheoNam";
            this.rdoTheoNam.Size = new System.Drawing.Size(73, 17);
            this.rdoTheoNam.TabIndex = 86;
            this.rdoTheoNam.Text = "Theo năm";
            this.rdoTheoNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoTheoNam.UncheckedState.BorderThickness = 2;
            this.rdoTheoNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoTheoNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdoTheoThang
            // 
            this.rdoTheoThang.AutoSize = true;
            this.rdoTheoThang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rdoTheoThang.CheckedState.BorderThickness = 0;
            this.rdoTheoThang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoTheoThang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoTheoThang.CheckedState.InnerOffset = -4;
            this.rdoTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdoTheoThang.Location = new System.Drawing.Point(611, 25);
            this.rdoTheoThang.Name = "rdoTheoThang";
            this.rdoTheoThang.Size = new System.Drawing.Size(80, 17);
            this.rdoTheoThang.TabIndex = 85;
            this.rdoTheoThang.Text = "Theo tháng";
            this.rdoTheoThang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoTheoThang.UncheckedState.BorderThickness = 2;
            this.rdoTheoThang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoTheoThang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdoTheoNgay
            // 
            this.rdoTheoNgay.AutoSize = true;
            this.rdoTheoNgay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rdoTheoNgay.CheckedState.BorderThickness = 0;
            this.rdoTheoNgay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoTheoNgay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoTheoNgay.CheckedState.InnerOffset = -4;
            this.rdoTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdoTheoNgay.Location = new System.Drawing.Point(501, 25);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Size = new System.Drawing.Size(76, 17);
            this.rdoTheoNgay.TabIndex = 84;
            this.rdoTheoNgay.Text = "Theo ngày";
            this.rdoTheoNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoTheoNgay.UncheckedState.BorderThickness = 2;
            this.rdoTheoNgay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoTheoNgay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.AutoRoundedCorners = true;
            this.dtpNgayBan.BorderRadius = 18;
            this.dtpNgayBan.Checked = true;
            this.dtpNgayBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.dtpNgayBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBan.Location = new System.Drawing.Point(166, 12);
            this.dtpNgayBan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(309, 39);
            this.dtpNgayBan.TabIndex = 83;
            this.dtpNgayBan.Value = new System.DateTime(2024, 2, 13, 0, 0, 0, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDHB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.btnLamMoiHD);
            this.splitContainer1.Panel2.Controls.Add(this.btnThemHD);
            this.splitContainer1.Size = new System.Drawing.Size(856, 575);
            this.splitContainer1.SplitterDistance = 496;
            this.splitContainer1.TabIndex = 8;
            // 
            // btnLamMoiHD
            // 
            this.btnLamMoiHD.AutoRoundedCorners = true;
            this.btnLamMoiHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLamMoiHD.BorderRadius = 19;
            this.btnLamMoiHD.BorderThickness = 2;
            this.btnLamMoiHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiHD.FillColor = System.Drawing.Color.White;
            this.btnLamMoiHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoiHD.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoiHD.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiHD.Image")));
            this.btnLamMoiHD.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLamMoiHD.Location = new System.Drawing.Point(459, 21);
            this.btnLamMoiHD.Name = "btnLamMoiHD";
            this.btnLamMoiHD.Size = new System.Drawing.Size(194, 41);
            this.btnLamMoiHD.TabIndex = 90;
            this.btnLamMoiHD.Text = "Làm mới";
            this.btnLamMoiHD.Click += new System.EventHandler(this.btnLamMoiHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.AutoRoundedCorners = true;
            this.btnThemHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemHD.BorderRadius = 19;
            this.btnThemHD.BorderThickness = 2;
            this.btnThemHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemHD.FillColor = System.Drawing.Color.White;
            this.btnThemHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemHD.ForeColor = System.Drawing.Color.Black;
            this.btnThemHD.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHD.Image")));
            this.btnThemHD.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemHD.Location = new System.Drawing.Point(245, 20);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(194, 41);
            this.btnThemHD.TabIndex = 87;
            this.btnThemHD.Text = "Thêm đơn hàng";
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // frmDHB_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDHB_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_DHB_List";
            this.Load += new System.EventHandler(this.frmDHB_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDHB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDHB;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2RadioButton rdoTheoNam;
        private Guna.UI2.WinForms.Guna2RadioButton rdoTheoThang;
        private Guna.UI2.WinForms.Guna2RadioButton rdoTheoNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBan;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiHD;
        private Guna.UI2.WinForms.Guna2Button btnThemHD;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}