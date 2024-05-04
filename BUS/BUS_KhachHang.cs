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
    /// Mục đích: Chứa các phương thức xử lí liên quan đến khách hàng.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSKhachHang
    {
        DALKhachHang dalKhachHang = new DALKhachHang();
        /// Created by Nguyễn Minh Hiền – 05/04/2024:Hiển thị danh sách khách hàng
        public DataTable LayKhachHang()
        {
            return dalKhachHang.LayKhachHang();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin khách hàng
        public bool ThemKhachHang(DTOKhachHang kh)
        {
            return dalKhachHang.ThemKhachHang(kh);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin khách hàng
        public bool SuaKhachHang(DTOKhachHang kh)
        {
            return dalKhachHang.SuaKhachHang(kh);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin khách hàng
        public bool XoaKhachHang(string ma)
        {
            return dalKhachHang.XoaKhachHang(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm khách hàng có tên tương ứng với tên cần tìm
        public DataTable TimKiemKhachHang(string ten)
        {
            return dalKhachHang.TimKiemKhachHang(ten);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tự động tạo mã khách hàng
        public DataTable TaoMa()
        {
            return dalKhachHang.TaoMa();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy tên khách hàng thông qua mã khách hàng
        public DataTable LayKhachHang(string maKH)
        {
            return dalKhachHang.LayKhachHang(maKH);
        }
    }
}
