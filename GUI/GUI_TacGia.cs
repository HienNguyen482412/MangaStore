using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        BUSTacGia busTacGia = new BUSTacGia();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy thông tin tác giả 
        public void LayThongTinTacGia(out string matg, out string tentg)
        {
            matg = txtMaTG.Text;
            tentg = txtTenTG.Text;
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra giá trị các textbox
        bool CheckValue()
        {
            if (txtTenTG.Text.Length < 2 || txtTenTG.Text.Length >100)
            {
                errorProvider1.SetError(txtTenTG, "Tên tác giả có độ dài từ 2 đến 100 kí tự");
                return false;
            }
            return true;
        }

        /// Created by Nguyễn Minh Hiền – 05/04/2024: Làm mới các điều khiển
        void RefreshControl()
        {
            txtTenTG.Focus();
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }

            }
            txtTenTG.Clear();
            dgvTG.DataSource = busTacGia.LayTacGia();
            txtMaTG.Text = busTacGia.TaoMa().Rows[0][0].ToString();
            errorProvider1.Clear();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra rỗng
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
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Làm mới các điều khiển
        private void frmGUI_TacGia_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Gán các giá trị chọn trên dgv cho các trường nhập tương ứng
        private void dgvTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaTG.Text = dgvTG.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenTG.Text = dgvTG.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                txtMaTG.Text = dgvTG.Rows[0].Cells[0].Value.ToString();
                txtTenTG.Text = dgvTG.Rows[0].Cells[1].Value.ToString();
            }
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm tác giả
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckValue() && MessageBox.Show(string.Format(Properties.Resources.AddMessage, "tác giả"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTOTacGia tg = new DTOTacGia(txtMaTG.Text, txtTenTG.Text);
                    if (busTacGia.ThemTacGia(tg))
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
        
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin tác giả
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckValue() && MessageBox.Show(string.Format(Properties.Resources.EditMessage, "bộ truyện"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTOTacGia tg = new DTOTacGia(txtMaTG.Text, txtTenTG.Text);
                    if (busTacGia.SuaTacGia(tg))
                    {
                        MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Sửa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshControl();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Sửa"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
     
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin tác giả
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.DeleteMessage, "bộ truyện"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (busTacGia.XoaTacGia(txtMaTG.Text))
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
           
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Làm mới các điều khiển
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị tác giả có tên tương ứng với tên cần tìm
        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            dgvTG.DataSource = busTacGia.TimKiemTacGia(txtTenTG.Text);
        }
    }
}
