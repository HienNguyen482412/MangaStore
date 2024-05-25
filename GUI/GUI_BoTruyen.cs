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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBoTruyen : Form
    {
        public frmBoTruyen()
        {
            InitializeComponent();
        }
        BUSBoTruyen busBoTruyen = new BUSBoTruyen();
        /// <summary>
        /// Hàm lấy thông tin truyện đang hiển thị trên textbox
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="ten"></param>
        /// Created by Nguyễn Minh Hiền – 05/04/2024:
        public void LayThongTinBoTruyen(out string ma, out string ten)
        {
            ma = txtMaBT.Text;
            ten = txtTenBT.Text;
        }
        /// Created by Nguyễn Minh Hiền – 05/05/2024: Kiểm tra giá trị trong textbox
        bool CheckValue()
        {
            errorProvider1.Clear();
            if (txtTenBT.Text.Length < 2 || txtTenBT.Text.Length > 50)
            {
                errorProvider1.SetError(txtTenBT, "Tên bộ truyện từ 2 đến 50 kí tự");
                return false;
            }
            return true;
        }

        /// Created by Nguyễn Minh Hiền – 05/04/2024: Làm mới các trường nhập và cập nhật datagirview
        void RefreshControl()
        {
            txtTenBT.Focus();
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }

            }
            txtTenBT.Clear();
            cboDoTuoi.SelectedIndex = 0;
            dgvBoTruyen.DataSource = busBoTruyen.LayBoTruyen();
            txtMaBT.Text = busBoTruyen.TaoMa().Rows[0][0].ToString();
            errorProvider1.Clear();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra rỗng đối với các trường thông tin nhập
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
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị form tác giả và chọn thông tin tác gỉa
        private void txtMaTg_IconRightClick(object sender, EventArgs e)
        {
            frmTacGia tacgia = new frmTacGia();
            tacgia.guna2ControlBox1.Visible = true;
            if (tacgia.ShowDialog() == DialogResult.Cancel)
            {
                tacgia.LayThongTinTacGia(out string ma, out string ten);
                txtMaTg.Text = ma;
                txtTenTG.Text = ten;
            }
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị form nhà xuất bản và chọn thông tin nhà xuất bản
        private void txtMaNXB_IconRightClick(object sender, EventArgs e)
        {
            frmNXB nxb = new frmNXB();
            nxb.guna2ControlBox1.Visible = true;
            if (nxb.ShowDialog() == DialogResult.Cancel) {
                nxb.LayThongTinNXB(out string ma, out string ten);
                txtMaNXB.Text = ma;
                txtTenNXB.Text = ten;
            }
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Chọn thông tin trên dgv và hiển thị thông tin được chọn trên các trường dữ liệu tương ứng
        private void dgvBoTruyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUSTacGia tacGia = new BUSTacGia();
            BUSNXB nxb = new BUSNXB();
            try
            {
                txtMaBT.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenBT.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaTg.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenTG.Text = tacGia.LayTenTg(txtMaTg.Text.Trim());
                txtMaNXB.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTenNXB.Text = nxb.LayTenNXB(txtMaNXB.Text.Trim());
                cboDoTuoi.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            }
            catch
            {
                txtMaBT.Text = dgvBoTruyen.Rows[0].Cells[0].Value.ToString();
                txtTenBT.Text = dgvBoTruyen.Rows[0].Cells[1].Value.ToString();
                txtMaTg.Text = dgvBoTruyen.Rows[0].Cells[2].Value.ToString();
                txtTenTG.Text = tacGia.LayTenTg(txtMaTg.Text.Trim());
                txtMaNXB.Text = dgvBoTruyen.Rows[0].Cells[3].Value.ToString();
                txtTenNXB.Text = nxb.LayTenNXB(txtMaNXB.Text.Trim());
                cboDoTuoi.Text = dgvBoTruyen.Rows[0].Cells[4].Value.ToString().Trim();
            }
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin bộ truyện
        private void btnThem_Click(object sender, EventArgs e)
        {

                if (CheckNull()&& CheckValue() && MessageBox.Show(string.Format(Properties.Resources.AddMessage, "bộ truyện"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTOBoTruyen bt = new DTOBoTruyen(txtMaBT.Text,txtTenBT.Text, txtMaTg.Text, txtMaNXB.Text, Convert.ToInt16(cboDoTuoi.Text.Trim()));
                    if (busBoTruyen.ThemBoTruyen(bt))
                    {
                        MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage,"Thêm"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshControl();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Properties.Resources.UnsuccessfulActionMessage, "Thêm"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
           
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Load form đồng thời làm mới các trường nhập và cập nhật dgv
        private void frmBoTruyen_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin truyện tranh
        private void btnSua_Click(object sender, EventArgs e)
        {

                if ( CheckNull()&& CheckValue() && MessageBox.Show(string.Format(Properties.Resources.EditMessage, "bộ truyện"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTOBoTruyen bt = new DTOBoTruyen(txtMaBT.Text, txtTenBT.Text, txtMaTg.Text, txtMaNXB.Text, Convert.ToInt16(cboDoTuoi.Text.Trim()));
                    if (busBoTruyen.SuaBoTruyen(bt))
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
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin bộ truyện
        private void btnXoa_Click(object sender, EventArgs e)
        {

                if (CheckNull()& MessageBox.Show(string.Format(Properties.Resources.DeleteMessage, "bộ truyện"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (busBoTruyen.XoaBoTruyen(txtMaBT.Text))
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
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Làm mới các trường dữ liệu nhập và cập nhật dgv
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm bộ truyện có tên tương ứng với tên cần tìm
        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            dgvBoTruyen.DataSource = busBoTruyen.TimKiemBoTruyen(txtTimKiem.Text.Trim());
        }
    }
}
