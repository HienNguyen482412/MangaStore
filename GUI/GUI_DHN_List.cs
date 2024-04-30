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
    public partial class frmDHN_List : Form
    {
        public frmDHN_List()
        {
            InitializeComponent();
        }
        BUSDHN busDHN = new BUSDHN();
        private void frmDHN_List_Load(object sender, EventArgs e)
        {
            dgvDHN.DataSource = busDHN.LayDHN();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmDHN dhn = new frmDHN();
            dhn.KTHD = true;
            if (dhn.ShowDialog() == DialogResult.Cancel)
            {
                dgvDHN.DataSource = busDHN.LayDHN();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt16(dtpNgayBan.Value.ToString("dd"));
            int month = Convert.ToInt16(dtpNgayBan.Value.ToString("MM"));
            int year= Convert.ToInt32(dtpNgayBan.Value.ToString("yyyy"));
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
                    MessageBox.Show("Bạn không có quyền xem đơn hàng này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
        }
    }
}
