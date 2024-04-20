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
    public partial class frmTrangBatDau : Form
    {
        public frmTrangBatDau()
        {
            InitializeComponent();
        }

        private void frmGUI_TrangBatDau_Load(object sender, EventArgs e)
        {
               
        }

        private void frmGUI_TrangBatDau_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            this.Hide(); 
            if (dn.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            this.Hide();
            if (dn.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
