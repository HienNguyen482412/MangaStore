using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTruyenTranh : Form
    {
        public frmTruyenTranh()
        {
            InitializeComponent();
        }
        BUSTruyenTranh busTT = new BUSTruyenTranh();
        public void LayThongTinTruyenTranh(out string ma, out string ten, out string giatien)
        {
            ma = txtMaTT.Text;
            ten = txtTenTT.Text;
            giatien = txtGiaTien.Text;
        }
        public void LayThongTinTruyenTranh(out string ma, out string ten)
        {
            ma = txtMaTT.Text;
            ten = txtTenTT.Text;
        }
        void RefreshControl()
        {
            txtTenTT.Focus();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }

            }
            cboDinhDang.SelectedIndex = 0;
            dgvTruyenTranh.DataSource = busTT.LayTruyenTranh();
            txtMaTT.Text = busTT.TaoMa().Rows[0][0].ToString();
            picAnhBia.Image = null;
            errorProvider1.Clear();
        }
        bool CheckNull()
        {
            bool ck = true;
            foreach (Control c in splitContainer1.Panel2.Controls)
            {

                if (c is Guna2TextBox && c.Text == "")
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

            if (!int.TryParse(txtSoLuong.Text, out int c) || c <0)
            {
                errorProvider1.SetError(txtSoLuong, "Dữ liệu không đúng định dạng");
                ck = false;
            }
            else
            {
                errorProvider1.SetError(txtSoLuong, "");
            }
            if (!int.TryParse(txtGiaTien.Text, out int d) || d<0)
            {
                errorProvider1.SetError(txtGiaTien, "Dữ liệu không đúng định dạng");
                ck = false;
            }
            else
            {
                errorProvider1.SetError(txtGiaTien, "");
            }
            return ck;


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.AddMessage, "bộ truyện"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && CheckNumber())
                {
                    DTOTruyenTranh tt = new DTOTruyenTranh(txtMaTT.Text, txtLink.Text, txtTenTT.Text, txtMaBT.Text, cboDinhDang.Text, Convert.ToInt16(txtSoLuong.Text), Convert.ToInt32(txtGiaTien.Text));
                    if (busTT.ThemTruyenTranh(tt))
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

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            fd.FilterIndex = 1;
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtLink.Text = Path.GetFullPath(fd.FileName);
                picAnhBia.Image = Image.FromFile(txtLink.Text);
            }
        }

        private void txtMaBT_IconRightClick(object sender, EventArgs e)
        {
            frmBoTruyen bt = new frmBoTruyen();
            bt.guna2ControlBox1.Visible = true;
            if (bt.ShowDialog() == DialogResult.Cancel)
            {
                bt.LayThongTinBoTruyen(out string ma, out string ten);
                txtMaBT.Text = ma;
                txtTenBT.Text = ten;
            }
        }

        private void frmTruyenTranh_Load(object sender, EventArgs e)
        {
            RefreshControl();
            dgvTruyenTranh.RowTemplate.Height = 80;
            ((DataGridViewImageColumn)dgvTruyenTranh.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void dgvTruyenTranh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUSBoTruyen bt = new BUSBoTruyen();
            try
            {
                txtMaTT.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[0].Value.ToString();
                byte[] imgdata = dgvTruyenTranh[1, e.RowIndex].Value as byte[];
                MemoryStream ms = new MemoryStream(imgdata);
                picAnhBia.Image = Image.FromStream(ms); txtLink.Text = Convert.ToBase64String(imgdata);
                txtTenTT.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaBT.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTenBT.Text = bt.LayTenBoTruyen(txtMaBT.Text.Trim());
                cboDinhDang.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                txtSoLuong.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtGiaTien.Text = dgvTruyenTranh.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch
            {
                txtMaTT.Text = dgvTruyenTranh.Rows[0].Cells[0].Value.ToString();
                byte[] imgdata = dgvTruyenTranh[1, 0].Value as byte[];
                MemoryStream ms = new MemoryStream(imgdata);
                picAnhBia.Image = Image.FromStream(ms); txtLink.Text = Convert.ToBase64String(imgdata);
                txtTenTT.Text = dgvTruyenTranh.Rows[0].Cells[2].Value.ToString();
                txtMaBT.Text = dgvTruyenTranh.Rows[0].Cells[3].Value.ToString();
                txtTenBT.Text = bt.LayTenBoTruyen(txtMaBT.Text.Trim());
                cboDinhDang.Text = dgvTruyenTranh.Rows[0].Cells[4].Value.ToString().Trim();
                txtSoLuong.Text = dgvTruyenTranh.Rows[0].Cells[5].Value.ToString();
                txtGiaTien.Text = dgvTruyenTranh.Rows[0].Cells[6].Value.ToString();

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.EditMessage, "bộ truyện"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && CheckNumber())
                {
                    DTOTruyenTranh tt = new DTOTruyenTranh(txtMaTT.Text, txtLink.Text, txtTenTT.Text, txtMaBT.Text, cboDinhDang.Text, Convert.ToInt16(txtSoLuong.Text), Convert.ToInt32(txtGiaTien.Text));
                    if (busTT.SuaTruyenTranh(tt))
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
            else
            {
                MessageBox.Show(Properties.Resources.InvalidInfoMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.DeleteMessage, "bộ truyện"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes /*&& *//*CheckNumber()*/)
                {
                    if (busTT.XoaTruyenTranh(txtMaTT.Text))
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
            dgvTruyenTranh.DataSource = busTT.TimKiemTruyenTranh(txtTimKiem.Text.Trim());
        }
    }
}
