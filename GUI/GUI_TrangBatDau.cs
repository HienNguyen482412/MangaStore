using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTrangBatDau : Form
    {
        public frmTrangBatDau()
        {
            InitializeComponent();
        }
        void MoTrangChu()
        {
            frmDangNhap dn = new frmDangNhap();
            this.Hide();
            if (dn.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        private void frmGUI_TrangBatDau_Load(object sender, EventArgs e)
        {
            
        }

        private void frmGUI_TrangBatDau_Click(object sender, EventArgs e)
        {
            MoTrangChu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MoTrangChu();
        }



        private void frmTrangBatDau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("hello");
                MoTrangChu();
            }
        }
    }
}
