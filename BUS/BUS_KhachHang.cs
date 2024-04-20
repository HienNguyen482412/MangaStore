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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable LayKhachHang()
        {
            return dalKhachHang.LayKhachHang();
        }
        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.ThemKhachHang(kh);
        }
        public bool SuaKhachHang(DTO_KhachHang kh)
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
        public DataTable LayKhachHang(string makh)
        {
            return dalKhachHang.LayKhachHang(makh);
        }
    }
}
