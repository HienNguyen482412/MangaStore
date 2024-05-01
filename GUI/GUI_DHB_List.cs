using BUS;
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
    public partial class frmDHB_List : Form
    {
        public frmDHB_List()
        {
            InitializeComponent();
        }
        BUS_DHB busDHB = new BUS_DHB();
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmDHB dhb = new frmDHB();
            this.Hide();
            if (dhb.ShowDialog()== DialogResult.Cancel)
            {
                this.Show();
            }
            dgvDHB.DataSource = busDHB.LayDHB();
        }

        private void frmDHB_List_Load(object sender, EventArgs e)
        {
            dgvDHB.DataSource = busDHB.LayDHB();
        }

        private void dgvDHB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDHB dhb = new frmDHB();
            dhb.KTHD = false;
            if (frmDangNhap.quyenQL == true)
            {
                try
                {
                    dhb.GetInfo(dgvDHB.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvDHB.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvDHB.Rows[e.RowIndex].Cells[2].Value.ToString(), dgvDHB.Rows[e.RowIndex].Cells[3].Value.ToString());

                }
                catch
                {
                    dhb.GetInfo(dgvDHB.Rows[0].Cells[0].Value.ToString(), dgvDHB.Rows[0].Cells[1].Value.ToString(), dgvDHB.Rows[0].Cells[2].Value.ToString(), dgvDHB.Rows[0].Cells[3].Value.ToString());

                }
                if (dhb.ShowDialog() == DialogResult.Cancel)
                {
                    dgvDHB.DataSource = busDHB.LayDHB();

                }
            }
            else
            {
                if (dgvDHB.Rows[e.RowIndex].Cells[1].Value.ToString() != frmDangNhap.maNV)
                {
                    MessageBox.Show(Properties.Resources.NotPermittedMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    try
                    {
                        dhb.GetInfo(dgvDHB.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvDHB.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvDHB.Rows[e.RowIndex].Cells[2].Value.ToString(), dgvDHB.Rows[e.RowIndex].Cells[3].Value.ToString());

                    }
                    catch
                    {
                        dhb.GetInfo(dgvDHB.Rows[0].Cells[0].Value.ToString(), dgvDHB.Rows[0].Cells[1].Value.ToString(), dgvDHB.Rows[0].Cells[2].Value.ToString(), dgvDHB.Rows[0].Cells[3].Value.ToString());

                    }
                    if (dhb.ShowDialog() == DialogResult.Cancel)
                    {
                        dgvDHB.DataSource = busDHB.LayDHB();

                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt16(dtpNgayBan.Value.ToString("dd"));
            int month = Convert.ToInt16(dtpNgayBan.Value.ToString("MM"));
            int year = Convert.ToInt32(dtpNgayBan.Value.ToString("yyyy"));
            if (rdoTheoNgay.Checked)
            {
                dgvDHB.DataSource = busDHB.TimKiemDHB(0, day, month, year);
            }
            else if (rdoTheoThang.Checked)
            {
                dgvDHB.DataSource = busDHB.TimKiemDHB(1, day, month, year);
            }
            else if (rdoTheoNam.Checked)
            {
                dgvDHB.DataSource = busDHB.TimKiemDHB(2, day, month, year);
            }
            else
            {
                dgvDHB.DataSource = busDHB.TimKiemDHB(3, day, month, year);
            }
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            dgvDHB.DataSource = busDHB.LayDHB();
        }
    }
}
