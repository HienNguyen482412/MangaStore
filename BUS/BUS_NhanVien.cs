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
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayNhanVien()
        {
            return dalNhanVien.LayNhanVien();
        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.ThemNhanVien(nv);
        }
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.SuaNhanVien(nv);
        }
        public bool XoaNhanVine(string ma)
        {
            return dalNhanVien.XoaNhanVien(ma);
        }
        public DataTable TimKiemNhanVien(string ten)
        {
            return dalNhanVien.TimKiemNhanVien(ten);
        }
        public DataTable LayGmailNhanVien(string ma)
        {
            return dalNhanVien.LayGmailNhanVien(ma);
        }
        public string LayMaNV(string tk, string mk)
        {
            return dalNhanVien.LayMaNV(tk, mk);
        }
        public string LayTenNV(string tk, string mk)
        {
            return dalNhanVien.LayTenNV(tk, mk);
        }
        public string KiemTraDangNhap(string tk, string mk)
        {
            return dalNhanVien.KiemTraDangNhap(tk, mk);
        }
        public DataTable TaoMa()
        {
            return dalNhanVien.TaoMa("MaNV", "NhanVien", 3, "NV0");
        }
        public DataTable LayNhanVien(string ma)
        {
            return dalNhanVien.LayNhanVien(ma);
        }
        public bool DangKy(string ma, string tk, string mk)
        {
            return dalNhanVien.DangKy(ma, tk, mk);
        }
        public DataTable LayThongTinNhanVien(string manv)
        {
            return dalNhanVien.LayThongTinNhanVien(manv);
        }
        public bool SuaThongTinNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.SuaThongTinNhanVien(nv);
        }
    }
}
