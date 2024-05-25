using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinNhanVien : Form
    {
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        BUSNhanVien busNV = new BUSNhanVien();
        void CapNhatThongTin()
        {
            DataTable dt = busNV.LayThongTinNhanVien(frmDangNhap.maNV);
            txtMaNV.Text = dt.Rows[0][0].ToString();
            txtTenNV.Text = dt.Rows[0][1].ToString();
            cboGioiTinh.Text = dt.Rows[0][2].ToString().Trim();
            dtpNgaySinh.Text = dt.Rows[0][3].ToString();
            txtDiaChi.Text = dt.Rows[0][4].ToString();
            txtSDT.Text = dt.Rows[0][5].ToString();
            txtEmail.Text = dt.Rows[0][6].ToString();
            dtpNgayBD.Text = dt.Rows[0][7].ToString();
            txtLuong.Text = dt.Rows[0][8].ToString();
            txtTenDN.Text = dt.Rows[0][9].ToString();
            txtMatKhau.Text = dt.Rows[0][10].ToString();
            txtMatKhau.UseSystemPasswordChar = true;
        }
        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            CapNhatThongTin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_IconRightClick(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar)
            {
                txtMatKhau.IconRight = Image.FromFile(@"E:\Data_CHMH\Icon\icons8-eye-50.png");
                txtMatKhau.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.IconRight = Image.FromFile(@"E:\Data_CHMH\Icon\icons8-closed-eye-50.png");
            }
        }
        bool CheckValue()
        {
           
            bool ck = true;
            if (txtTenNV.Text.Length < 2 || txtTenNV.Text.Length > 50)
            {
                errorProvider1.SetError(txtTenNV, "Tên nhân viên từ 2 đến 50 kí tự");
                ck = false;
            }
            if (txtDiaChi.Text.Length < 2 || txtDiaChi.Text.Length > 50)
            {
                errorProvider1.SetError(txtDiaChi, "Địa chỉ từ 2 đến 50 kí tự");
                ck = false;
            }
            if (Regex.IsMatch(txtSDT.Text.Trim(), "[0-9]{10}") == false)
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không hợp lệ");
                ck = false;
            }
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ");
                ck = false;
            }
            if (!ck)
            {
                return false;
            }
            return true;
        }
        bool CheckNull()
        {
            bool kt = true;
            foreach (Control c in this.Controls)
            {
                if (c is Guna2TextBox && c.Text == "")
                {
                    kt = false;
                    errorProvider1.SetError(c, "Không được để trống thông tin");
                }
            }
            return kt;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DTONhanVien nv = new DTONhanVien(txtMaNV.Text, txtTenNV.Text, cboGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtpNgayBD.Value.ToString("yyyy/MM/dd"), Convert.ToInt32(txtLuong.Text),txtTenDN.Text, txtMatKhau.Text);
            errorProvider1.Clear();
            if (CheckNull() && CheckValue() && MessageBox.Show(Properties.Resources.UpdateInfoMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (busNV.SuaThongTinNhanVien(nv))
                {
                    MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Cập nhật"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); CapNhatThongTin();
                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Cập nhật"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            CapNhatThongTin();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
