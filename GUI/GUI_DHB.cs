using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDHB : Form
    {
        public frmDHB()
        {
            InitializeComponent();
        }
        BUS_DHB busDHB = new BUS_DHB();
        BUSCTDHB busCTDHB = new BUSCTDHB();
        BUSTruyenTranh busTruyenTranh = new BUSTruyenTranh();
        public bool KTHD = true;
        public void TaoCot()
        {
            dgvTruyenTranh.Columns.Add("clMa", "Mã truyện");
            dgvTruyenTranh.Columns.Add("clTen", "Tên truyện");
            dgvTruyenTranh.Columns.Add("clSoLuong", "Số lượng");
            dgvTruyenTranh.Columns.Add("clGiaTien", "Giá tiền");
        }
        bool CheckNumber()
        {
            bool ck = true;

            if (!int.TryParse(txtSoLuong.Text, out int c))
            {
                errorProvider1.SetError(txtSoLuong, "Dữ liệu không đúng định dạng");
                ck = false;
            }
            else
            {
                errorProvider1.SetError(txtSoLuong, "");
            }
            return ck;


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
                    MessageBox.Show(Properties.Resources.ExistedItemMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    break;
                }
            }
            return ck;
        }
        void Refresh()
        {
            ClearGroupBox(grbNhanVien);
            ClearGroupBox(grbKH);
            ClearGroupBox(grbTruyenTranh);
            dgvTruyenTranh.DataSource = null;
            txtTongTienHD.Text = "";
            txtMaDHB.Text = busDHB.TaoMa().Rows[0][0].ToString(); dtpNgayBan.Value = DateTime.Now;

        }
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.guna2ControlBox1.Visible = true;
            if (kh.ShowDialog() == DialogResult.Cancel)
            {
                kh.LaYThongTinKH(out string ma, out string ten, out string gt, out string diachi, out DateTime ngaysinh, out string sdt);
                txtMaKH.Text = ma;
                txtTenKH.Text = ten;
                cboGioiTinh.Text = gt;
                txtDiaChi.Text = diachi;
                dtpNgaySinh.Value = ngaysinh;
                txtSDT.Text = sdt;

            }
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
                tt.LayThongTinTruyenTranh(out string ma, out string ten, out string giatien);
                txtMaTT.Text = ma;
                txtTenTT.Text = ten;
                txtGiaTien.Text = giatien;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbTruyenTranh) && CheckCart(txtMaTT.Text) && CheckNumber())
            {
                if (Convert.ToInt16(txtSoLuong.Text) <= Convert.ToInt16(busTruyenTranh.LaySoLuongTruyen(txtMaTT.Text)))
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
                }
                else
                {
                    MessageBox.Show(Properties.Resources.NotEnoughQuantity, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }

            }
        }

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

                        break;
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbTruyenTranh))
            {
                if (KTHD)
                {
                    for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                    {
                        if (dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim() == txtMaTT.Text.Trim())
                        {
                            dgvTruyenTranh.Rows.RemoveAt(i); ClearGroupBox(grbTruyenTranh); txtTongTienHD.Text = TongTien().ToString();

                            break;
                        }
                    }
                }
                else
                {
                    busCTDHB.XoaCTDHB(txtMaDHB.Text.Trim(), txtMaTT.Text.Trim());
                    for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                    {
                        if (dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim() == txtMaTT.Text.Trim())
                        {
                            dgvTruyenTranh.Rows.RemoveAt(i); ClearGroupBox(grbTruyenTranh); txtTongTienHD.Text = TongTien().ToString();

                            break;
                        }
                    }
                }
            }
        }
        public void GetInfo(string mahd, string manv, string manxb, string ngaynhap)
        {
            txtMaDHB.Text = mahd;
            txtMaNV.Text = manv;
            txtMaKH.Text = manxb; dtpNgayBan.Value = Convert.ToDateTime(ngaynhap);

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
                dgvTruyenTranh.DataSource = busCTDHB.LayCTDHB(txtMaDHB.Text.Trim());
            }
        }

        private void frmDHB_Load(object sender, EventArgs e)
        {
            if (KTHD)
            {
                TaoCot();
                txtMaDHB.Text = busDHB.TaoMa().Rows[0][0].ToString();
                if (frmDangNhap.quyenQL == false)
                {
                    btnThemNhanVien.Visible = false;
                    txtTenNV.Text = frmDangNhap.tenNV;
                    txtMaNV.Text = frmDangNhap.maNV;
                }
            }
            else
            {
                if (frmDangNhap.quyenQL == false)
                {
                    btnThemNhanVien.Visible = false;
                }
                BUSNhanVien nv = new BUSNhanVien();
                BUSKhachHang kh = new BUSKhachHang();
                dgvTruyenTranh.DataSource = busCTDHB.LayCTDHB(txtMaDHB.Text);
                DataTable dtnv = nv.LayNhanVien(txtMaNV.Text.Trim());
                txtTenNV.Text = dtnv.Rows[0][0].ToString();
                DataTable dtkh = kh.LayKhachHang(txtMaKH.Text.Trim());
                txtTenKH.Text = dtkh.Rows[0][0].ToString();
                cboGioiTinh.Text = dtkh.Rows[0][1].ToString().Trim();
                dtpNgaySinh.Text = dtkh.Rows[0][2].ToString().Trim();
                txtDiaChi.Text = dtkh.Rows[0][3].ToString().Trim();
                txtSDT.Text = dtkh.Rows[0][4].ToString().Trim();
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

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbNhanVien) && CheckNull(grbKH) && dgvTruyenTranh.Rows.Count > 0 && MessageBox.Show(string.Format(Properties.Resources.AddMessage,"đơn hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DTODHB dhb = new DTODHB(txtMaDHB.Text.Trim(), txtMaNV.Text.Trim(), txtMaKH.Text.Trim(), dtpNgayBan.Value.ToString("yyyy-MM-dd"));

                if (busDHB.ThemDHB(dhb))
                {
                    for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                    {
                        DTOCTDHB ct = new DTOCTDHB(txtMaDHB.Text.Trim(), dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim(), Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[2].Value.ToString()), Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[3].Value.ToString()));
                        busCTDHB.ThemCTDHB(ct);
                    }
                    MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Thêm"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    btnIn.PerformClick();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Thêm"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbNhanVien) && CheckNull(grbKH) && MessageBox.Show(string.Format(Properties.Resources.EditMessage, "đơn hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DTODHB dhb = new DTODHB(txtMaDHB.Text.Trim(), txtMaNV.Text.Trim(), txtMaKH.Text.Trim(), dtpNgayBan.Value.ToString("yyyy-MM-dd"));

                if (busDHB.SuaDHB(dhb))
                {

                    for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                    {
                        DTOCTDHB ct = new DTOCTDHB(txtMaDHB.Text.Trim(), dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim(), Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[2].Value.ToString()), Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[3].Value.ToString()));
                        busCTDHB.XoaCTDHB(txtMaDHB.Text.Trim(), dgvTruyenTranh.Rows[i].Cells[0].Value.ToString().Trim());
                        busCTDHB.ThemCTDHB(ct);
                    }
                    MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Sửa"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Sửa"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (CheckNull(grbNhanVien) && CheckNull(grbKH) && dgvTruyenTranh.Rows.Count > 0 && MessageBox.Show(string.Format(Properties.Resources.DeleteMessage, "đơn hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (busDHB.XoaDHB(txtMaDHB.Text))
                {
                    MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Xóa"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Xóa"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show(Properties.Resources.IncompleteInformationMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            Refresh();
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
                    dgvTruyenTranh.DataSource = busCTDHB.TimKiemCTDHB(txtMaDHB.Text.Trim(), txtTimKiem.Text);
                }

            }
            else
            {
                dgvTruyenTranh.DataSource = busCTDHB.TimKiemCTDHB(txtMaDHB.Text.Trim(), txtTimKiem.Text);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
            if (CheckNull(grbNhanVien) && CheckNull(grbKH) && dgvTruyenTranh.RowCount > 0)
            {
                int sl = 0;
                for (int i = 0; i < dgvTruyenTranh.RowCount; i++)
                {
                    sl += Convert.ToInt32(dgvTruyenTranh.Rows[i].Cells[2].Value.ToString().Trim());

                }
                frmDonHangBan hoadon = new frmDonHangBan();
                hoadon.GetInfo(dtpNgayBan
                    .Value.ToString("d"), txtMaDHB.Text, txtMaKH.Text, txtTenKH.Text, txtMaNV.Text, txtTenNV.Text, txtTongTienHD.Text, sl.ToString(), busCTDHB.LayCTDHB(txtMaDHB.Text));
                if (hoadon.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            CheckNumber();
        }
    }
}
