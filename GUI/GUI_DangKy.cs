using BUS;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        BUSNhanVien nv = new BUSNhanVien();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Ẩn mật khẩu khi form load
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtMatKhau1.UseSystemPasswordChar = true;
            txtMatKhau2.UseSystemPasswordChar = true;
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra giá trị 
        bool CheckValue()
        {
            if (txtTenDN.Text.Length < 2 || txtTenDN.Text.Length > 20)
            {
                errorProvider1.SetError(txtMatKhau1, "Tên đăng nhập chỉ gồm từ 2 - 20 kí tự");
                return false;
            }
            if (txtMatKhau1.Text.Length < 2 || txtMatKhau1.Text.Length > 20)
            {
                errorProvider1.SetError(txtMatKhau1, "Mật khẩu chỉ gồm từ 2 - 20 kí tự");
                return false;
            }
            return true;
        }

        /// Created by Nguyễn Minh Hiền – 05/04/2024: Khi chọn vào biểu tượng icon nếu ẩn mật khẩu thì thực hiện hiển thị và thay đổi icon và ngược lại
        private void txtMatKhau1_IconRightClick(object sender, EventArgs e)
        {
            if (txtMatKhau1.UseSystemPasswordChar)
            {
                txtMatKhau1.IconRight = Image.FromFile(@"E:\Data_CHMH\Icon\icons8-eye-50.png");
                txtMatKhau1.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhau1.UseSystemPasswordChar = true;
                txtMatKhau1.IconRight = Image.FromFile(@"E:\Data_CHMH\Icon\icons8-closed-eye-50.png");
            }
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Khi chọn vào biểu tượng icon nếu ẩn mật khẩu thì thực hiện hiển thị và thay đổi icon và ngược lại
        private void txtMatKhau2_IconRightClick(object sender, EventArgs e)
        {
            if (txtMatKhau2.UseSystemPasswordChar)
            {
                txtMatKhau2.IconRight = Image.FromFile(@"E:\Data_CHMH\Icon\icons8-eye-50.png");
                txtMatKhau2.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhau2.UseSystemPasswordChar = true;
                txtMatKhau2.IconRight = Image.FromFile(@"E:\Data_CHMH\Icon\icons8-closed-eye-50.png");
            }
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Làm mới các trường nhập 
        void Refresh()
        {
            txtTenDN.Clear();
            txtMatKhau1.Clear();
            txtMatKhau2.Clear();
            txtMaNV.Clear();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra nhân viên đã có tài khoản hay chưa
        bool KiemTraTaiKhoan()
        {
            try
            {
                if (nv.KiemTraNVDaCoTaiKhoan(txtMaNV.Text).Rows[0][0].ToString() == "")
                {
                    return true;
                }
                else
                {
                    errorProvider1.SetError(txtMaNV, "Mỗi một nhân viên chỉ có một tài khoản");
                    return false;
                }

            }
            catch
            {
                errorProvider1.SetError(txtMaNV, "Mã nhân viên không tồn tại");
                return false;
            }
            
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra rỗng cho các trường dữ liệu nhập
        bool CheckNull()
        {
            bool ck = true;
            foreach (Control c in Controls)
            {
                if (c is Guna2TextBox && c.Text == "")
                {
                    errorProvider1.SetError(c, "Không được bỏ trống thông tin");
                    ck = false;
                }
            }
            return ck;
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thực hiện đăng kí tài khoản cho nhân viên
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (CheckNull() )
            {
                if (txtMatKhau1.Text.Trim() == txtMatKhau2.Text.Trim())
                {
                    if (KiemTraTaiKhoan() && CheckValue() && nv.DangKy(txtTenDN.Text.Trim(), txtMatKhau1.Text.Trim(), txtMaNV.Text.Trim()) )
                    {
                        MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage,"Đăng kí"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Đăng kí"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                     MessageBox.Show(Properties.Resources.NotMatchPassword, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.IncompleteInformationMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
