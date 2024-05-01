using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        BUSKhachHang busKH = new BUSKhachHang();

        public void LaYThongTinKH(out string ma, out string ten, out string gt, out string diachi, out DateTime ngaysinh, out string sdt)
        {
            ma = txtMaKH.Text;
            ten = txtTenKH.Text;
            gt = cboGioiTinh.Text.Trim();
            diachi = txtDiaChi.Text;
            ngaysinh = dtpNgaySinh.Value;
            sdt = txtSDT.Text;
        }
        bool CheckNgaySinh()
        {

            if (Convert.ToDateTime(dtpNgaySinh.Value.ToString("dd/MM/yyyy")) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                errorProvider1.SetError(dtpNgaySinh, "");
                return true;
            }
            else
            {
                errorProvider1.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ");
                return false;
            }
        }
        bool CheckNull()
        {
            bool ck = true;
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna2TextBox && c.Text == "")
                {
                    errorProvider1.SetError(c, "Không được bỏ trống thông tin");
                    ck = false;

                }

            }
            return ck;
        }
        void RefreshControl()
        {
            txtTenKH.Focus();
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }

            }
            txtTenKH.Clear();
            cboGioiTinh.SelectedIndex = 0;
            dgvKhachHang.DataSource = busKH.LayKhachHang();
            dtpNgaySinh.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtMaKH.Text = busKH.TaoMa().Rows[0][0].ToString();
            errorProvider1.Clear();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboGioiTinh.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                dtpNgaySinh.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                txtMaKH.Text = dgvKhachHang.Rows[0].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[0].Cells[1].Value.ToString();
                cboGioiTinh.Text = dgvKhachHang.Rows[0].Cells[2].Value.ToString().Trim();
                dtpNgaySinh.Text = dgvKhachHang.Rows[0].Cells[3].Value.ToString().Trim();
                txtSDT.Text = dgvKhachHang.Rows[0].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[0].Cells[4].Value.ToString();
            }

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.AddMessage, "khách hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && CheckNgaySinh())
                {
                    DTOKhachHang kh = new DTOKhachHang(txtMaKH.Text, txtTenKH.Text, cboGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtDiaChi.Text, txtSDT.Text);
                    if (busKH.ThemKhachHang(kh))
                    {
                        MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Thêm"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshControl();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Thêm"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull() && CheckNgaySinh())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.EditMessage, "khách hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && CheckNgaySinh())
                {
                    DTOKhachHang kh = new DTOKhachHang(txtMaKH.Text, txtTenKH.Text, cboGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtDiaChi.Text, txtSDT.Text);
                    if (busKH.SuaKhachHang(kh))
                    {
                        MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Sửa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); RefreshControl();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Sửa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckNull() && CheckNgaySinh())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.DeleteMessage, "khách hàng"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (busKH.XoaKhachHang(txtMaKH.Text))
                    {
                        MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Xóa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshControl();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Xóa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = busKH.TimKiemKhachHang(txtTimKiem.Text.Trim());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
