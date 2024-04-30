using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhanVien
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayNhanVien()
        {
            return ex.ReturnTable("select MaNV as [ Mã nhân viên], HoTen as [Họ tên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email], NgayBD as [Ngày bắt đầu], Luong as [Lương] from NHANVIEN");
        }
        public bool ThemNhanVien(DTONhanVien nv)
        {
            return ex.ReturnBool($"insert into NhanVien values ('{nv.MaNV1}',N'{nv.HoTen1}',N'{nv.GioiTinh1}','{nv.NgaySinh1}',N'{nv.DiaChi1}','{nv.SDT1}','{nv.Email1}','{nv.NgayBD1}',{nv.Luong1},'{nv.MaNV1}',null)");
        }
        public bool SuaNhanVien(DTONhanVien nv)
        {
            return ex.ReturnBool($"update NhanVien set HoTen = N'{nv.HoTen1}', GioiTinh = N'{nv.GioiTinh1}', NgaySinh = '{nv.NgaySinh1}', DiaChi = N'{nv.DiaChi1}', SDT = '{nv.SDT1}', Email = '{nv.Email1}', NgayBD='{nv.NgayBD1}',luong={nv.Luong1} where MaNV='{nv.MaNV1}'");
        }
        public bool XoaNhanVien(string ma)
        {
            return ex.ReturnBool($"delete from NhanVien where MaNV = '{ma}'");
        }
        public DataTable TimKiemNhanVien(string ten)
        {
            return ex.ReturnTable($"select MaNV as [ Mã nhân viên], HoTen as [Họ tên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email], NgayBD as [Ngày bắt đầu], Luong as [Lương] from NHANVIEN where HoTen like N'%{ten}%'");
        }
        public DataTable LayGmailNhanVien(string ma)
        {
            return ex.ReturnTable($"select Email from NhanVien where MaNV = '{ma}'");
        }
        public DataTable LayNhanVien(string ma)
        {
            return ex.ReturnTable($"select HoTen as [Họ tên] from NhanVien where MaNV = '{ma}'");

        }
        public bool DangKy(string tenDN, string matKhau,string ma)
        {
            return ex.ReturnBool($"update NhanVien set TaiKhoan = '{tenDN}', MatKhau = '{matKhau}' where MaNV = '{ma}'");
        }
        public string LayMaNV(string tk, string mk)
        {
            return ex.ReturnValue($"select manv from NhanVien where TaiKhoan = '{tk}' and MatKhau = '{mk}'");
        }
        public string LayTenNV(string tk, string mk)
        {
            return ex.ReturnValue($"select HoTen from NhanVien where TaiKhoan = '{tk}' and MatKhau = '{mk}'");
        }
        public string KiemTraDangNhap(string tk, string mk)
        {
            return ex.ReturnValue($"select count(*) from NhanVien where TaiKhoan = '{tk}' and MatKhau = '{mk}'");
        }
        public DataTable LayThongTinNhanVien(string manv)
        {
            return ex.ReturnTable($"select * from nhanvien where manv = '{manv}'");
        }
        public bool SuaThongTinNhanVien(DTONhanVien nv)
        {
            return ex.ReturnBool($"update NhanVien set HoTen = N'{nv.HoTen1}', GioiTinh = N'{nv.GioiTinh1}', NgaySinh = '{nv.NgaySinh1}', DiaChi = N'{nv.DiaChi1}', SDT = '{nv.SDT1}', Email = '{nv.Email1}', NgayBD='{nv.NgayBD1}',luong={nv.Luong1}, taikhoan = '{nv.TaiKhoan1}', matkhau = '{nv.MatKhau1}' where MaNV='{nv.MaNV1}'");
        }
        public DataTable KiemTraNVDaCoTK(string maNV)
        {
            return ex.ReturnTable($"select matkhau from nhanvien where manv = '{maNV}'");
        }
        public DataTable TaoMa(string tenCot, string tenBang, int soKiTu, string kiTu)
        {
           return ex.AutoCreateID(tenCot, tenBang,soKiTu, kiTu);
        }
    }
}
