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
    /// Mục đích: Chứa các phương thức xử lí liên quan đến đơn hàng nhập.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSDHN
    {
        DALDHN dalDHN = new DALDHN();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách các đơn hàng nhập
        public DataTable LayDHN()
        {
            return dalDHN.LayDHN();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm đơn hàng nhập
        public bool ThemDHN(DTODHN dhn)
        {
            return dalDHN.ThemDHN(dhn);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin đơn hàng nhập
        public bool SuaDHN(DTODHN dhn)
        {
            return dalDHN.SuaDHN(dhn);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin đơn hàng nhập
        public bool XoaDHN(string ma)
        {
            return dalDHN.XoaDHN(ma);
        }
        /// <summary>
        /// Hàm tìm kiếm đơn hàng theo ngày tháng và năm.s = 0, 1,2 và 3. Nếu s = 0 tìm theo ngày, s = 1 tìm theo tháng, s = 2 tìm theo năm và s = 3 thì tìm theo cả ngày tháng và năm
        /// </summary>
        /// <param name="s">Lựa chọn</param>
        /// <param name="day">Ngày </param>
        /// <param name="month">Tháng</param>
        /// <param name="year">Năm</param>
        /// <returns>Danh sách đơn hàng nhập thỏa mã điều kiện đã chọn</returns>
        public DataTable TimKiemDHN(int s, int day, int month, int year)
        {
            return dalDHN.TimKiemDHN(s, day, month, year);
        }
        ///Created by Nguyễn Minh Hiền – 05/04/2024: Tự động tạo mã cho đơn hàng nhập
        public DataTable TaoMa()
        {
            return dalDHN.TaoMa();
        }
    }
}
