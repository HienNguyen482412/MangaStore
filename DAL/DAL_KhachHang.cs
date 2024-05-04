using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Mục đích: thực hiện các thao tác liên quan đến dữ liệu của khách hàng trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALKhachHang
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức lấy danh sách khách hàng
        /// </summary>
        /// <returns>Danh sách thông tin các khách hàng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayKhachHang()
        {
            return ex.ReturnTable($"select MaKH as [Mã khách hàng], TenKH as [Tên khách hàng], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT] from KhachHang");
        }
        /// <summary>
        /// Phương thức lấy thông tin khách hàng có mã khách hàng tương ứng
        /// </summary>
        /// <param name="makh">Mã khách hàng</param>
        /// <returns>Thông tin khách hàng có mã tương ứng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayKhachHang(string makh)
        {
            return ex.ReturnTable($"select TenKH as [Tên khách hàng], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT] from KhachHang where makh = '{makh}'");

        }
        /// <summary>
        /// Phương thức thêm thông tin một khách hàng
        /// </summary>
        /// <param name="kh">Thông tin một khách hàng</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại thì trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemKhachHang(DTOKhachHang kh)
        {
            return ex.ReturnBool($"insert into KhachHang values ('{kh.MaKH1}',N'{kh.TenKH1}',N'{kh.GioiTinh1}','{kh.NgaySinh1}',N'{kh.DiaChi1}','{kh.SDT1}')");
        }
        /// <summary>
        /// Phương thức sửa thông tin một khách hàng
        /// </summary>
        /// <param name="kh">Thông tin của một khách hàng</param>
        /// <returns>Trả về true nếu sửa thành công, người lại thì trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaKhachHang(DTOKhachHang kh)
        {
            return ex.ReturnBool($"update KhachHang set TenKH = N'{kh.TenKH1}', GioiTinh = N'{kh.GioiTinh1}', NgaySinh = '{kh.NgaySinh1}', DiaChi = N'{kh.DiaChi1}', SDT = '{kh.SDT1}' where MaKH = '{kh.MaKH1}'");
        }
        /// <summary>
        /// Phương thức xóa thông tin của một khách hàng
        /// </summary>
        /// <param name="ma">Mã khách hàng</param>
        /// <returns>Trả về true nếu xóa thành công, ngược lại thì trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaKhachHang(string ma)
        {
            return ex.ReturnBool($"delete from KhachHang where MaKH = '{ma}'");
        }
        /// <summary>
        /// Phương thức tìm kiếm khách hàng có tên cần tìm
        /// </summary>
        /// <param name="ten">Tên khách hàng</param>
        /// <returns>Danh sách khách hàng có tên tương ứng với tên cần tìm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TimKiemKhachHang(string ten)
        {
            return ex.ReturnTable($"select MaKH as [Mã khách hàng], TenKH as [Tên khách hàng], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT] from KhachHang where TenKH like N'%{ten}%'");
        }
        /// <summary>
        /// Phương thức tự động tạo mã khách hàng
        /// </summary>
        /// <returns>Mã khách hàng mới cho lần nhập kế tiếp</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaKH", "KhachHang", 3, "KH0");
        }
    }
}
