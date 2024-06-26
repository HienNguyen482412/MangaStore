﻿using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDHN : Form
    {
        public frmDHN()
        {
            InitializeComponent();
        }
        BUSDHN busDHN = new BUSDHN();
        BUSCTDHN busCTDHN = new BUSCTDHN();
        bool state = true;
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            frmNXB nxb = new frmNXB();
            nxb.guna2ControlBox1.Visible = true;
            if (nxb.ShowDialog() == DialogResult.Cancel)
            {
                nxb.LayThongTinNXB(out string ma, out string ten, out string sdt, out string email, out string diachi);
                txtMaNXB.Text = ma;
                txtTenNXB.Text = ten;
                txtSDT.Text = sdt;
                txtEmail.Text = email;
                txtDiaChi.Text = diachi;
                if (!KTHD)
                {
                    state = false;
                }
            }
        }
        bool CheckNumber()
        {
            bool ck = true;
            //Số lượng
            if (!int.TryParse(txtSoLuong.Text, out int c))
            {
                errorProvider1.SetError(txtSoLuong, "Dữ liệu không đúng định dạng");
                ck = false;
            }
            else if (c <= 0)
            {
                errorProvider1.SetError(txtSoLuong, "Số lượng không thể nhỏ hơn 0 hoặc bằng 0");
                ck = false;
            }
            else
            {
                errorProvider1.SetError(txtSoLuong, "");
            }
            //Giá tiền
            if (!int.TryParse(txtGiaTien.Text, out int d))
            {
                errorProvider1.SetError(txtGiaTien, "Dữ liệu không đúng định dạng");
                ck = false;
            }
            else if (d <= 0)
            {
                errorProvider1.SetError(txtGiaTien, "Giá tiền không thể nhỏ hơn 0 hoặc bằng 0");
                ck = false;
            }
            else
            {
                errorProvider1.SetError(txtGiaTien, "");
            }
            return ck;


        }


        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.guna2ControlBox1.Visible = true;
            if (nv.ShowDialog() == DialogResult.Cancel)
            {
                nv.LayThongTinNV(out string ma, out string ten);
                txtMaNV.Text = ma;
                txtTenNV.Text = ten;
                if (!KTHD)
                {
                    state = false;
                }
            }

        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTongTien.Text = (Convert.ToInt32(txtGiaTien.Text) * Convert.ToInt32(txtSoLuong.Text)).ToString();
            }
            catch
            {
                txtTongTien.Text = 0.ToString();
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTongTien.Text = (Convert.ToInt32(txtGiaTien.Text) * Convert.ToInt32(txtSoLuong.Text)).ToString();
            }
            catch
            {
                txtTongTien.Text = 0.ToString();
            }

        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            frmTruyenTranh tt = new frmTruyenTranh();
            tt.guna2ControlBox1.Visible = true;
            if (tt.ShowDialog() == DialogResult.Cancel)
            {
                tt.LayThongTinTruyenTranh(out string ma, out string ten);
                txtMaTT.Text = ma;
                txtTenTT.Text = ten;

            }
        }
        public void TaoCot()
        {
            dgvTruyenTranh.Columns.Add("clMa", "Mã truyện");
            dgvTruyenTranh.Columns.Add("clTen", "Tên truyện");
            dgvTruyenTranh.Columns.Add("clSoLuong", "Số lượng");
            dgvTruyenTranh.Columns.Add("clGiaTien", "Giá tiền");
        }
        private void frmDHN_Load(object sender, EventArgs e)
        {
            state = true;
            if (KTHD)
            {
                TaoCot();
                txtMaDHN.Text = busDHN.TaoMa().Rows[0][0].ToString();
                if (frmDangNhap.quyenQL == false)
                {
                    btnThemNhanVien.Visible = false;
                    txtTenNV.Text = frmDangNhap.tenNV;
                    txtMaNV.Text = frmDangNhap.maNV;
                }
                btnIn.Enabled = false;
                dtpNgayNhap.Value = DateTime.Now;
            }
            else
            {

                if (frmDangNhap.quyenQL == false)
                {
                    btnThemNhanVien.Visible = false;
                }
                BUSNhanVien nv = new BUSNhanVien();
                BUSNXB nxb = new BUSNXB();
                dgvTruyenTranh.DataSource = busCTDHN.LayCTDHN(txtMaDHN.Text);
                DataTable dtnv = nv.LayNhanVien(txtMaNV.Text.Trim());
                txtTenNV.Text = dtnv.Rows[0][0].ToString();
                DataTable dtnxb = nxb.LayNXB(txtMaNXB.Text.Trim());
                txtTenNXB.Text = dtnxb.Rows[0][0].ToString();
                txtDiaChi.Text = dtnxb.Rows[0][1].ToString();
                txtSDT.Text = dtnxb.Rows[0][2].ToString();
                txtEmail.Text = dtnxb.Rows[0][3].ToString();
                try
                {
                    txtTongTienHD.Text = TongTien().ToString();

                }
                catch
                {
                    txtTongTien.Text = 0.ToString();
                }

            }

        }
        bool CheckNull(Guna2GroupBox gb)
        {
            bool ck = true;
            foreach (Control c in gb.Controls)
            {
                if (c is Guna2TextBox && c.Text == "")
                {
                    ck = false;
                    errorProvider1.SetError(c, "Không được bỏ trống thông tin");
                }
            }
            return ck;
        }
        void ClearGroupBox(Guna2GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }
            }
            errorProvider1.Clear();
        }
        int TongTien()
        {
            int tong = 0;
            for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
            {
                tong += Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[2].Value.ToString()) * Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[3].Value.ToString());
            }
            return tong;
        }
        bool CheckCart(string ma)
        {
            bool ck = true;
            for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
            {
                if (dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim() == ma.Trim())
                {
                    ck = false;
                    MessageBox.Show(Properties.Resources.ExistedItemMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
            }
            return ck;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbTruyenTranh) && CheckCart(txtMaTT.Text) && CheckNumber())
            {
                try
                {
                    dgvTruyenTranh.Rows.Add($"{txtMaTT.Text},{txtTenTT.Text},{txtSoLuong.Text},{txtGiaTien.Text}".Split(','));
                }
                catch
                {
                    DataTable dt = new DataTable();
                    dt = dgvTruyenTranh.DataSource as DataTable;
                    DataRow dr = dt.NewRow();
                    dr[0] = txtMaTT.Text;
                    dr[1] = txtTenTT.Text;
                    dr[2] = txtSoLuong.Text;
                    dr[3] = txtGiaTien.Text;
                    dt.Rows.Add(dr);
                    dgvTruyenTranh.DataSource = dt;
                }
                ClearGroupBox(grbTruyenTranh);
                txtTongTienHD.Text = TongTien().ToString();
                if (!KTHD)
                {
                    state = false;
                }
            }
        }

        private void dgvTruyenTranh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaTT.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenTT.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                txtGiaTien.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            }
            catch
            {
                txtMaTT.Text = dgvTruyenTranh.Rows[0].Cells[0].Value.ToString();
                txtTenTT.Text = dgvTruyenTranh.Rows[0].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvTruyenTranh.Rows[0].Cells[2].Value.ToString().Trim();
                txtGiaTien.Text = dgvTruyenTranh.Rows[0].Cells[3].Value.ToString().Trim();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbTruyenTranh))
            {

                for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                {
                    if (dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim() == txtMaTT.Text.Trim())
                    {
                        dgvTruyenTranh.Rows.RemoveAt(i); ClearGroupBox(grbTruyenTranh); txtTongTienHD.Text = TongTien().ToString();

                        break;
                    }
                }

                if (!KTHD)
                {
                    state = false;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearGroupBox(grbTruyenTranh);
            if (KTHD)
            {
                dgvTruyenTranh = dgvTmp; MessageBox.Show(dgvTmp.Rows.Count.ToString());

                dgvTmp = null;

            }
            else
            {
                dgvTruyenTranh.DataSource = busCTDHN.LayCTDHN(txtMaDHN.Text.Trim());
            }
        }
        public bool KTHD = true;

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbTruyenTranh) && CheckNumber())
            {
                for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                {
                    if (dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim() == txtMaTT.Text.Trim())
                    {
                        dgvTruyenTranh.Rows[i].Cells[1].Value = txtTenTT.Text;
                        dgvTruyenTranh.Rows[i].Cells[2].Value = txtSoLuong.Text;
                        dgvTruyenTranh.Rows[i].Cells[3].Value = txtGiaTien.Text;
                        ClearGroupBox(grbTruyenTranh); txtTongTienHD.Text = TongTien().ToString();
                        if (!KTHD)
                        {
                            state = false;
                        }
                        break;
                    }
                }
            }
        }
        bool CheckItemsInCart()
        {
            if (dgvTruyenTranh.Rows.Count == 0)
            {
                errorProvider1.SetError(dgvTruyenTranh, Properties.Resources.NoneItemInCart);
                return false;
            }
            return true;
        }
        public void GetInfo(string mahd, string manv, string manxb, string ngaynhap)
        {
            txtMaDHN.Text = mahd;
            txtMaNV.Text = manv;
            txtMaNXB.Text = manxb; dtpNgayNhap.Value = Convert.ToDateTime(ngaynhap);

        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbNhanVien) && CheckNull(grbNXB) && CheckItemsInCart() && MessageBox.Show(string.Format(Properties.Resources.AddMessage, "đơn hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DTODHN dhn = new DTODHN(txtMaDHN.Text.Trim(), txtMaNV.Text.Trim(), txtMaNXB.Text.Trim(), dtpNgayNhap.Value.ToString("yyyy-MM-dd"));

                if (busDHN.ThemDHN(dhn))
                {
                    for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                    {
                        DTOCTDHN ct = new DTOCTDHN(txtMaDHN.Text.Trim(), dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim(), Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[2].Value.ToString()), Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[3].Value.ToString()));
                        busCTDHN.ThemCTDHN(ct);
                    }
                    MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Thêm"), Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Information); btnIn.PerformClick();
                    state = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Thêm"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbNhanVien) && CheckNull(grbNXB) && CheckItemsInCart() && MessageBox.Show(string.Format(Properties.Resources.EditMessage, "đơn hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DTODHN dhn = new DTODHN(txtMaDHN.Text.Trim(), txtMaNV.Text.Trim(), txtMaNXB.Text.Trim(), dtpNgayNhap.Value.ToString("yyyy-MM-dd"));

                if (busDHN.SuaDHN(dhn))
                {
                    busCTDHN.XoaTatCaCTDHN(txtMaDHN.Text.Trim());
                    for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                    {
                        DTOCTDHN ct = new DTOCTDHN(txtMaDHN.Text.Trim(), dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim(), Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[2].Value.ToString()), Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[3].Value.ToString()));
                        busCTDHN.ThemCTDHN(ct);
                    }
                    MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Sửa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    state = true;
                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Sửa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //else
            //{
            //    MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbNhanVien) && CheckNull(grbNXB) && dgvTruyenTranh.Rows.Count > 0 && MessageBox.Show(string.Format(Properties.Resources.DeleteMessage, "đơn hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
               
                if (busDHN.XoaDHN(txtMaDHN.Text))
                {
                    MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Xóa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close();

                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Xóa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            else
            {
                MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.quyenQL == true)
            {
                ClearGroupBox(grbNhanVien);
            }
            ClearGroupBox(grbNXB);
            ClearGroupBox(grbTruyenTranh);
            dgvTruyenTranh.DataSource = null;
            txtTongTienHD.Text = "";
            txtMaDHN.Text = busDHN.TaoMa().Rows[0][0].ToString(); dtpNgayNhap.Value = DateTime.Now;
        }
        DataGridView dgvTmp;
        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            if (KTHD)
            {

                dgvTmp = dgvTruyenTranh;
                if (dgvTruyenTranh.Rows.Count > 0 && txtTimKiem.Text != "")
                {
                    for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                    {
                        if (dgvTruyenTranh.Rows[i].Cells[1].Value.ToString().Trim() != txtTimKiem.Text.Trim())
                        {

                            dgvTruyenTranh.Rows.RemoveAt(i);

                        }
                    }
                }
                else
                {
                    dgvTruyenTranh.DataSource = busCTDHN.TimKiemCTDHN(txtMaDHN.Text.Trim(), txtTimKiem.Text);
                }

            }
            else
            {
                dgvTruyenTranh.DataSource = busCTDHN.TimKiemCTDHN(txtMaDHN.Text.Trim(), txtTimKiem.Text);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                if (CheckNull(grbNhanVien) && CheckNull(grbNXB) && dgvTruyenTranh.RowCount > 0)
                {
                    int sl = 0;
                    for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                    {
                        sl += Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[2].Value.ToString().Trim());

                    }
                    frmDonHangNhap hoadon = new frmDonHangNhap();

                    hoadon.GetInfo(dtpNgayNhap.Value.ToString("d"), txtMaDHN.Text, txtMaNXB.Text, txtTenNXB.Text, txtMaNV.Text, txtTenNV.Text, txtTongTienHD.Text, sl.ToString(), busCTDHN.LayCTDHN(txtMaDHN.Text));
                    if (hoadon.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.SaveInfoMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            CheckNumber();
        }

        private void txtGiaTien_Leave(object sender, EventArgs e)
        {
            CheckNumber();
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            if (!KTHD)
            {
                state = false;
            }
        }
    }
}
