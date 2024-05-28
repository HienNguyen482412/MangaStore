using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thêm các form vào trong form ở trang chủ
        /// </summary>
        /// <param name="form">Tên form</param>
        private void AddFormInPanel(object form)
        {
            if (this.pnlFormContainer.Controls.Count > 0)
            {
                this.pnlFormContainer.Controls.RemoveAt(0);
            }
            Form newForm = form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.pnlFormContainer.Controls.Add(newForm);
            this.pnlFormContainer.Tag = newForm;
            newForm.Show();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenuContainer.Width == 228)
            {
                pnlMenuContainer.Width = 68;
                this.Width = 950; pnlBillContainer.Height = 60;
                btnThongKe.Enabled = true;
                btnThongKe.Visible = true;
                picStoreName.Visible = false;
                if (frmDangNhap.quyenQL == false)
                {
                    pnlThongTinNV.Visible = false;
                }
                toolTip1.Active = true;
            }
            else
            {
                pnlMenuContainer.Width = 228;
                this.Width = 1084;
                picStoreName.Visible = true;
                if (frmDangNhap.quyenQL == false)
                {
                    pnlThongTinNV.Visible = true;
                }
                toolTip1.Active = false;
            }

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (pnlMenuContainer.Width == 228)
            {
                if (pnlBillContainer.Height == 187)
                {
                    pnlBillContainer.Height = 60;
                    btnThongKe.Enabled = true;
                    btnThongKe.Visible = true;
                }
                else
                {
                    pnlBillContainer.Height = 187;
                    btnThongKe.Enabled = false;
                    btnThongKe.Visible = false;
                }
            }

            if (pnlMenuContainer.Width == 68)
            {
                btnMenu.PerformClick();
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmNhanVien());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmKhachHang());
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmNXB());
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmTacGia());
        }

        private void btnBoTruyen_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmBoTruyen());
        }

        private void btnManga_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmTruyenTranh());
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmDHN_List());
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmDHB_List());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new frmThongKe());
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (frmDangNhap.quyenQL == false)
            {
                btnNhanVien.Visible = false;
                lbMaNV.Text = frmDangNhap.maNV;
                lbTenNV.Text = frmDangNhap.tenNV;

            }
            else
            {
                pnlThongTinNV.Visible = false;
                btnThoat.Visible = true;
                btnTat.Visible = true;
                btnTat_QL.Visible = true;
                btnDangXuat_QL.Visible = true;

            }
            AddFormInPanel(new frmDHB_List());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien ttnv = new frmThongTinNhanVien();
            ttnv.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.LogOutMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.ExitMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnDangXuat_QL_Click(object sender, EventArgs e)
        {
            btnThoat.PerformClick();
        }

        private void btnTat_QL_Click(object sender, EventArgs e)
        {
            btnTat.PerformClick();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.LogOutMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
