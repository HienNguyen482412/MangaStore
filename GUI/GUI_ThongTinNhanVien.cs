﻿using BUS;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinNhanVien : Form
    {
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNV = new BUS_NhanVien();
        void CapNhatThongTin()
        {
            DataTable dt = busNV.LayThongTinNhanVien(frmDangNhap.manv);
            txtMaNV.Text = dt.Rows[0][0].ToString();
            txtTenNV.Text = dt.Rows[0][1].ToString();
            cboGioiTinh.Text = dt.Rows[0][2].ToString().Trim();
            dtpNgaySinh.Text = dt.Rows[0][3].ToString();
            txtDiaChi.Text = dt.Rows[0][4].ToString();
            txtSDT.Text = dt.Rows[0][5].ToString();
            txtEmail.Text = dt.Rows[0][6].ToString();
            dtpNgayBD.Text = dt.Rows[0][7].ToString();
            txtLuong.Text = dt.Rows[0][8].ToString();
            txtTenDN.Text = dt.Rows[0][9].ToString();
            txtMatKhau.Text = dt.Rows[0][10].ToString();
            txtMatKhau.UseSystemPasswordChar = true;
        }
        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            CapNhatThongTin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text, cboGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtpNgayBD.Value.ToString("yyyy/MM/dd"), Convert.ToInt32(txtLuong.Text),txtTenDN.Text, txtMatKhau.Text);
            if (MessageBox.Show("Bạn có muốn cập nhật thông tin không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (busNV.SuaThongTinNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CapNhatThongTin();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            CapNhatThongTin();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}