using BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongKe_Ex : Form
    {
        public frmThongKe_Ex()
        {
            InitializeComponent();
        }
        BUS_ThongKe tk = new BUS_ThongKe();
        int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        string[] dsnam = { "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" };
        void Refresh()
        {
            lbLai.Text = 0.ToString();
            lbNhap.Text = 0.ToString();
            lbXuat.Text = 0.ToString();

        }
        bool KiemTraNamNhuan(int nam)
        {
            return ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0);
        }
        string[] NgayTrongThang(int thang, int nam)
        {
            int songay = 0;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    songay = 31; break;
                case 4:
                case 6:
                case 9:
                case 11:
                    songay = 30; break;
                case 2:
                    if (KiemTraNamNhuan(nam))
                        songay = 29;
                    else
                        songay = 28;
                    break;

            }
            string[] ds = new string[songay];
            for (int i = 0; i < ds.Length; i++)
            {
                int ngay = i + 1;
                ds[i] = $"{ngay:D2}/{thang:D2}/{nam}";
                //ds[i] = $"{nam}-{thang:D2}-{ngay:D2}";
            }
            return ds;
        }
        void ThongKeTheoNam()
        {
            Refresh();
            chartThongKeDoanhThu.Reset();
            chartThongKeDoanhThu.YAxes.GridLines.Display = false;
            //Nhập
            string thang = dtpNgayTK.Value.ToString("MM");
            string nam = dtpNgayTK.Value.ToString("yyyy");
            var datasetspl_nhap = new Guna.Charts.WinForms.GunaSplineDataset();
            datasetspl_nhap.Label = "Tiền nhập";
            datasetspl_nhap.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            datasetspl_nhap.BorderColor = datasetspl_nhap.FillColor;
            DataTable dt_nhap = tk.DanhSachTienNhap(2, thang, nam);
            for (int i = 0; i < dsnam.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt_nhap.Rows.Count; j++)
                {
                    if ($"{Convert.ToInt32(dt_nhap.Rows[j][0])}" == dsnam[i].ToString())
                    {
                        ck = true;
                        datasetspl_nhap.DataPoints.Add("Năm " + dsnam[i].ToString(), Convert.ToInt32(dt_nhap.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    datasetspl_nhap.DataPoints.Add("Năm " + dsnam[i].ToString(), 0);
                }

            }
            //Bán
            var datasetspl_ban = new Guna.Charts.WinForms.GunaBarDataset();
            datasetspl_ban.Label = "Tiền bán";
            DataTable dt_ban = tk.DanhSachTienBan(2, thang, nam);
            for (int i = 0; i < dsnam.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt_ban.Rows.Count; j++)
                {
                    if ($"{Convert.ToInt32(dt_ban.Rows[j][0])}" == dsnam[i].ToString())
                    {
                        ck = true;
                        datasetspl_ban.DataPoints.Add("Năm " + dsnam[i].ToString(), Convert.ToInt32(dt_ban.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    datasetspl_ban.DataPoints.Add("Năm " + dsnam[i].ToString(), 0);
                }

            }
            chartThongKeDoanhThu.Datasets.Add(datasetspl_ban);
            chartThongKeDoanhThu.Datasets.Add(datasetspl_nhap);
            chartThongKeDoanhThu.Update();
            lbTieuDe.Text = "TỔNG DOANH THU TRONG CÁC NĂM";
            lbNhap.Text = tk.DanhSachTienNhap(3, thang, nam).Rows[0][0].ToString();
            lbXuat.Text = tk.DanhSachTienBan(3, thang, nam).Rows[0][0].ToString();
            lbLai.Text = (Convert.ToInt64(lbXuat.Text)-Convert.ToInt64(lbNhap.Text)).ToString();


        }
        void ThongKeTheoThang()
        {
            Refresh();
            chartThongKeDoanhThu.Reset();
            chartThongKeDoanhThu.YAxes.GridLines.Display = false;
            //Nhập
            string thang = dtpNgayTK.Value.ToString("MM");
            string nam = dtpNgayTK.Value.ToString("yyyy");
            var datasetspl_nhap = new Guna.Charts.WinForms.GunaSplineDataset();
            datasetspl_nhap.Label = "Tiền nhập";
            datasetspl_nhap.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            datasetspl_nhap.BorderColor = datasetspl_nhap.FillColor;
            DataTable dt_nhap = tk.DanhSachTienNhap(1, thang, nam);
            for (int i = 0; i < months.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt_nhap.Rows.Count; j++)
                {
                    if ($"{Convert.ToInt32(dt_nhap.Rows[j][0])}" == months[i].ToString())
                    {
                        ck = true;
                        datasetspl_nhap.DataPoints.Add("Tháng " + months[i].ToString(), Convert.ToInt32(dt_nhap.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    datasetspl_nhap.DataPoints.Add("Tháng " + months[i].ToString(), 0);
                }

            }
            //Bán
            var datasetspl_ban = new Guna.Charts.WinForms.GunaBarDataset();
            datasetspl_ban.Label = "Tiền bán";
            DataTable dt_ban = tk.DanhSachTienBan(1, thang, nam);
            for (int i = 0; i < months.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt_ban.Rows.Count; j++)
                {
                    if ($"{Convert.ToInt32(dt_ban.Rows[j][0])}" == months[i].ToString())
                    {
                        ck = true;
                        datasetspl_ban.DataPoints.Add("Tháng " + months[i].ToString(), Convert.ToInt32(dt_ban.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    datasetspl_ban.DataPoints.Add("Tháng " + months[i].ToString(), 0);
                }

            }
            chartThongKeDoanhThu.Datasets.Add(datasetspl_ban);
            chartThongKeDoanhThu.Datasets.Add(datasetspl_nhap);
            chartThongKeDoanhThu.Update();
            lbTieuDe.Text = $"TỔNG DOANH THU TRONG NĂM {nam}";
            lbNhap.Text = tk.TongTienNhap(1, thang, nam).Rows[0][0].ToString();
            lbXuat.Text = tk.TongTienBan(1, thang, nam).Rows[0][0].ToString();
            lbLai.Text = (Convert.ToInt64(lbXuat.Text) - Convert.ToInt64(lbNhap.Text)).ToString();


        }
        void ThongKeTheoNgay()
        {
            Refresh();
            chartThongKeDoanhThu.Reset();
            chartThongKeDoanhThu.YAxes.GridLines.Display = false;
            //Nhập
            string thang = dtpNgayTK.Value.ToString("MM");
            string nam = dtpNgayTK.Value.ToString("yyyy");
            var datasetspl_nhap = new Guna.Charts.WinForms.GunaSplineDataset();
            datasetspl_nhap.Label = "Tiền nhập";
            datasetspl_nhap.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            datasetspl_nhap.BorderColor = datasetspl_nhap.FillColor;
            DataTable dt_nhap = tk.DanhSachTienNhap(0, thang, nam);
            string[] dsn = NgayTrongThang(Convert.ToInt16(thang), Convert.ToInt32(nam));
            for (int i = 0; i < dsn.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt_nhap.Rows.Count; j++)
                {
                    string temp;
                    try
                    {
                        temp = dt_nhap.Rows[j][0].ToString().Split(' ')[0];
                    }
                    catch
                    {
                        temp = "";
                    }
                    if (temp == dsn[i].ToString())
                    {
                        ck = true;
                        datasetspl_nhap.DataPoints.Add(dsn[i].ToString(), Convert.ToInt32(dt_nhap.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    datasetspl_nhap.DataPoints.Add(dsn[i].ToString(), 0);
                }

            }
            //Bán
            var datasetspl_ban = new Guna.Charts.WinForms.GunaBarDataset();
            datasetspl_ban.Label = "Tiền bán";
            DataTable dt_ban = tk.DanhSachTienBan(0, thang, nam);
            string[] dsb = NgayTrongThang(Convert.ToInt16(thang), Convert.ToInt32(nam));
            for (int i = 0; i < dsb.Length; i++)
            {
                bool ck = false;
                
                for (int j = 0; j < dt_ban.Rows.Count; j++)
                {
                    string temp;
                    try
                    {
                        temp = dt_ban.Rows[j][0].ToString().Split(' ')[0];
                    }
                    catch
                    {
                        temp = "";
                    }
                    if (temp == dsb[i].ToString())
                    {
                        ck = true;
                        datasetspl_ban.DataPoints.Add(dsb[i].ToString(), Convert.ToInt32(dt_ban.Rows[j][1].ToString()));
                       
                    }

                    
                }
                if (!ck)
                {
                    datasetspl_ban.DataPoints.Add(dsb[i].ToString(), 0);
                    
                }

            }
            #region test
            //chung
            //var datasetspl_lai = new Guna.Charts.WinForms.GunaSplineDataset();
            //datasetspl_lai.Label = "Tiền lãi";
            //for (int i = 0; i < dsb.Length; i++)
            //{
            //    bool ck = false;

            //    for (int j = 0; j < dt_ban.Rows.Count; j++)
            //    {

            //        for (int k = 0; k < dt_nhap.Rows.Count; k++)
            //        {
            //            if ( dt_ban.Rows[j][0].ToString().Split(' ')[0] == dsb[i].ToString() || dt_nhap.Rows[k][0].ToString().Split(' ')[0] == dsb[i].ToString())
            //            {
            //                datasetspl_lai.DataPoints.Add(dsb[i].ToString(), Convert.ToInt32(Convert.ToInt32(dt_ban.Rows[j][1].ToString()) - Convert.ToInt32(dt_nhap.Rows[k][1].ToString())));
            //            }
            //        }

            //    }
            //    if (!ck)
            //    {
            //        datasetspl_lai.DataPoints.Add(dsb[i].ToString(), 0);

            //    }

            //}
            //chartThongKeDoanhThu.Datasets.Add(datasetspl_lai);
            #endregion
            chartThongKeDoanhThu.Datasets.Add(datasetspl_ban);
            chartThongKeDoanhThu.Datasets.Add(datasetspl_nhap);
            chartThongKeDoanhThu.Update();
            lbTieuDe.Text = $"TỔNG DOANH THU TRONG THÁNG {thang}/{nam}";
            lbNhap.Text = tk.TongTienNhap(0, thang, nam).Rows[0][0].ToString();
            lbXuat.Text = tk.TongTienBan(0, thang, nam).Rows[0][0].ToString();
            lbLai.Text = (Convert.ToInt64(lbXuat.Text) - Convert.ToInt64(lbNhap.Text)).ToString();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoNgay.Checked == true) { ThongKeTheoNgay(); }
        }

        private void frmThongKe_Ex_Load(object sender, EventArgs e)
        {
            rdoTheoNgay.Checked = true;
        }

        private void dtpNgayTK_ValueChanged(object sender, EventArgs e)
        {
            if (rdoTheoNgay.Checked == true) { ThongKeTheoNgay(); }
            if (rdoTheoThang.Checked == true)
            {
                ThongKeTheoThang();
            }
            if (rdoTheoNam.Checked == true)
            {
                ThongKeTheoNam();
            }
        }

        private void rdoTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoThang.Checked == true)
            {
                ThongKeTheoThang();
            }
        }

        private void rdoTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoNam.Checked == true)
            {
                ThongKeTheoNam();
            }
        }
    }
}
