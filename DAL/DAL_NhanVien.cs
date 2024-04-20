using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayNhanVien()
        {
            return ex.ReturnTable("select MaNV as [ Mã nhân viên], HoTen as [Họ tên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email], NgayBD as [Ngày bắt đầu], Luong as [Lương] from NHANVIEN");
        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            return ex.ReturnBool($"insert into NhanVien values ('{nv.NHANVIEN_MANV}',N'{nv.NHANVIEN_HOTEN}',N'{nv.NHANVIEN_GIOITINH}','{nv.NHANVIEN_NGAYSINH}',N'{nv.NHANVIEN_DIACHI}','{nv.NHANVIEN_SDT}','{nv.NHANVIEN_EMAIL}','{nv.NHANVIEN_NGAYBD}',{nv.NHANVIEN_LUONG},null,null)");
        }
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            return ex.ReturnBool($"update NhanVien set HoTen = N'{nv.NHANVIEN_HOTEN}', GioiTinh = N'{nv.NHANVIEN_GIOITINH}', NgaySinh = '{nv.NHANVIEN_NGAYSINH}', DiaChi = N'{nv.NHANVIEN_DIACHI}', SDT = '{nv.NHANVIEN_SDT}', Email = '{nv.NHANVIEN_EMAIL}', NgayBD='{nv.NHANVIEN_NGAYBD}',luong={nv.NHANVIEN_LUONG} where MaNV='{nv.NHANVIEN_MANV}'");
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
        public bool DangKy(string tendn, string mk,string ma)
        {
            return ex.ReturnBool($"update NhanVien set TaiKhoan = '{tendn}', MatKhau = '{mk}' where MaNV = '{ma}'");
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
        public bool SuaThongTinNhanVien(DTO_NhanVien nv)
        {
            return ex.ReturnBool($"update NhanVien set HoTen = N'{nv.NHANVIEN_HOTEN}', GioiTinh = N'{nv.NHANVIEN_GIOITINH}', NgaySinh = '{nv.NHANVIEN_NGAYSINH}', DiaChi = N'{nv.NHANVIEN_DIACHI}', SDT = '{nv.NHANVIEN_SDT}', Email = '{nv.NHANVIEN_EMAIL}', NgayBD='{nv.NHANVIEN_NGAYBD}',luong={nv.NHANVIEN_LUONG}, taikhoan = '{nv.NHANVIEN_TAIKHOAN}', matkhau = '{nv.NHANVIEN_MATKHAU}' where MaNV='{nv.NHANVIEN_MANV}'");
        }
        public DataTable TaoMa(string tencot, string tenbang, int sokitu, string kitu)
        {
           return ex.AutoCreateID(tencot, tenbang,sokitu, kitu);
        }
    }
}
