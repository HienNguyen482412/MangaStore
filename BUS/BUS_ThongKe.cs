using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSThongKe
    {
        DALThongKe dalTK = new DALThongKe();
        //Theo ngày
        public DataTable ThongKeTheoNgayBan(string thang,string nam)
        {
            return dalTK.ThongKeTheoNgayBan(thang,nam);
        }
        public DataTable ThongKeTheoNgayNhap(string thang, string nam)
        {
            return dalTK.ThongKeTheoNgayNhap(thang, nam);
        }

        public DataTable TongTienNhapTheoNgay(string ngay, string thang, string nam)
        {
            return dalTK.TongTienNhapTheoNgay(ngay, thang, nam);
        }
        public DataTable TongTienBanTheoNgay(string ngay, string thang, string nam)
        {
            return dalTK.TongTienBanTheoNgay(ngay, thang, nam);
        }
        public DataTable TruyenBanChayTheoNgay(string ngay, string thang, string nam)
        {
            return dalTK.TruyenBanChayTheoNgay(ngay , thang, nam);
        }

        //Theo tháng
        public DataTable ThongKeTheoThangBan(string nam)
        {
            return dalTK.ThongKeTheoThangBan(nam);
        }
        public DataTable ThongKeTheoThangNhap(string nam)
        {
            return dalTK.ThongKeTheoThangNhap(nam);
        }
        public DataTable TongTienNhapTheoThang(string thang,string nam)
        {
            return dalTK.TongTienNhapTheoThang(thang,nam);
        }
        public DataTable TongTienBanTheoThang(string thang,string nam)
        {
            return dalTK.TongTienBanTheoThang(thang, nam);
        }
        public DataTable TruyenBanChayTheoThang(string thang, string nam)
        {
            return dalTK.TruyenBanChayTheoThang(thang, nam);
        }


        //Năm
        public DataTable ThongKeTheoNamBan()
        {
            return dalTK.ThongKeTheoNamBan();
        }
        public DataTable ThongKeTheoNamNhap()
        {
            return dalTK.ThongKeTheoNamNhap();
        }
        public DataTable TongTienNhapTheoNam(string nam)
        {
            return dalTK.TongTienNhapTheoNam(nam);
        }
        public DataTable TongTienBanTheoNam(string nam)
        {
            return dalTK.TongTienBanTheoNam(nam);
        }
        public DataTable TruyenBanChayTheoNam(string nam)
        {
            return dalTK.TruyenBanChayTheoNam(nam);
        }
        //Chung 
        public DataTable TruyenBanE()
        {
            return dalTK.TruyenBanE();
        }
        public DataTable TongSoDonHangVaSLNhap(int option, int ngay, int thang, int nam)
        {
            return dalTK.TongSoDonHangVaSLNhap(option, ngay, thang, nam);
        }
        public DataTable TongSoDonHangVaSLBan(int option, int ngay, int thang, int nam)
        {
            return dalTK.TongSoDonHangVaSLBan(option, ngay, thang, nam);
        }
        //Thống kê doanh thu
        public DataTable DanhSachTienBan(int option, string thang = "1", string nam = "2024")
        {
            return dalTK.DanhSachTienBan(option, thang, nam);
        }
        public DataTable DanhSachTienNhap(int option, string thang = "1", string nam = "2024")
        {
            return dalTK.DanhSachTienNhap(option, thang, nam);
        }
        public DataTable TongTienBan(int option, string thang = "1", string nam = "2024")
        {
            return dalTK.TongTienBan(option , thang, nam);
        }
        public DataTable TongTienNhap(int option, string thang = "1", string nam = "2024")
        {
            return dalTK.TongTienNhap(option , thang, nam);
        }
    }
}
