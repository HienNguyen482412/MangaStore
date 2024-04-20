using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDonHangBan : Form
    {
        public frmDonHangBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetInfo(string ngaynhap, string mahd, string manxb, string tennxb, string manv, string tennv, string tongtien, string sl, DataGridView dgvTemp)
        {
            lbNgayBan.Text = ngaynhap.Trim();
            lbMaHD.Text = mahd.Trim();
            lbMaKH.Text = manxb.Trim();
            lbTenKH.Text = tennxb.Trim();
            lbMaNV.Text = manv.Trim();
            lbTenNV.Text = tennv.Trim();
            lbTongSL.Text = sl.Trim();
            lbTongTien.Text = tongtien.Trim();
            dgvTruyenTranh.DataSource = dgvTemp.DataSource;
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            dgvTruyenTranh.MaximumSize = new Size(dgvTruyenTranh.Width, 0);
            dgvTruyenTranh.AutoSize = true;
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        Bitmap memoryImage;
        void CaptureScreen()
        {
            Graphics grap = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, grap);
            Graphics memoryGrap = Graphics.FromImage(memoryImage);
            memoryGrap.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void dgvTruyenTranh_Resize(object sender, EventArgs e)
        {
            grbTongTien.Location = new Point(grbTongTien.Location.X, grbTongTien.Location.Y + dgvTruyenTranh.Height +5);
            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y+ dgvTruyenTranh.Height/2+grbTongTien.Height+10);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
