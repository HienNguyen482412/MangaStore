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
    /// Mục đích: Chứa các phương thức xử lí liên quan đến tác giả.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSTacGia
    {
        DALTacGia dalTacGia = new DALTacGia();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách tác giả
        public DataTable LayTacGia()
        {
            return dalTacGia.LayTacGia();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin tác giả
        public bool ThemTacGia(DTOTacGia tg)
        {
            return dalTacGia.ThemTacGia(tg);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin tác giả
        public bool SuaTacGia(DTOTacGia tg)
        {
            return dalTacGia.SuaTacGia(tg);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin tác giả
        public bool XoaTacGia(string ma)
        {
            return dalTacGia.XoaTacGia(ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm tác giả có tên tương ứng với tên cần tìm
        public DataTable TimKiemTacGia(string ten)
        {
            return dalTacGia.TimKiemTacGia(ten);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tự động tạo mã tác giả
        public DataTable TaoMa()
        {
            return dalTacGia.TaoMa();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy tên tác giả thông qua mã tác giả
        public string LayTenTg(string ma)
        {
            return dalTacGia.LayTenTacGia(ma);
        }
    }
}
