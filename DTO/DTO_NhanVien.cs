using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của nhân viên gồm: mã nhân viên, họ tên, giới tính, ngày sinh, địa chỉ, số điện thoại, email, ngày bắt đầu, lương, tài khoản, mật khẩu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DTONhanVien
    {
        private string MaNV;
        private string HoTen;
        private string GioiTinh;
        private string NgaySinh;
        private string DiaChi;
        private string SDT;
        private string Email;
        private string NgayBD;
        private int Luong;
        private string TaiKhoan;
        private string MatKhau;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string NgayBD1 { get => NgayBD; set => NgayBD = value; }
        public int Luong1 { get => Luong; set => Luong = value; }
        public string TaiKhoan1 { get => TaiKhoan; set => TaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        /// <summary>
        /// Constructor mặc định của DTONhanVien
        /// </summary>
        public DTONhanVien()
        {
            
        }
        /// <summary>
        /// Constructor có tham số của DTONhanVien
        /// </summary>
        /// <param name="maNV">mã nhân viên</param>
        /// <param name="hoTen">họ tên</param>
        /// <param name="gioiTinh">giới tính</param>
        /// <param name="ngaySinh">ngày sinh</param>
        /// <param name="diaChi">địa chỉ</param>
        /// <param name="sdt">số điện thoại</param>
        /// <param name="email">email</param>
        /// <param name="ngayBD">ngày bắt đầu</param>
        /// <param name="luong">lương</param>
        /// <param name="taiKhoan">tài khoản</param>
        /// <param name="matKhau">mật khẩu</param>
        public DTONhanVien(string maNV, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string sdt, string email, string ngayBD, int luong, string taiKhoan, string matKhau)
        {
            this.MaNV = maNV;
            this.HoTen =hoTen;
            this.GioiTinh= gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.SDT = sdt;
            this.Email = email;
            this.NgayBD = ngayBD;
            this.Luong = luong;
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
        }
        /// <summary>
        /// Constructor có tham số của DTONhanVien
        /// </summary>
        /// <param name="maNV">mã nhân viên</param>
        /// <param name="hoTen">họ tên</param>
        /// <param name="gioiTinh">giới tính</param>
        /// <param name="ngaySinh">ngày sinh</param>
        /// <param name="diaChi">địa chỉ</param>
        /// <param name="sdt">số điện thoại</param>
        /// <param name="email">email</param>
        /// <param name="ngayBD">ngày bắt đầu</param>
        /// <param name="luong">lương</param>
        public DTONhanVien(string maNV, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string sdt, string email, string ngayBD, int luong)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.SDT = sdt;
            this.Email = email;
            this.NgayBD = ngayBD;
            this.Luong = luong;
        }

    }
}
