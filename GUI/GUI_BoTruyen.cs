﻿using BUS;
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
    public partial class frmBoTruyen : Form
    {
        public frmBoTruyen()
        {
            InitializeComponent();
        }
        BUS_BoTruyen busBoTruyen = new BUS_BoTruyen();
        public void LayThongTinBoTruyen(out string ma, out string ten)
        {
            ma = txtMaBT.Text;
            ten = txtTenBT.Text;
        }
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

        private void dgvBoTruyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUS_TacGia tacgia = new BUS_TacGia();
            BUS_NXB nxb = new BUS_NXB();
            try
            {
                txtMaBT.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenBT.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaTg.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenTG.Text = tacgia.LayTenTg(txtMaTg.Text.Trim());
                txtMaNXB.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTenNXB.Text = nxb.LayTenNXB(txtMaNXB.Text.Trim());
                cboDoTuoi.Text = dgvBoTruyen.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            }
            catch
            {
                txtMaBT.Text = dgvBoTruyen.Rows[0].Cells[0].Value.ToString();
                txtTenBT.Text = dgvBoTruyen.Rows[0].Cells[1].Value.ToString();
                txtMaTg.Text = dgvBoTruyen.Rows[0].Cells[2].Value.ToString();
                txtTenTG.Text = tacgia.LayTenTg(txtMaTg.Text.Trim());
                txtMaNXB.Text = dgvBoTruyen.Rows[0].Cells[3].Value.ToString();
                txtTenNXB.Text = nxb.LayTenNXB(txtMaNXB.Text.Trim());
                cboDoTuoi.Text = dgvBoTruyen.Rows[0].Cells[4].Value.ToString().Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show("Bạn có muốn thêm bộ truyện này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTO_BoTruyen bt = new DTO_BoTruyen(txtMaBT.Text,txtTenBT.Text, txtMaTg.Text, txtMaNXB.Text, Convert.ToInt16(cboDoTuoi.Text.Trim()));
                    if (busBoTruyen.ThemBoTruyen(bt))
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

        private void frmBoTruyen_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show("Bạn có muốn sửa bộ truyện này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTO_BoTruyen bt = new DTO_BoTruyen(txtMaBT.Text, txtTenBT.Text, txtMaTg.Text, txtMaNXB.Text, Convert.ToInt16(cboDoTuoi.Text.Trim()));
                    if (busBoTruyen.SuaBoTruyen(bt))
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
                if (MessageBox.Show("Bạn có muốn xóa bộ truyện này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTO_BoTruyen bt = new DTO_BoTruyen(txtMaBT.Text, txtTenBT.Text, txtMaTg.Text, txtMaNXB.Text, Convert.ToInt16(cboDoTuoi.Text.Trim()));
                    if (busBoTruyen.XoaBoTruyen(txtMaBT.Text))
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            dgvBoTruyen.DataSource = busBoTruyen.TimKiemBoTruyen(txtTimKiem.Text.Trim());
        }
    }
}