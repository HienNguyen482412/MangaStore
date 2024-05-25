using BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BUSNhanVien nv = new BUSNhanVien();
        public static bool quyenQL = false;
        public static string tenNV = "";
        public static string maNV = "";
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Khi chọn vào biểu tượng icon nếu ẩn mật khẩu thì thực hiện hiển thị và thay đổi icon và ngược lại
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Mở form đăng kí

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            this.Hide();
            if (dk.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Mở form quên mật khẩu
        private void llbQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMK qmk = new frmQuenMK();
            this.Hide();
            if (qmk.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra trường nhập rỗng
        bool CheckNull()
        {
            bool ck = true;
            if (txtTenDN.Text == "")
            {
                ck = false;
                errorProvider1.SetError(txtTenDN, "Không được bỏ trống thông tin ");
            }
            if (txtTenDN.Text == "")
            {
                ck = false;
                errorProvider1.SetError(txtMatKhau, "Không được bỏ trống thông tin ");
            }
            if (rdoNhanVien.Checked == false && rdoQuanLy.Checked == false)
            {
                ck = false;
                errorProvider1.SetError(rdoNhanVien, "Chưa chọn quyền");
            }
            return ck;
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thực hiện đăng nhập

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string messageContent;
            errorProvider1.Clear();
            if (CheckNull())
            {
                if (rdoNhanVien.Checked == true)
                {
                    if (Convert.ToInt16(nv.KiemTraDangNhap(txtTenDN.Text.Trim(), txtMatKhau.Text.Trim())) > 0)
                    {
                        messageContent = string.Format(Properties.Resources.SuccessfullActionMessage, "Đăng nhập");
                        MessageBox.Show(messageContent,Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maNV = nv.LayMaNV(txtTenDN.Text.Trim(), txtMatKhau.Text.Trim());
                        tenNV = nv.LayTenNV(txtTenDN.Text.Trim(), txtMatKhau.Text.Trim());
                        quyenQL = false;
                        frmTrangChu tc = new frmTrangChu();
                        this.Hide();
                        quyenQL = false;
                        if (tc.ShowDialog() == DialogResult.Cancel)
                        {
                            this.Show();
                            btnLamMoi.PerformClick();
                        }
                    }
                    else
                    {
                        messageContent = string.Format(Properties.Resources.UnsuccessfulActionMessage, "Đăng nhập");
                        MessageBox.Show(messageContent, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (txtTenDN.Text == "admin" && txtMatKhau.Text == "123")
                    {
                        messageContent = string.Format(Properties.Resources.SuccessfullActionMessage, "Đăng nhập");
                        MessageBox.Show(messageContent, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmTrangChu tc = new frmTrangChu();
                        this.Hide();
                        quyenQL = true;
                        if (tc.ShowDialog() == DialogResult.Cancel)
                        {
                            this.Show();
                            btnLamMoi.PerformClick();
                        }
                    }
                    else
                    {
                        messageContent = string.Format(Properties.Resources.UnsuccessfulActionMessage, "Đăng nhập");
                        MessageBox.Show(messageContent, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                messageContent = string.Format(Properties.Resources.IncompleteInformationMessage, "Đăng nhập");
                MessageBox.Show(messageContent, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// Created by Nguyễn Minh Hiền – 05/04/2024: Làm mới các trường nhập
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtTenDN.Clear();
            txtMatKhau.Clear();
            rdoNhanVien.Checked = false;
            rdoQuanLy.Checked = false;
        }
    
        private void frmDangNhap_Shown(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoQuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}