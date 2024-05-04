using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    /// <summary>
    /// Mục đích: Chứa các phương thức xử lí liên quan đến truyện tranh.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSTruyenTranh
    {
        DALTruyenTranh dalTruyenTranh = new DALTruyenTranh();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách truyện tranh
        public DataTable LayTruyenTranh()
        {
            return dalTruyenTranh.LayTruyenTranh();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin truyện tranh
        public bool ThemTruyenTranh(DTOTruyenTranh tt)
        {
            return dalTruyenTranh.ThemTruyenTranh(tt);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin truyện tranh
        public bool SuaTruyenTranh(DTOTruyenTranh tt)
        {
            return dalTruyenTranh.SuaTruyenTranh(tt);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin truyện tranh
        public bool XoaTruyenTranh(string ma)
        {
            return dalTruyenTranh.XoaTruyenTranh(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm thông tin truyện tranh có tên tương ứng với tên cần tìm
        public DataTable TimKiemTruyenTranh(string ten)
        {
            return dalTruyenTranh.TimKiemTruyenTranh(ten);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tự động tạo mã truyện tranh
        public DataTable TaoMa()
        {
            return dalTruyenTranh.TaoMa();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy số lượng truyện tranh hiện tại thông qua mã truyện tranh
        public string LaySoLuongTruyen(string ma)
        {
            return dalTruyenTranh.LaySoLuongTruyen(ma);
        }
    }
}
