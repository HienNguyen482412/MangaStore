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
    /// <summary>
    /// Mục đích: thực hiện các thao tác liên quan đến dữ liệu của nhân viên trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALNhanVien
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức lấy danh sách nhân viên
        /// </summary>
        /// <returns>Danh sách thông tin của nhân viên</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayNhanVien()
        {
            return ex.ReturnTable("select MaNV as [ Mã nhân viên], HoTen as [Họ tên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email], NgayBD as [Ngày bắt đầu], Luong as [Lương] from NHANVIEN");
        }
        /// <summary>
        /// Phương thức thêm thông tin của nhân viên
        /// </summary>
        /// <param name="nv">Thông tin của nhân viên</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemNhanVien(DTONhanVien nv)
        {
            return ex.ReturnBool($"insert into NhanVien values ('{nv.MaNV1}',N'{nv.HoTen1}',N'{nv.GioiTinh1}','{nv.NgaySinh1}',N'{nv.DiaChi1}','{nv.SDT1}','{nv.Email1}','{nv.NgayBD1}',{nv.Luong1},'{nv.MaNV1}',null)");
        }
        /// <summary>
        /// Phương thức sửa thông tin của một nhân viên
        /// </summary>
        /// <param name="nv">Thông tin của một nhân viên</param>
        /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaNhanVien(DTONhanVien nv)
        {
            return ex.ReturnBool($"update NhanVien set HoTen = N'{nv.HoTen1}', GioiTinh = N'{nv.GioiTinh1}', NgaySinh = '{nv.NgaySinh1}', DiaChi = N'{nv.DiaChi1}', SDT = '{nv.SDT1}', Email = '{nv.Email1}', NgayBD='{nv.NgayBD1}',luong={nv.Luong1} where MaNV='{nv.MaNV1}'");
        }
        /// <summary>
        /// Phương thức xóa thông tin nhân viên
        /// </summary>
        /// <param name="ma">Mã nhân viên</param>
        /// <returns> Trả về true nếu xóa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaNhanVien(string ma)
        {
            return ex.ReturnBool($"delete from NhanVien where MaNV = '{ma}'");
        }
        /// <summary>
        /// Phương thức lấy danh sách nhân viên có tên tương ứng
        /// </summary>
        /// <param name="ten">Tên nhân viên cần tìm</param>
        /// <returns>Danh sách nhân viên có tên tương ứng với tên cần tìm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TimKiemNhanVien(string ten)
        {
            return ex.ReturnTable($"select MaNV as [ Mã nhân viên], HoTen as [Họ tên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email], NgayBD as [Ngày bắt đầu], Luong as [Lương] from NHANVIEN where HoTen like N'%{ten}%'");
        }
        /// <summary>
        /// Phương thức lấy gmail của nhân viên thông qua mã nhân viên
        /// </summary>
        /// <param name="ma">Mã nhân viên</param>
        /// <returns>Gmail của nhân viên</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayGmailNhanVien(string ma)
        {
            return ex.ReturnTable($"select Email from NhanVien where MaNV = '{ma}'");
        }
        /// <summary>
        /// Phương thức lấy tên của nhân viên thông qua mã nhân viên
        /// </summary>
        /// <param name="ma">Mã nhân viên</param>
        /// <returns>Họ và tên nhân viên</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayNhanVien(string ma)
        {
            return ex.ReturnTable($"select HoTen as [Họ tên] from NhanVien where MaNV = '{ma}'");

        }
        /// <summary>
        /// Phương thức đăng ký tài khoản cho nhân viên
        /// </summary>
        /// <param name="tenDN">Tên đăng nhập</param>
        /// <param name="matKhau">Mật khẩu</param>
        /// <param name="ma">Mã nhân viên</param>
        /// <returns>Trả về true nếu đăng kí thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool DangKy(string tenDN, string matKhau,string ma)
        {
            return ex.ReturnBool($"update NhanVien set TaiKhoan = '{tenDN}', MatKhau = '{matKhau}' where MaNV = '{ma}'");
        }
        /// <summary>
        /// Phương thức lấy mã nhân viên thông qua tên đăng nhập và mật khảu
        /// </summary>
        /// <param name="tk">Tài khoản</param>
        /// <param name="mk">Mật khảu</param>
        /// <returns>Mã nhân viên</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public string LayMaNV(string tk, string mk)
        {
            return ex.ReturnValue($"select manv from NhanVien where TaiKhoan = '{tk}' and MatKhau = '{mk}'");
        }
        /// <summary>
        /// Phương thức lấy tên nhân viên thông qua tên đăng nhập và mật khẩu
        /// </summary>
        /// <param name="tk">Tên đăng nhập</param>
        /// <param name="mk">Mật khẩu</param>
        /// <returns>Tên nhân viên</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public string LayTenNV(string tk, string mk)
        {
            return ex.ReturnValue($"select HoTen from NhanVien where TaiKhoan = '{tk}' and MatKhau = '{mk}'");
        }
        /// <summary>
        /// Phương thức kiểm tra đăng nhập của nhân viên
        /// </summary>
        /// <param name="tk">Tài khoản</param>
        /// <param name="mk">Mật khẩuparam>
        /// <returns>Nếu tài khoản và mật khẩu chính xác sẽ trả về 1, ngược lại trả về ""</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public string KiemTraDangNhap(string tk, string mk)
        {
            return ex.ReturnValue($"select count(*) from NhanVien where TaiKhoan = '{tk}' and MatKhau = '{mk}'");
        }
        /// <summary>
        /// Phương thức lấy thông tin nhân viên thông qua mã nhân viên
        /// </summary>
        /// <param name="manv">Mã nhân viên</param>
        /// <returns>Thông tin của nhân viên có mã tương ứng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayThongTinNhanVien(string manv)
        {
            return ex.ReturnTable($"select * from nhanvien where manv = '{manv}'");
        }
        /// <summary>
        /// Phương thức sửa thông tin của nhân viên (chỉ dùng khi nhân viên đăng nhập bằng tài khoản của bản thân)
        /// </summary>
        /// <param name="nv">Mã nhân viên</param>
        /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaThongTinNhanVien(DTONhanVien nv)
        {
            return ex.ReturnBool($"update NhanVien set HoTen = N'{nv.HoTen1}', GioiTinh = N'{nv.GioiTinh1}', NgaySinh = '{nv.NgaySinh1}', DiaChi = N'{nv.DiaChi1}', SDT = '{nv.SDT1}', Email = '{nv.Email1}', NgayBD='{nv.NgayBD1}',luong={nv.Luong1}, taikhoan = '{nv.TaiKhoan1}', matkhau = '{nv.MatKhau1}' where MaNV='{nv.MaNV1}'");
        }
        /// <summary>
        /// Phương thức kiểm tra nhân viên đã có tài khoản hay không
        /// </summary>
        /// <param name="maNV">Mã nhân viên</param>
        /// <returns>Nếu nhân viên đã có tài khoản thì trả về mật khẩu của tài khoản đó, ngược lại trả về ""</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable KiemTraNVDaCoTK(string maNV)
        {
            return ex.ReturnTable($"select matkhau from nhanvien where manv = '{maNV}'");
        }
        /// <summary>
        /// Phương thức tự động tào mã cho nhân viên
        /// </summary>
        /// <param name="tenCot">Tên cột</param>
        /// <param name="tenBang">Tên bảng</param>
        /// <param name="soKiTu">Số kí tự</param>
        /// <param name="kiTu">Kí tự</param>
        /// <returns>Mã nhân viên mới cho lần nhập tiếp theo</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TaoMa(string tenCot, string tenBang, int soKiTu, string kiTu)
        {
           return ex.AutoCreateID(tenCot, tenBang,soKiTu, kiTu);
        }
    }
}
