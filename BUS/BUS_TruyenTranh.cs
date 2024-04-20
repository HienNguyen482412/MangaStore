using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class BUS_TruyenTranh
    {
        DAL_TruyenTranh dalTruyenTranh = new DAL_TruyenTranh();
        public DataTable LayTruyenTranh()
        {
            return dalTruyenTranh.LayTruyenTranh();
        }
        public bool ThemTruyenTranh(DTO_TruyenTranh tt)
        {
            return dalTruyenTranh.ThemTruyenTranh(tt);
        }
        public bool SuaTruyenTranh(DTO_TruyenTranh tt)
        {
            return dalTruyenTranh.SuaTruyenTranh(tt);
        }
        public bool XoaTruyenTranh(string ma)
        {
            return dalTruyenTranh.XoaTruyenTranh(ma);
        }
        public DataTable TimKiemTruyenTranh(string ten)
        {
            return dalTruyenTranh.TimKiemTruyenTranh(ten);
        }
        public DataTable TaoMa()
        {
            return dalTruyenTranh.TaoMa();
        }
        public string LaySoLuongTruyen(string ma)
        {
            return dalTruyenTranh.LaySoLuongTruyen(ma);
        }
    }
}
