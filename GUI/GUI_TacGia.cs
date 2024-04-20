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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        BUS_TacGia busTacGia = new BUS_TacGia();
        public void LayThongTinTacGia(out string matg, out string tentg)
        {
            matg = txtMaTG.Text;
            tentg = txtTenTG.Text;
        }
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
        private void frmGUI_TacGia_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

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
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show("Bạn có muốn thêm tác giả này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTO_TacGia tg = new DTO_TacGia(txtMaTG.Text, txtTenTG.Text);
                    if (busTacGia.ThemTacGia(tg))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (MessageBox.Show("Bạn có muốn sửa tác giả này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTO_TacGia tg = new DTO_TacGia(txtMaTG.Text, txtTenTG.Text);
                    if (busTacGia.SuaTacGia(tg))
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
                if (MessageBox.Show("Bạn có muốn xóa tác giả này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (busTacGia.XoaTacGia(txtMaTG.Text))
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
            dgvTG.DataSource = busTacGia.TimKiemTacGia(txtTenTG.Text);
        }
    }
}
