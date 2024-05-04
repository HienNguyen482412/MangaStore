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
    /// Mục đích: Chứa các phương thức xử lí liên quan đến đơn hàng bán.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUS_DHB
    {
        DALDHB dalDHB = new DALDHB();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách các đơn hàng bán
        public DataTable LayDHB()
        {
            return dalDHB.LayDHB();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm đơn hàng bán
        public bool ThemDHB(DTODHB dhb)
        {
            return dalDHB.ThemDHB(dhb);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin đơn hàng bán
        public bool SuaDHB(DTODHB dhb)
        {
            return dalDHB.SuaDHB(dhb);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin đơn hàng bán
        public bool XoaDHB(string ma)
        {
            return dalDHB.XoaDHB(ma);
        }
        /// <summary>
        /// Hàm tìm kiếm đơn hàng theo ngày tháng và năm.s = 0, 1,2 và 3. Nếu s = 0 tìm theo ngày, s = 1 tìm theo tháng, s = 2 tìm theo năm và s = 3 thì tìm theo cả ngày tháng và năm
        /// </summary>
        /// <param name="s">Lựa chọn</param>
        /// <param name="day">Ngày </param>
        /// <param name="month">Tháng</param>
        /// <param name="year">Năm</param>
        /// <returns>Danh sách đơn hàng bán thỏa mã điều kiện đã chọn</returns>
        public DataTable TimKiemDHB(int s, int day, int month, int year)
        {
            return dalDHB.TimKiemDHB(s, day, month, year);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tự động tạo mã cho đơn hàng bán
        public DataTable TaoMa()
        {
            return dalDHB.TaoMa();
        }
    }
}
