using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Net.Mail;
using System.Windows.Forms;
namespace GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUSNhanVien busNV = new BUSNhanVien();
        void RefreshControl()
        {
            txtTenNV.Focus();
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }

            }
            txtTenNV.Clear();
            cboGioiTinh.SelectedIndex = 0;
            dgvNhanVien.DataSource = busNV.LayNhanVien();
            dtpNgayBD.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dtpNgaySinh.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtMaNV.Text = busNV.TaoMa().Rows[0][0].ToString();
            errorProvider1.Clear();
        }
        bool CheckNull()
        {
            bool ck = true;
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna2TextBox && c.Text.Trim() == "")
                {
                    errorProvider1.SetError(c, "Không được bỏ trống thông tin");
                    ck = false;

                }

            }
            return ck;
        }
        bool CheckNumber()
        {
            bool ck = true;

            if (!int.TryParse(txtLuong.Text, out int c))
            {
                errorProvider1.SetError(txtLuong, "Dữ liệu không đúng định dạng");
                ck = false;
            }
            else
            {
                errorProvider1.SetError(txtLuong, "");
            }
            return ck;


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
                errorProvider1.SetError(dtpNgaySinh,"Thông tin ngày sinh không hợp lệ");
                return false;

            }
        }
        public void LayThongTinNV(out string ma, out string ten)
        {
            ma = txtMaNV.Text;
            ten = txtTenNV.Text;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            RefreshControl();

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                dtpNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtEmail.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtpNgayBD.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch
            {
                txtMaNV.Text = dgvNhanVien.Rows[0].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[0].Cells[1].Value.ToString();
                cboGioiTinh.Text = dgvNhanVien.Rows[0].Cells[2].Value.ToString().Trim();
                dtpNgaySinh.Text = dgvNhanVien.Rows[0].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[0].Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[0].Cells[5].Value.ToString();
                txtEmail.Text = dgvNhanVien.Rows[0].Cells[6].Value.ToString();
                dtpNgayBD.Text = dgvNhanVien.Rows[0].Cells[7].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[0].Cells[8].Value.ToString();
            }
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show("Bạn có muốn thêm nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && CheckNgaySinh() && CheckNumber())
                {
                    DTONhanVien nv = new DTONhanVien(txtMaNV.Text, txtTenNV.Text, cboGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtpNgayBD.Value.ToString("yyyy/MM/dd"), Convert.ToInt32(txtLuong.Text));
                    if (busNV.ThemNhanVien(nv) )
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshControl();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull() )
            {
                if (MessageBox.Show("Bạn có muốn sửa nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && CheckNgaySinh() && CheckNumber())
                {
                    DTONhanVien nv = new DTONhanVien(txtMaNV.Text, txtTenNV.Text, cboGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtpNgayBD.Value.ToString("yyyy/MM/dd"), Convert.ToInt32(txtLuong.Text));
                    if (busNV.SuaNhanVien(nv) )
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshControl();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (busNV.XoaNhanVine(txtMaNV.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshControl();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = busNV.TimKiemNhanVien(txtTimKiem.Text.Trim());
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().EndsWith("."))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Clear();
            }
            try
            {
                var addr = new MailAddress(txtEmail.Text.Trim());

            }
            catch
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Clear();

            }
        }

    }
}
