using BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        BUSThongKe tk = new BUSThongKe();
        private void frmThongKe_Load(object sender, EventArgs e)
        {

            rdoTheoThang.Checked = true;

        }
        int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        string[] arr = { "Nhập", "Bán" };
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
            }
            return ds;
        }
        private void rdoTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoNgay.Checked == true)
            {
                ThongKeTheoNgay();
            }
        }
        void ThongKeTheoNgay()
        {
            chartThongKeSoTruyen.Reset();
            chartThongKeDoanhThu.Reset();
            string thang = dtpNgayTK.Value.ToString("MM");
            string nam = dtpNgayTK.Value.ToString("yyyy");
            string ngay = dtpNgayTK.Value.ToString("dd");
            chartThongKeSoTruyen.YAxes.GridLines.Display = false;
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            dataset.Label = "Số truyện bán";
            dataset.BorderColors = dataset.FillColors;
            DataTable dt = tk.ThongKeTheoNgayBan(thang, nam);
            string[] dsn = NgayTrongThang(Convert.ToInt16(thang), Convert.ToInt32(nam));
            lbtTenBieuDo.Text = $"BIỂU ĐỒ SỐ TRUYỆN ĐƯỢC NHẬP/BÁN TRONG THÁNG {thang}/{nam}";

            for (int i = 0; i < dsn.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j][0].ToString().Split(' ')[0].ToString() == dsn[i].ToString())
                    {
                        ck = true;
                        dataset.DataPoints.Add(dsn[i].ToString(), Convert.ToInt32(dt.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    dataset.DataPoints.Add(dsn[i].ToString(), 0);
                }

            }
            var datasetspl = new Guna.Charts.WinForms.GunaSplineDataset();
            datasetspl.Label = "Số truyện nhập";
            datasetspl.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            datasetspl.BorderColor = datasetspl.FillColor;
            DataTable dt_nhap = tk.ThongKeTheoNgayNhap(thang, nam);
            for (int i = 0; i < dsn.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt_nhap.Rows.Count; j++)
                {
                    if (dt_nhap.Rows[j][0].ToString().Split(' ')[0].ToString() == dsn[i].ToString())
                    {
                        ck = true;
                        datasetspl.DataPoints.Add(dsn[i].ToString(), Convert.ToInt32(dt_nhap.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    datasetspl.DataPoints.Add(dsn[i].ToString(), 0);
                }

            }
            chartThongKeSoTruyen.Datasets.Add(datasetspl);
            chartThongKeSoTruyen.Datasets.Add(dataset);
            chartThongKeSoTruyen.Update();
            chartThongKeDoanhThu.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chartThongKeDoanhThu.XAxes.Display = false;
            chartThongKeDoanhThu.YAxes.Display = false;
            chartThongKeDoanhThu.Title.Text = $"Thống kê tổng tiền nhập/bán tháng {ngay}/{thang}/{nam}";
            var datasedgt = new Guna.Charts.WinForms.GunaHorizontalBarDataset();
            datasedgt.Label = "VND";
            datasedgt.DataPoints.Add(arr[0], Convert.ToInt64(tk.TongTienNhapTheoNgay(ngay, thang, nam).Rows[0][0].ToString()));
            datasedgt.DataPoints.Add(arr[1], Convert.ToInt64(tk.TongTienBanTheoNgay(ngay, thang, nam).Rows[0][0].ToString()));
            lbTienLai.Text = "TIỀN LÃI:  " + (Convert.ToInt64(tk.TongTienBanTheoNgay(ngay, thang, nam).Rows[0][0].ToString()) - Convert.ToInt64(tk.TongTienNhapTheoNgay(ngay, thang, nam).Rows[0][0].ToString())).ToString();
            chartThongKeDoanhThu.Datasets.Add(datasedgt);
            chartThongKeDoanhThu.Update();
            dgvTruyenBanChay.DataSource = tk.TruyenBanChayTheoNgay(ngay, thang, nam);
            dgvTruyenBanE.DataSource = tk.TruyenBanE();
            DataTable dtnhap = tk.TongSoDonHangVaSLNhap(0, Convert.ToInt16(ngay), Convert.ToInt16(thang), Convert.ToInt16(nam));
            lbSoLuongDHNhap.Text = dtnhap.Rows[0][0].ToString();
            lbSoLuongTN.Text = dtnhap.Rows[0][1].ToString();
            DataTable dtban = tk.TongSoDonHangVaSLBan(0, Convert.ToInt16(ngay), Convert.ToInt16(thang), Convert.ToInt16(nam));
            lbSoLuongDHB.Text = dtban.Rows[0][0].ToString();
            lbSoLuongTB.Text = dtban.Rows[0][1].ToString();

        }
        void ThongKeTheoThang()
        {
            chartThongKeSoTruyen.Reset();
            chartThongKeDoanhThu.Reset();
            string thang = dtpNgayTK.Value.ToString("MM");
            string nam = dtpNgayTK.Value.ToString("yyyy");
            chartThongKeSoTruyen.YAxes.GridLines.Display = false;
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            dataset.Label = "Số truyện bán";
            dataset.BorderColors = dataset.FillColors;
            DataTable dt = tk.ThongKeTheoThangBan(dtpNgayTK.Value.ToString("yyyy"));
            lbtTenBieuDo.Text = $"BIỂU ĐỒ SỐ TRUYỆN ĐƯỢC NHẬP/BÁN TRONG NĂM {dtpNgayTK.Value.ToString("yyyy")}";
            for (int i = 0; i < months.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j][0].ToString() == months[i].ToString())
                    {
                        ck = true;
                        dataset.DataPoints.Add("Tháng " + months[i].ToString(), Convert.ToInt32(dt.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    dataset.DataPoints.Add("Tháng " + months[i].ToString(), 0);
                }

            }
            var datasetspl = new Guna.Charts.WinForms.GunaSplineDataset();
            datasetspl.Label = "Số truyện nhập";
            datasetspl.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            datasetspl.BorderColor = datasetspl.FillColor;
            DataTable dt_nhap = tk.ThongKeTheoThangNhap(nam);
            for (int i = 0; i < months.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt_nhap.Rows.Count; j++)
                {
                    if (dt_nhap.Rows[j][0].ToString() == months[i].ToString())
                    {
                        ck = true;
                        datasetspl.DataPoints.Add("Tháng " + months[i].ToString(), Convert.ToInt32(dt_nhap.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    datasetspl.DataPoints.Add("Tháng " + months[i].ToString(), 0);
                }

            }
            chartThongKeSoTruyen.Datasets.Add(datasetspl);
            chartThongKeSoTruyen.Datasets.Add(dataset);
            chartThongKeSoTruyen.Update();
            chartThongKeDoanhThu.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chartThongKeDoanhThu.XAxes.Display = false;
            chartThongKeDoanhThu.YAxes.Display = false;
       
            chartThongKeDoanhThu.Title.Text = $"Thống kê tổng tiền nhập/bán tháng {thang}/{nam}";
            var datasedgt = new Guna.Charts.WinForms.GunaHorizontalBarDataset();
            datasedgt.Label = "VND";
            datasedgt.DataPoints.Add(arr[0], Convert.ToInt64(tk.TongTienNhapTheoThang(thang, nam).Rows[0][0].ToString()));
            datasedgt.DataPoints.Add(arr[1], Convert.ToInt64(tk.TongTienBanTheoThang(thang, nam).Rows[0][0].ToString()));
            lbTienLai.Text = "TIỀN LÃI: " + (Convert.ToInt64(tk.TongTienBanTheoThang(thang, nam).Rows[0][0].ToString()) - Convert.ToInt64(tk.TongTienNhapTheoThang(thang, nam).Rows[0][0].ToString())).ToString();
            chartThongKeDoanhThu.Datasets.Add(datasedgt);
            chartThongKeDoanhThu.Update();
            dgvTruyenBanChay.DataSource = tk.TruyenBanChayTheoThang(thang, nam);
            dgvTruyenBanE.DataSource = tk.TruyenBanE();
            DataTable dtnhap = tk.TongSoDonHangVaSLNhap(1, Convert.ToInt16(thang), Convert.ToInt16(thang), Convert.ToInt16(nam));
            lbSoLuongDHNhap.Text = dtnhap.Rows[0][0].ToString();
            lbSoLuongTN.Text = dtnhap.Rows[0][1].ToString();
            DataTable dtban = tk.TongSoDonHangVaSLBan(1, Convert.ToInt16(thang), Convert.ToInt16(thang), Convert.ToInt16(nam));
            lbSoLuongDHB.Text = dtban.Rows[0][0].ToString();
            lbSoLuongTB.Text = dtban.Rows[0][1].ToString();
        }
        void ThongKeTheoNam()
        {
            chartThongKeSoTruyen.Reset();
            chartThongKeDoanhThu.Reset();
            string thang = dtpNgayTK.Value.ToString("MM");
            string nam = dtpNgayTK.Value.ToString("yyyy");
            string ngay = dtpNgayTK.Value.ToString("dd");
            chartThongKeSoTruyen.YAxes.GridLines.Display = false;
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            dataset.Label = "Số truyện bán";
            dataset.BorderColors = dataset.FillColors;
            DataTable dt = tk.ThongKeTheoNamBan();
            string[] dsn = { "2017", "2018","2019","2020","2021","2022","2023","2024","2025","2026","2027","2028","2029","2030" };
            lbtTenBieuDo.Text = $"BIỂU ĐỒ SỐ TRUYỆN ĐƯỢC NHẬP/BÁN TRONG CÁC NĂM";

            for (int i = 0; i < dsn.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j][0].ToString() == dsn[i].ToString())
                    {
                        ck = true;
                        dataset.DataPoints.Add(dsn[i].ToString(), Convert.ToInt32(dt.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    dataset.DataPoints.Add(dsn[i].ToString(), 0);
                }

            }
            var datasetspl = new Guna.Charts.WinForms.GunaSplineDataset();
            datasetspl.Label = "Số truyện nhập";
            datasetspl.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            datasetspl.BorderColor = datasetspl.FillColor;
            DataTable dt_nhap = tk.ThongKeTheoNamNhap();
            for (int i = 0; i < dsn.Length; i++)
            {
                bool ck = false;
                for (int j = 0; j < dt_nhap.Rows.Count; j++)
                {
                    if (dt_nhap.Rows[j][0].ToString() == dsn[i].ToString())
                    {
                        ck = true;
                        datasetspl.DataPoints.Add(dsn[i].ToString(), Convert.ToInt32(dt_nhap.Rows[j][1].ToString()));
                    }


                }
                if (!ck)
                {
                    datasetspl.DataPoints.Add(dsn[i].ToString(), 0);
                }

            }
            chartThongKeSoTruyen.Datasets.Add(datasetspl);
            chartThongKeSoTruyen.Datasets.Add(dataset);
            chartThongKeSoTruyen.Datasets.Add(dataset);
            chartThongKeSoTruyen.Update();
            chartThongKeDoanhThu.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chartThongKeDoanhThu.XAxes.Display = false;
            chartThongKeDoanhThu.YAxes.Display = false;
            chartThongKeDoanhThu.Title.Text = $"Thống kê tổng tiền nhập/bán năm {nam}";
            var datasedgt = new Guna.Charts.WinForms.GunaHorizontalBarDataset();
            datasedgt.Label = "VND";
            datasedgt.DataPoints.Add(arr[0], Convert.ToInt64(tk.TongTienNhapTheoNam( nam).Rows[0][0].ToString()));
            datasedgt.DataPoints.Add(arr[1], Convert.ToInt64(tk.TongTienBanTheoNam( nam).Rows[0][0].ToString()));
            lbTienLai.Text = "TIỀN LÃI:  " + (Convert.ToInt64(tk.TongTienBanTheoNam(nam).Rows[0][0].ToString()) - Convert.ToInt64(tk.TongTienNhapTheoNam(nam).Rows[0][0].ToString())).ToString();
            chartThongKeDoanhThu.Datasets.Add(datasedgt);
            chartThongKeDoanhThu.Update();
            dgvTruyenBanChay.DataSource = tk.TruyenBanChayTheoNam(nam);
            dgvTruyenBanE.DataSource = tk.TruyenBanE();
            DataTable dtnhap = tk.TongSoDonHangVaSLNhap(3, Convert.ToInt16(ngay), Convert.ToInt16(thang), Convert.ToInt16(nam));
            lbSoLuongDHNhap.Text = dtnhap.Rows[0][0].ToString();
            lbSoLuongTN.Text = dtnhap.Rows[0][1].ToString();
            DataTable dtban = tk.TongSoDonHangVaSLBan(3, Convert.ToInt16(ngay), Convert.ToInt16(thang), Convert.ToInt16(nam));
            lbSoLuongDHB.Text = dtban.Rows[0][0].ToString();
            lbSoLuongTB.Text = dtban.Rows[0][1].ToString();
        }
        private void rdoTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoThang.Checked == true)
            {
                ThongKeTheoThang();

            }

        }

        private void dtpNgayTK_ValueChanged(object sender, EventArgs e)
        {
            if (rdoTheoThang.Checked == true)
            {
                ThongKeTheoThang();

            }
            if (rdoTheoNgay.Checked == true)
            {
                ThongKeTheoNgay();
            }
            if (rdoTheoNam.Checked == true)
            {
                ThongKeTheoNam();
            }
        }

        private void rdoTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoNam.Checked == true)
            {
                ThongKeTheoNam();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmThongKe_Ex tkex = new frmThongKe_Ex();
            tkex.Show();
        }
    }
}
