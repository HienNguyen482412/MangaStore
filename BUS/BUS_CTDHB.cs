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
    /// Mục đích: Chứa các phương thức xử lí liên quan đến chi tiết đơn hàng bán.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSCTDHB
    {
        DALCTDHB dalCTDHB = new DALCTDHB();
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Hiển thị danh sách chi tiết đơn hàng bán của một đơn hàng bán qua mã đơn hàng
        public DataTable LayCTDHB(string madh)
        {
            return dalCTDHB.LayCTDHB(madh);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thêm thông tin một chi tiết đơn hàng bán
        public bool ThemCTDHB(DTOCTDHB ct)
        {
            return dalCTDHB.ThemCTDHB(ct);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Sửa thông tin chi tiết đơn hàng bán
        public bool SuaCTDHB(DTOCTDHB ct)
        {
            return dalCTDHB.SuaCTDHB(ct);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Xóa thông tin chi tiết một đơn hàng bán
        public bool XoaCTDHB(string maDHB, string ma)
        {
            return dalCTDHB.XoaCTDHB(maDHB, ma);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Tìm kiếm một chi tiết đơn hàng bán trong một đơn hàng bán thông qua tên của truyện tranh trong đơn đó
        public DataTable TimKiemCTDHB(string ma, string ten)
        {
            return dalCTDHB.TimKiemCTDHB(ma, ten);
        }
    }
}
