using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSKhachHang
    {
        DALKhachHang dalKhachHang = new DALKhachHang();
        public DataTable LayKhachHang()
        {
            return dalKhachHang.LayKhachHang();
        }
        public bool ThemKhachHang(DTOKhachHang kh)
        {
            return dalKhachHang.ThemKhachHang(kh);
        }
        public bool SuaKhachHang(DTOKhachHang kh)
        {
            return dalKhachHang.SuaKhachHang(kh);
        }
        public bool XoaKhachHang(string ma)
        {
            return dalKhachHang.XoaKhachHang(ma);
        }
        public DataTable TimKiemKhachHang(string ten)
        {
            return dalKhachHang.TimKiemKhachHang(ten);
        }
        public DataTable TaoMa()
        {
            return dalKhachHang.TaoMa();
        }
        public DataTable LayKhachHang(string maKH)
        {
            return dalKhachHang.LayKhachHang(maKH);
        }
    }
}
