using DAL;
using DTO;
using System.Data;

namespace BUS
{
    /// <summary>
    /// Mục đích: Chứa các phương thức xử lí liên quan đến nhà xuất bản.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSNXB 
    {
        DALNXB dalNXB = new DALNXB();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách nhà xuất bản
        public DataTable LayNXB()
        {
            return dalNXB.LayNXB();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin nhà xuất bản
        public bool ThemNXB(DTONXB nxb)
        {
            return dalNXB.ThemNXB(nxb);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin nhà xuất bản
        public bool SuaNXB(DTONXB nxb)
        {
            return dalNXB.SuaNXB(nxb);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin nhà xuất bản
        public bool XoaNXB(string ten)
        {
            return dalNXB.XoaNCB(ten);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm thông tin nhà xuất bản
        public DataTable TimKiemNXB(string ten)
        {
            return dalNXB.TimKiemNXB(ten);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tự động tạo mã nhà xuất bản
        public DataTable TaoMa()
        {
            return dalNXB.TaoMa();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy tên nhà xuất bản thông qua mã nhà xuất bản
        public string LayTenNXB(string ma)
        {
            return dalNXB.LayTenNXB(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy thông tin nhà xuất bản thông qua mã nhà xuất bản
        public DataTable LayNXB(string ma)
        {
            return dalNXB.LayNXB(ma);
        }
    }
}
