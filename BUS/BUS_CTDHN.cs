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
    /// Mục đích: Chứa các phương thức xử lí liên quan đến chi tiết đơn hàng nhập.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSCTDHN
    {
        DALCTDHN dalCTDHN = new DALCTDHN();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách chi tiết đơn hàng nhập của một đơn hàng nhập qua mã đơn hàng
        public DataTable LayCTDHN(string madh)
        {
            return dalCTDHN.LayCTDHN(madh);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin một chi tiết đơn hàng nhập
        public bool ThemCTDHN(DTOCTDHN ct)
        {
            return dalCTDHN.ThemCTDHN(ct);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin chi tiết đơn hàng nhập
        public bool SuaCTDHN(DTOCTDHN ct)
        {
            return dalCTDHN.SuaCTDHN(ct);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin chi tiết một đơn hàng nhập
        public bool XoaCTDHN(string maDHN, string ma)
        {
            return dalCTDHN.XoaCTDHN(maDHN, ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm một chi tiết đơn hàng nhập trong một đơn hàng nhập thông qua tên của truyện tranh trong đơn đó
        public DataTable TimKiemCTDHN(string maDHN,string ten)
        {
            return dalCTDHN.TimKiemCTDHN(maDHN ,ten);
        }
        public bool XoaTatCaCTDHN(string madhn)
        {
            return dalCTDHN.XoaTatCaCT(madhn);
        }
    }
}
