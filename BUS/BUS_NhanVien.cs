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
    /// <summary>
    /// Mục đích: Chứa các phương thức xử lí liên quan đến nhân viên.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSNhanVien
    {
        DALNhanVien dalNhanVien = new DALNhanVien();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách nhân viên
        public DataTable LayNhanVien()
        {
            return dalNhanVien.LayNhanVien();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin nhân viên
        public bool ThemNhanVien(DTONhanVien nv)
        {
            return dalNhanVien.ThemNhanVien(nv);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin nhân viên
        public bool SuaNhanVien(DTONhanVien nv)
        {
            return dalNhanVien.SuaNhanVien(nv);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin nhân viên
        public bool XoaNhanVine(string ma)
        {
            return dalNhanVien.XoaNhanVien(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm nhân viên có tên tương ứng với tên cần tìm
        public DataTable TimKiemNhanVien(string ten)
        {
            return dalNhanVien.TimKiemNhanVien(ten);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy gmail của nhân viên thông qua mã nhân viên
        public DataTable LayGmailNhanVien(string ma)
        {
            return dalNhanVien.LayGmailNhanVien(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy mã nhân viên thông qua tài khoản và mật khẩu
        public string LayMaNV(string tk, string mk)
        {
            return dalNhanVien.LayMaNV(tk, mk);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy tên nhân viên thông qua tài khoản và mật khẩu
        public string LayTenNV(string tk, string mk)
        {
            return dalNhanVien.LayTenNV(tk, mk);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra đăng nhập
        public string KiemTraDangNhap(string tk, string mk)
        {
            return dalNhanVien.KiemTraDangNhap(tk, mk);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tự động tạo mã nhân viên

        public DataTable TaoMa()
        {
            return dalNhanVien.TaoMa("MaNV", "NhanVien", 3, "NV0");
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy thông tin nhân viên thông qua mã nhân viên
        public DataTable LayNhanVien(string ma)
        {
            return dalNhanVien.LayNhanVien(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Đăng kí tài khoản cho nhân viên
        public bool DangKy(string ma, string tk, string mk)
        {
            return dalNhanVien.DangKy(ma, tk, mk);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy thông tin nhân viên thông qua mã nhân viên
        public DataTable LayThongTinNhanVien(string ma)
        {
            return dalNhanVien.LayThongTinNhanVien(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin nhân viên (chỉ có khi nhân viên đăng nhập và sử dụng tài khoản của bản thân)
        public bool SuaThongTinNhanVien(DTONhanVien nv)
        {
            return dalNhanVien.SuaThongTinNhanVien(nv);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Kiểm tra nhân viên đã có tài khoản hay không
        public DataTable KiemTraNVDaCoTaiKhoan(string ma)
        {
            return dalNhanVien.KiemTraNVDaCoTK(ma);
        }
    }
}
