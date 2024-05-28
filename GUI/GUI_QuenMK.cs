using BUS;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;//GeneratePassword
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuenMK : Form
    {
        public frmQuenMK()
        {
            InitializeComponent();
        }
        BUSNhanVien nv = new BUSNhanVien();   
        private void frmQuenMK_Load(object sender, EventArgs e)
        {
            txtMatKhau1.UseSystemPasswordChar = true;
            txtMatKhau2.UseSystemPasswordChar = true;
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra giá trị 
        bool CheckValue()
        {
            bool kt = true;
            if (txtTenDN.Text.Length < 2 || txtTenDN.Text.Length > 20)
            {
                errorProvider1.SetError(txtMatKhau1, "Tên đăng nhập chỉ gồm từ 2 - 20 kí tự");
                kt = false;
            }
            if (txtMatKhau1.Text.Length < 2 || txtMatKhau1.Text.Length > 20)
            {
                errorProvider1.SetError(txtMatKhau1, "Mật khẩu chỉ gồm từ 2 - 20 kí tự");
                kt =  false;
            }
            return kt;
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

        string random = Membership.GeneratePassword(5, 2);
        string xt = "";
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra rỗng
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
        bool KiemTraTaiKhoan()
        {
            errorProvider1.Clear();
            try
            {
                if (nv.KiemTraNVDaCoTaiKhoan(txtMaNV.Text).Rows[0][0].ToString() != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(Properties.Resources.AccountExist, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
            catch
            {
                errorProvider1.SetError(txtMaNV, "Mã nhân viên không tồn tại");
                return false;
            }

        }

        /// Created by Nguyễn Minh Hiền – 05/04/2024: Gửi mã xác nhận qua gmail
        private void btnGuiMaXN_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != ""  && KiemTraTaiKhoan())
            {
                try
                {
                   string gmail = nv.LayGmailNhanVien(txtMaNV.Text.Trim()).Rows[0][0].ToString();
                    MailMessage ms = new MailMessage();
                    ms.From = new MailAddress("hibarikyoya2k4@gmail.com");
                    ms.Subject = "XÁC THỰC TÀI KHOẢN";
                    ms.To.Add(new MailAddress(gmail));
                    xt = random;
                    ms.Body = $"<h1>Đây là mã của bạn: {xt}</h1>";
                    ms.IsBodyHtml = true;
                    var sptmClient = new SmtpClient("smtp.gmail.com")//Gửi email qua SMTP (Simple Mail Transfer Protocol)
                    {
                        Port = 587,//Cổng 587 - (thường) chỉ định cho việc gửi email qua giao thức SMTP
                        Credentials = new NetworkCredential("hibarikyoya2k4@gmail.com", "kcuc mdep xotz riqe"),//thiết lập thông tin đăng nhập vào tài khoản Gmail của người gửi. Lấy mã bằng cách kích hoạt bảo vệ 3 lớp trên gmail
                        EnableSsl = true, // Sử dụng SSL/TLS để mã hóa
                    };
                    sptmClient.Send(ms);
                    errorProvider2.SetError(btnGuiMaXN,"Mã sẽ được gửi đến bạn! Vui lòng kiểm tra email");
                }
                catch
                {
                    MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }
        bool CheckAccountName()
        {
            errorProvider1.Clear();
            if (nv.KiemTraTenDN(txtTenDN.Text.Trim()) != "0")
            {
                errorProvider1.SetError(txtTenDN, "Tên đăng nhập đã tồn tại");
                return false;
            }
            return true;
        }

        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thực hiện đăng kí lại tài khoản
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (CheckNull() && CheckValue() && CheckAccountName())
            {
                if (txtMaXN.Text.Trim() == xt)
                {
                   if (txtMatKhau1.Text.Trim() == txtMatKhau2.Text.Trim())
                    {
                        if (nv.DangKy(txtTenDN.Text, txtMatKhau1.Text, txtMaNV.Text.Trim()))
                        {
                            MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage,"Khôi phục tài khoản"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Khôi phục tài khoản"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.NotMatchPassword, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    errorProvider1.SetError(txtMaXN, "Mã xác nhận không chính xác");
                }
            }
       
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
            txtMatKhau1.Clear();
            txtMatKhau2.Clear();
            txtMaNV.Clear();
            txtMaXN.Clear();
            txtTenDN.Focus();
            errorProvider1.Clear();
            errorProvider2.Clear();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thoát khỏi form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
