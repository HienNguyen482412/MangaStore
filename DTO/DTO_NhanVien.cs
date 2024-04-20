using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string _NHANVIEN_MANV;
        private string _NHANVIEN_HOTEN;
        private string _NHANVIEN_GIOITINH;
        private string _NHANVIEN_NGAYSINH;
        private string _NHANVIEN_DIACHI;
        private string _NHANVIEN_SDT;
        private string _NHANVIEN_EMAIL;
        private string _NHANVIEN_NGAYBD;
        private int _NHANVIEN_LUONG;
        private string _NHANVIEN_TAIKHOAN;
        private string _NHANVIEN_MATKHAU;

        public string NHANVIEN_MANV { get => _NHANVIEN_MANV; set => _NHANVIEN_MANV = value; }
        public string NHANVIEN_HOTEN { get => _NHANVIEN_HOTEN; set => _NHANVIEN_HOTEN = value; }
        public string NHANVIEN_GIOITINH { get => _NHANVIEN_GIOITINH; set => _NHANVIEN_GIOITINH = value; }
        public string NHANVIEN_NGAYSINH { get => _NHANVIEN_NGAYSINH; set => _NHANVIEN_NGAYSINH = value; }
        public string NHANVIEN_DIACHI { get => _NHANVIEN_DIACHI; set => _NHANVIEN_DIACHI = value; }
        public string NHANVIEN_SDT { get => _NHANVIEN_SDT; set => _NHANVIEN_SDT = value; }
        public string NHANVIEN_EMAIL { get => _NHANVIEN_EMAIL; set => _NHANVIEN_EMAIL = value; }
        public string NHANVIEN_NGAYBD { get => _NHANVIEN_NGAYBD; set => _NHANVIEN_NGAYBD = value; }
        public int NHANVIEN_LUONG { get => _NHANVIEN_LUONG; set => _NHANVIEN_LUONG = value; }
        public string NHANVIEN_TAIKHOAN { get => _NHANVIEN_TAIKHOAN; set => _NHANVIEN_TAIKHOAN = value; }
        public string NHANVIEN_MATKHAU { get => _NHANVIEN_MATKHAU; set => _NHANVIEN_MATKHAU = value; }
        public DTO_NhanVien()
        {
            
        }
        public DTO_NhanVien(string manv, string tennv, string gioitinh, string ngaysinh, string diachi, string sdt, string email, string ngaybd, int luong, string tk, string mk)
        {
            this.NHANVIEN_MANV = manv;
            this.NHANVIEN_HOTEN = tennv;
            this.NHANVIEN_GIOITINH = gioitinh;
            this.NHANVIEN_NGAYSINH = ngaysinh;
            this.NHANVIEN_DIACHI = diachi;
            this.NHANVIEN_SDT = sdt;
            this.NHANVIEN_EMAIL = email;
            this.NHANVIEN_NGAYBD = ngaybd;
            this.NHANVIEN_LUONG = luong;
            this.NHANVIEN_TAIKHOAN = tk;
            this.NHANVIEN_MATKHAU = mk;
        }
        public DTO_NhanVien(string manv, string tennv, string gioitinh, string ngaysinh, string diachi, string sdt, string email, string ngaybd, int luong)
        {
            this.NHANVIEN_MANV = manv;
            this.NHANVIEN_HOTEN = tennv;
            this.NHANVIEN_GIOITINH = gioitinh;
            this.NHANVIEN_NGAYSINH = ngaysinh;
            this.NHANVIEN_DIACHI = diachi;
            this.NHANVIEN_SDT = sdt;
            this.NHANVIEN_EMAIL = email;
            this.NHANVIEN_NGAYBD = ngaybd;
            this.NHANVIEN_LUONG = luong;

        }

    }
}
