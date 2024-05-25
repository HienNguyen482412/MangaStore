using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDHN_List : Form
    {
        public frmDHN_List()
        {
            InitializeComponent();
        }
        BUSDHN busDHN = new BUSDHN();
        void ShowDGV()
        {
            dgvDHN.DataSource = busDHN.TimKiemDHN(0, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            if (dgvDHN.Rows.Count == 0)
            {
                pictureBox1.BringToFront();
            }
            else
            {
                pictureBox1.SendToBack();
            }
        }
        private void frmDHN_List_Load(object sender, EventArgs e)
        {
            ShowDGV();

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmDHN dhn = new frmDHN();
            dhn.KTHD = true;
            if (dhn.ShowDialog() == DialogResult.Cancel)
            {
                ShowDGV();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
            int day = Convert.ToInt16(dtpNgayBan.Value.ToString("dd"));
            int month = Convert.ToInt16(dtpNgayBan.Value.ToString("MM"));
            int year = Convert.ToInt32(dtpNgayBan.Value.ToString("yyyy"));
            if (rdoTheoNgay.Checked)
            {
                dgvDHN.DataSource = busDHN.TimKiemDHN(0, day, month, year);
            }
            else if (rdoTheoThang.Checked)
            {
                dgvDHN.DataSource = busDHN.TimKiemDHN(1, day, month, year);
            }
            else if (rdoTheoNam.Checked)
            {
                dgvDHN.DataSource = busDHN.TimKiemDHN(2, day, month, year);
            }
            else
            {
                dgvDHN.DataSource = busDHN.TimKiemDHN(3, day, month, year);
            }
        }

        private void dgvDHN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDHN dhn = new frmDHN();
            dhn.KTHD = false;
            if (frmDangNhap.quyenQL == true)
            {
                try
                {
                    dhn.GetInfo(dgvDHN.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvDHN.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvDHN.Rows[e.RowIndex].Cells[2].Value.ToString(), dgvDHN.Rows[e.RowIndex].Cells[3].Value.ToString());

                }
                catch
                {
                    dhn.GetInfo(dgvDHN.Rows[0].Cells[0].Value.ToString(), dgvDHN.Rows[0].Cells[1].Value.ToString(), dgvDHN.Rows[0].Cells[2].Value.ToString(), dgvDHN.Rows[0].Cells[3].Value.ToString());

                }
                if (dhn.ShowDialog() == DialogResult.Cancel)
                {
                    dgvDHN.DataSource = busDHN.LayDHN();

                }


            }
            else
            {
                if (dgvDHN.Rows[e.RowIndex].Cells[1].Value.ToString() != frmDangNhap.maNV)
                {
                    MessageBox.Show(Properties.Resources.NotPermittedMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        dhn.GetInfo(dgvDHN.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvDHN.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvDHN.Rows[e.RowIndex].Cells[2].Value.ToString(), dgvDHN.Rows[e.RowIndex].Cells[3].Value.ToString());

                    }
                    catch
                    {
                        dhn.GetInfo(dgvDHN.Rows[0].Cells[0].Value.ToString(), dgvDHN.Rows[0].Cells[1].Value.ToString(), dgvDHN.Rows[0].Cells[2].Value.ToString(), dgvDHN.Rows[0].Cells[3].Value.ToString());

                    }
                    if (dhn.ShowDialog() == DialogResult.Cancel)
                    {
                        dgvDHN.DataSource = busDHN.LayDHN();

                    }
                }
            }
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            dgvDHN.DataSource = busDHN.LayDHN();
            pictureBox1.SendToBack();
        }
    }
}
