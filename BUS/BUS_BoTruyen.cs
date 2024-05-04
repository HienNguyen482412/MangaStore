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
    /// Mục đích: Chứa các phương thức xử lí liên quan đến bộ truyện.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSBoTruyen
    {
        DALBoTruyen dalBoTruyen = new DALBoTruyen();
        
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách bộ truyện
        public DataTable LayBoTruyen()
        {
            return dalBoTruyen.LayBoTruyen();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin bộ truyện mới
        public bool ThemBoTruyen(DTOBoTruyen bt)
        {
            return dalBoTruyen.ThemBoTruyen(bt);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin bộ truyện
        public bool SuaBoTruyen(DTOBoTruyen bt)
        {
            return dalBoTruyen.SuaBoTruyen(bt) ;
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin bộ truyện
        public bool XoaBoTruyen(string ma)
        {
            return dalBoTruyen.XoaBoTruyen(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm bộ truyện thông qua tên
        public DataTable TimKiemBoTruyen(string ten)
        {
            return dalBoTruyen.TimKiemBoTruyen(ten);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tự động tạo mã bộ truyện
        public DataTable TaoMa()
        {
            return dalBoTruyen.TaoMa();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy tên bộ truyện thông qua mã bộ truyện
        public string LayTenBoTruyen(string ma)
        {
            return dalBoTruyen.LayTenBoTruyen(ma);
        }
    }
}
