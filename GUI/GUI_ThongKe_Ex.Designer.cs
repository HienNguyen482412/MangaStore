namespace GUI
{
    partial class frmThongKe_Ex
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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe_Ex));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chartThongKeDoanhThu = new Guna.Charts.WinForms.GunaChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLai = new System.Windows.Forms.Label();
            this.lbXuat = new System.Windows.Forms.Label();
            this.lbNhap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.rdoTheoNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoTheoThang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoTheoNgay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpNgayTK = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartThongKeDoanhThu);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1141, 786);
            this.splitContainer1.SplitterDistance = 563;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // chartThongKeDoanhThu
            // 
            this.chartThongKeDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            chartFont1.FontName = "Arial";
            this.chartThongKeDoanhThu.Legend.LabelFont = chartFont1;
            this.chartThongKeDoanhThu.Location = new System.Drawing.Point(0, 43);
            this.chartThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartThongKeDoanhThu.Name = "chartThongKeDoanhThu";
            this.chartThongKeDoanhThu.Size = new System.Drawing.Size(1141, 520);
            this.chartThongKeDoanhThu.TabIndex = 2;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chartThongKeDoanhThu.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.chartThongKeDoanhThu.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chartThongKeDoanhThu.Tooltips.TitleFont = chartFont4;
            this.chartThongKeDoanhThu.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.chartThongKeDoanhThu.XAxes.Ticks = tick1;
            this.chartThongKeDoanhThu.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.chartThongKeDoanhThu.YAxes.Ticks = tick2;
            this.chartThongKeDoanhThu.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.chartThongKeDoanhThu.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.chartThongKeDoanhThu.ZAxes.Ticks = tick3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 43);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1063, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 43);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbLai);
            this.panel1.Controls.Add(this.lbXuat);
            this.panel1.Controls.Add(this.lbNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbTieuDe);
            this.panel1.Controls.Add(this.rdoTheoNam);
            this.panel1.Controls.Add(this.rdoTheoThang);
            this.panel1.Controls.Add(this.rdoTheoNgay);
            this.panel1.Controls.Add(this.dtpNgayTK);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 218);
            this.panel1.TabIndex = 0;
            // 
            // lbLai
            // 
            this.lbLai.AutoSize = true;
            this.lbLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLai.Location = new System.Drawing.Point(979, 140);
            this.lbLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLai.Name = "lbLai";
            this.lbLai.Size = new System.Drawing.Size(72, 20);
            this.lbLai.TabIndex = 100;
            this.lbLai.Text = "1000000";
            // 
            // lbXuat
            // 
            this.lbXuat.AutoSize = true;
            this.lbXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXuat.Location = new System.Drawing.Point(723, 142);
            this.lbXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbXuat.Name = "lbXuat";
            this.lbXuat.Size = new System.Drawing.Size(72, 20);
            this.lbXuat.TabIndex = 99;
            this.lbXuat.Text = "1000000";
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhap.Location = new System.Drawing.Point(473, 142);
            this.lbNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(72, 20);
            this.lbNhap.TabIndex = 98;
            this.lbNhap.Text = "1000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(991, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 97;
            this.label4.Text = "LÃI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(727, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 96;
            this.label3.Text = "XUẤT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "NHẬP";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTieuDe.Location = new System.Drawing.Point(404, 0);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(737, 44);
            this.lbTieuDe.TabIndex = 94;
            this.lbTieuDe.Text = "TỔNG DOANH THU";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.rdoTheoNam.Location = new System.Drawing.Point(229, 97);
            this.rdoTheoNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoTheoNam.Name = "rdoTheoNam";
            this.rdoTheoNam.Size = new System.Drawing.Size(93, 21);
            this.rdoTheoNam.TabIndex = 92;
            this.rdoTheoNam.Text = "Theo năm";
            this.rdoTheoNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoTheoNam.UncheckedState.BorderThickness = 2;
            this.rdoTheoNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoTheoNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoTheoNam.CheckedChanged += new System.EventHandler(this.rdoTheoNam_CheckedChanged);
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
            this.rdoTheoThang.Location = new System.Drawing.Point(52, 140);
            this.rdoTheoThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoTheoThang.Name = "rdoTheoThang";
            this.rdoTheoThang.Size = new System.Drawing.Size(102, 21);
            this.rdoTheoThang.TabIndex = 91;
            this.rdoTheoThang.Text = "Theo tháng";
            this.rdoTheoThang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoTheoThang.UncheckedState.BorderThickness = 2;
            this.rdoTheoThang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoTheoThang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoTheoThang.CheckedChanged += new System.EventHandler(this.rdoTheoThang_CheckedChanged);
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
            this.rdoTheoNgay.Location = new System.Drawing.Point(52, 98);
            this.rdoTheoNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Size = new System.Drawing.Size(97, 21);
            this.rdoTheoNgay.TabIndex = 90;
            this.rdoTheoNgay.Text = "Theo ngày";
            this.rdoTheoNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoTheoNgay.UncheckedState.BorderThickness = 2;
            this.rdoTheoNgay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoTheoNgay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoTheoNgay.CheckedChanged += new System.EventHandler(this.rdoTheoNgay_CheckedChanged);
            // 
            // dtpNgayTK
            // 
            this.dtpNgayTK.AutoRoundedCorners = true;
            this.dtpNgayTK.BorderRadius = 22;
            this.dtpNgayTK.Checked = true;
            this.dtpNgayTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtpNgayTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTK.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayTK.Location = new System.Drawing.Point(33, 28);
            this.dtpNgayTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayTK.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTK.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTK.Name = "dtpNgayTK";
            this.dtpNgayTK.Size = new System.Drawing.Size(321, 46);
            this.dtpNgayTK.TabIndex = 0;
            this.dtpNgayTK.Value = new System.DateTime(2024, 2, 13, 0, 0, 0, 0);
            this.dtpNgayTK.ValueChanged += new System.EventHandler(this.dtpNgayTK_ValueChanged);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(404, 218);
            this.splitter1.TabIndex = 93;
            this.splitter1.TabStop = false;
            // 
            // frmThongKe_Ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1141, 786);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThongKe_Ex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ThongKe_Ex";
            this.Load += new System.EventHandler(this.frmThongKe_Ex_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTK;
        private System.Windows.Forms.Label lbLai;
        private System.Windows.Forms.Label lbXuat;
        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTieuDe;
        private Guna.UI2.WinForms.Guna2RadioButton rdoTheoNam;
        private Guna.UI2.WinForms.Guna2RadioButton rdoTheoThang;
        private Guna.UI2.WinForms.Guna2RadioButton rdoTheoNgay;
        private System.Windows.Forms.Splitter splitter1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.Charts.WinForms.GunaChart chartThongKeDoanhThu;
    }
}