﻿using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNXB : Form
    {
        public frmNXB()
        {
            InitializeComponent();
        }
        BUSNXB busNXB = new BUSNXB();
        public void LayThongTinNXB(out string manxb, out string tennxb)
        {
            manxb = txtMaNXB.Text;
            tennxb = txtTenNXB.Text;

        }
        public void LayThongTinNXB(out string ma, out string ten, out string sdt, out string email, out string diachi)
        {
            ma = txtMaNXB.Text;
            ten = txtTenNXB.Text;
            sdt = txtSDT.Text;
            email = txtEmail.Text;
            diachi = txtDiaChi.Text;
        }
        void RefreshControl()
        {
            txtTenNXB.Focus();
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }

            }
            txtTenNXB.Clear();
            dgvNXB.DataSource = busNXB.LayNXB();
            txtMaNXB.Text = busNXB.TaoMa().Rows[0][0].ToString();
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


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.AddMessage, "nhà xuất bản"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTONXB nxb = new DTONXB(txtMaNXB.Text, txtTenNXB.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                    if (busNXB.ThemNXB(nxb))
                    {
                        MessageBox.Show(string.Format(Properties.Resources.SuccessfullActionMessage, "Thêm"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); RefreshControl();
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

        private void frmNXB_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNXB.Text = dgvNXB.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNXB.Text = dgvNXB.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNXB.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvNXB.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvNXB.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                txtMaNXB.Text = dgvNXB.Rows[0].Cells[0].Value.ToString();
                txtTenNXB.Text = dgvNXB.Rows[0].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNXB.Rows[0].Cells[2].Value.ToString();
                txtSDT.Text = dgvNXB.Rows[0].Cells[3].Value.ToString();
                txtEmail.Text = dgvNXB.Rows[0].Cells[4].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show(string.Format(Properties.Resources.EditMessage, "nhà xuất bản"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTONXB nxb = new DTONXB(txtMaNXB.Text, txtTenNXB.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                    if (busNXB.SuaNXB(nxb))
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
                if (MessageBox.Show(string.Format(Properties.Resources.DeleteMessage, "nhà xuất bản"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (busNXB.XoaNXB(txtMaNXB.Text))
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
            dgvNXB.DataSource = busNXB.TimKiemNXB(txtTenNXB.Text.Trim());
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().EndsWith("."))
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ");
                txtEmail.Clear();
            }
            try
            {
                var addr = new MailAddress(txtEmail.Text.Trim());

            }
            catch
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ");
                txtEmail.Clear();

            }
        }
    }
}
