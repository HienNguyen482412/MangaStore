using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    /// <summary>
    /// Mục đích: Chứa các phương thức thông kê dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class BUSThongKe
    {
        DALThongKe dalTK = new DALThongKe();
        //Theo ngày
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số truyện bán theo ngày
        public DataTable ThongKeTheoNgayBan(string thang,string nam)
        {
            return dalTK.ThongKeTheoNgayBan(thang,nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số truyện nhập theo ngày
        public DataTable ThongKeTheoNgayNhap(string thang, string nam)
        {
            return dalTK.ThongKeTheoNgayNhap(thang, nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số tiền nhập theo ngày
        public DataTable TongTienNhapTheoNgay(string ngay, string thang, string nam)
        {
            return dalTK.TongTienNhapTheoNgay(ngay, thang, nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số tiền bán theo ngày
        public DataTable TongTienBanTheoNgay(string ngay, string thang, string nam)
        {
            return dalTK.TongTienBanTheoNgay(ngay, thang, nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số truyện bán chạy theo ngày
        public DataTable TruyenBanChayTheoNgay(string ngay, string thang, string nam)
        {
            return dalTK.TruyenBanChayTheoNgay(ngay , thang, nam);
        }

        //Theo tháng
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số truyện bán theo tháng
        public DataTable ThongKeTheoThangBan(string nam)
        {
            return dalTK.ThongKeTheoThangBan(nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số truyện nhập theo tháng
        public DataTable ThongKeTheoThangNhap(string nam)
        {
            return dalTK.ThongKeTheoThangNhap(nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê tổng số tiền nhập theo tháng
        public DataTable TongTienNhapTheoThang(string thang,string nam)
        {
            return dalTK.TongTienNhapTheoThang(thang,nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê tổng số tiền bán theo tháng
        public DataTable TongTienBanTheoThang(string thang,string nam)
        {
            return dalTK.TongTienBanTheoThang(thang, nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê truyện tranh bán chạy theo tháng
        public DataTable TruyenBanChayTheoThang(string thang, string nam)
        {
            return dalTK.TruyenBanChayTheoThang(thang, nam);
        }


        //Năm
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số truyện bán theo năm
        public DataTable ThongKeTheoNamBan()
        {
            return dalTK.ThongKeTheoNamBan();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê số truyện nhập theo năm
        public DataTable ThongKeTheoNamNhap()
        {
            return dalTK.ThongKeTheoNamNhap();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê tổng tiền nhập theo năm
        public DataTable TongTienNhapTheoNam(string nam)
        {
            return dalTK.TongTienNhapTheoNam(nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê tổng tiền bán theo năm
        public DataTable TongTienBanTheoNam(string nam)
        {
            return dalTK.TongTienBanTheoNam(nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê truyện bán chạy theo năm
        public DataTable TruyenBanChayTheoNam(string nam)
        {
            return dalTK.TruyenBanChayTheoNam(nam);
        }
        //Chung 
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê truyện bán ế
        public DataTable TruyenBanE()
        {
            return dalTK.TruyenBanE();
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê tổng số đơn hàng nhập và số lượng nhập
        public DataTable TongSoDonHangVaSLNhap(int option, int ngay, int thang, int nam)
        {
            return dalTK.TongSoDonHangVaSLNhap(option, ngay, thang, nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Thống kê tổng số đơn hàng bán và số lượng bán
        public DataTable TongSoDonHangVaSLBan(int option, int ngay, int thang, int nam)
        {
            return dalTK.TongSoDonHangVaSLBan(option, ngay, thang, nam);
        }
        //Thống kê doanh thu
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy danh sách tiền bán truyện
        public DataTable DanhSachTienBan(int option, string thang = "1", string nam = "2024")
        {
            return dalTK.DanhSachTienBan(option, thang, nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy danh sách tiền nhập truyện
        public DataTable DanhSachTienNhap(int option, string thang = "1", string nam = "2024")
        {
            return dalTK.DanhSachTienNhap(option, thang, nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy tổng tiền bán
        public DataTable TongTienBan(int option, string thang = "1", string nam = "2024")
        {
            return dalTK.TongTienBan(option , thang, nam);
        }
        /// Created by Nguyễn Minh Hiền – 05/04/2024: Lấy tổng tiền nhập
        public DataTable TongTienNhap(int option, string thang = "1", string nam = "2024")
        {
            return dalTK.TongTienNhap(option , thang, nam);
        }
    }
}
