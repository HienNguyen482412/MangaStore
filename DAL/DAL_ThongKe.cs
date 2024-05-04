using System.Data;

namespace DAL
{
    /// <summary>
    /// Mục đích: thực hiện các thông kê dữ liệu trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALThongKe
    {
        ExcuteQuerry ex = new ExcuteQuerry();

        //Theo Ngày
        /// <summary>
        /// Phương thức thông kê số lượng truyện bán theo ngày
        /// </summary>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách số lượng truyện bán trong ngày</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable ThongKeTheoNgayBan(string thang, string nam)
        {
            return ex.ReturnTable($"select ngayban,sum(soluong) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb group by ngayban having year(ngayban)={nam} and month(ngayban) = {thang}");
        }
        /// <summary>
        /// Phương thức thông kê số lượng truyện nhập theo ngày
        /// </summary>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách số lượng truyện nhập trong ngày</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable ThongKeTheoNgayNhap(string thang, string nam)
        {
            return ex.ReturnTable($"select ngaynhap,sum(soluong) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn group by ngaynhap having year(ngaynhap)={nam} and month(ngaynhap) = {thang}");
        }
        /// <summary>
        /// Phương thức thông kê tổng tiên nhập theo ngày
        /// </summary>
        /// <param name="ngay">Ngày</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Tổng tiền nhập theo ngày</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongTienNhapTheoNgay(string ngay, string thang, string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where day(ngaynhap)={ngay} and month(ngaynhap) = {thang} and year(NgayNhap) = {nam}");
        }
        /// <summary>
        /// Phương thức lấy tổng tiền bán theo ngày
        /// </summary>
        /// <param name="ngay">Ngày</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Tông tiền bán theo ngày</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongTienBanTheoNgay(string ngay, string thang, string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where day(ngayban)={ngay} and month(ngayban) = {thang} and year(NgayBan) = {nam}");
        }
        /// <summary>
        /// Phương thức lấy danh sách truyện bán chạy theo ngày
        /// </summary>
        /// <param name="ngay">Ngày</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách truyện bán chạy theo ngày</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TruyenBanChayTheoNgay(string ngay, string thang, string nam)
        {
            return ex.ReturnTable($"select top 1 with ties ct.Matt as [Mã truyện tranh] , TenTruyen as [Tên truyện] , sum(ct.SoLuong) as [Số lượng đã bán] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT inner join HDB hdb on ct.MaHDB = hdb.MaHDB where day(ngayban)={ngay} and month(ngayban) = {thang} and year(ngayban) = {nam} group by ct.MaTT, TenTruyen order by [Số lượng đã bán] desc");
        }



        //Theo tháng
        /// <summary>
        /// Phương thức lấy số lượng truyện bán theo tháng
        /// </summary>
        /// <param name="nam">Năm</param>
        /// <returns>Số lượng truyện bán theo tháng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable ThongKeTheoThangBan(string nam)
        {
            return ex.ReturnTable($"select month(ngayban),sum(soluong) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where year(ngayban)={nam} group by month(ngayban)");
        }
        /// <summary>
        /// Phương htuwcs lấy số lượng truyện nhập theo tháng
        /// </summary>
        /// <param name="nam">Năm</param>
        /// <returns>Số lượng truyện nhập theo tháng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable ThongKeTheoThangNhap(string nam)
        {
            return ex.ReturnTable($"select month(ngaynhap),sum(soluong) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where year(ngaynhap)={nam} group by month(ngaynhap)");
        }
        /// <summary>
        /// Phương thức lấy tổng tiền nhập theo tháng
        /// </summary>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Tổng tiền nhập theo tháng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongTienNhapTheoThang(string thang, string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where month(ngaynhap) = {thang} and year(NgayNhap) = {nam}");
        }
        /// <summary>
        /// Phương thức lấy tổng tiền bán theo tháng
        /// </summary>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Tổng tiền bán theo tháng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongTienBanTheoThang(string thang, string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where month(ngayban) = {thang} and year(NgayBan) = {nam}");
        }
        /// <summary>
        /// Phương thức lấy danh sách truyện bán chạy theo tháng
        /// </summary>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách truyện bán chạy theo tháng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TruyenBanChayTheoThang(string thang, string nam)
        {
            return ex.ReturnTable($"select top 1 with ties ct.Matt as [Mã truyện tranh] , TenTruyen as [Tên truyện] , sum(ct.SoLuong) as [Số lượng đã bán] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT inner join HDB hdb on ct.MaHDB = hdb.MaHDB where month(ngayban) = {thang} and year(ngayban) = {nam} group by ct.MaTT, TenTruyen order by [Số lượng đã bán] desc");
        }

        //Theo năm
        /// <summary>
        /// Phương thức lấy số lượng truyện bán theo năm
        /// </summary>
        /// <returns>Số lượng truyện bán theo năm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable ThongKeTheoNamBan()
        {
            return ex.ReturnTable($"select year(ngayban),sum(soluong) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb group by year(ngayban)");
        }
        /// <summary>
        /// Phương thức lấy số lượng truyện nhập theo năm
        /// </summary>
        /// <returns>Số lượng truyện nhập theo năm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable ThongKeTheoNamNhap()
        {
            return ex.ReturnTable($"select year(ngaynhap),sum(soluong) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn group by year(ngaynhap)");
        }
        /// <summary>
        /// Phương thức lấy tổng tiên nhập theo năm
        /// </summary>
        /// <param name="nam">Năm</param>
        /// <returns>Tổng tiền nhập theo năm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongTienNhapTheoNam(string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where  year(NgayNhap) = {nam}");
        }
        /// <summary>
        /// Phương thức lấy tổng tiên bán theo năm
        /// </summary>
        /// <param name="nam">Năm</param>
        /// <returns>Tổng tiền nhập theo năm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongTienBanTheoNam(string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where year(NgayBan) = {nam}");
        }
        /// <summary>
        /// Phương thức lấy danh sách truyện bán chạy theo năm
        /// </summary>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách truyện bán chạy theo năm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TruyenBanChayTheoNam(string nam)
        {
            return ex.ReturnTable($"select top 1 with ties ct.Matt as [Mã truyện tranh] , TenTruyen as [Tên truyện] , sum(ct.SoLuong) as [Số lượng đã bán] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT inner join HDB hdb on ct.MaHDB = hdb.MaHDB where  year(ngayban) = {nam} group by ct.MaTT, TenTruyen order by [Số lượng đã bán] desc");
        }



        //Chung
        /// <summary>
        /// Phương thức lấy tổng số đơn hàng nhập và số lượng nhập
        /// </summary>
        /// <param name="option">0-Theo ngày, 1-Theo tháng, còn lại là theo năm</param>
        /// <param name="ngay">Ngày</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Số lượng đơn hàng nhập và số lượng truyện nhập</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongSoDonHangVaSLNhap(int option, int ngay, int thang, int nam)
        {
            if (option == 0)
            {
                return ex.ReturnTable($"select isnull(count(hdn.mahdn),0), isnull(sum(ct.SoLuong),0) from hdn hdn inner join cthdn ct on hdn.mahdn = ct.mahdn where day(ngaynhap) = {ngay} and month(ngaynhap) = {thang} and year(ngaynhap) = {nam}");
            }
            else if (option == 1)
            {
                return ex.ReturnTable($"select isnull(count(hdn.mahdn),0), isnull(sum(ct.SoLuong),0) from hdn hdn inner join cthdn ct on hdn.mahdn = ct.mahdn where month(ngaynhap) = {thang} and year(ngaynhap) = {nam}");
            }
            else
            {
                return ex.ReturnTable($"with cte_SLDHN as (select year(NgayNhap) as NamNhap,count(MaHDN) as SoDH from hdn where year(NgayNhap) = {nam} group by year(NgayNhap) ),cte_SLTN as (select year(NgayNhap) as namnhap, isnull(sum(ct.SoLuong),0) as slt from hdn hdn inner join cthdn ct on hdn.mahdn = ct.mahdn where year(NgayNhap) = {nam} group by year(NgayNhap)) select cte_SLDHN.SoDH, ISNULL(sum(cte_SLTN.slt),0) from cte_SLDHN inner join cte_SLTN on cte_SLDHN.NamNhap = cte_SLTN.namnhap group by cte_SLDHN.SoDH");
            }
        }
        /// <summary>
        /// Phương thức lấy tổng số đơn hàng bán và số lượng bán
        /// </summary>
        /// <param name="option">0-Theo ngày, 1-Theo tháng, còn lại là theo năm</param>
        /// <param name="ngay">Ngày</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Số lượng đơn hàng bán và số lượng truyện bán</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongSoDonHangVaSLBan(int option, int ngay, int thang, int nam)
        {
            if (option == 0)
            {
                return ex.ReturnTable($"select isnull(count(hdb.mahdb),0), isnull(sum(ct.SoLuong),0) from hdb hdb inner join cthdb ct on hdb.mahdb = ct.mahdb where day(ngayban) = {ngay} and month(ngayban) = {thang} and year(ngayban) = {nam}");
            }
            else if (option == 1)
            {
                return ex.ReturnTable($"select isnull(count(hdb.mahdb),0), isnull(sum(ct.SoLuong),0) from hdb hdb inner join cthdb ct on hdb.mahdb = ct.mahdb where month(ngayban) = {thang} and year(ngayban) = {nam}");
            }
            else
            {
                return ex.ReturnTable($"with cte_SLDHN as (select year(NgayBan) as NamNhap,count(MaHDB) as SoDH from hdb where year(NgayBan) = {nam} group by year(NgayBan) ),cte_SLTN as (select year(Ngayban) as namnhap, isnull(sum(ct.SoLuong),0) as slt from hdb hdb inner join cthdb ct on hdb.mahdb = ct.mahdb where year(NgayBan) = {nam} group by year(NgayBan)) select cte_SLDHN.SoDH, ISNULL(sum(cte_SLTN.slt),0) from cte_SLDHN inner join cte_SLTN on cte_SLDHN.NamNhap = cte_SLTN.namnhap group by cte_SLDHN.SoDH");
            }
        }
        /// <summary>
        /// Phương thức lấy danh sách truyện bán ê
        /// </summary>
        /// <returns>Danh sách truyện bán ế</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TruyenBanE()
        {
            return ex.ReturnTable($"select top 1 with ties tt.Matt as [Mã truyện tranh] , TenTruyen as [Tên truyện] , isnull(sum(ct.SoLuong),0) as [Số lượng đã bán] from truyentranh tt full join cthdb ct on ct.MaTT = tt.MaTT full join HDB hdb on ct.MaHDB = hdb.MaHDB  group by tt.MaTT, TenTruyen order by [Số lượng đã bán] asc");
        }
        //Thống kê doanh thu
        /// <summary>
        /// Phương thức lấy danh sách tiền bán
        /// </summary>
        /// <param name="option">0-Theo ngày, 1-Theo tháng, 2-Theo năm, còn lại - tổng tiền bán</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách tiền bán</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable DanhSachTienBan(int option, string thang = "1", string nam = "2024")
        {
            if (option == 0)
            {
                return ex.ReturnTable($"select NgayBan,isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where month(NgayBan) = {thang} and year(ngayban)={nam} group by NgayBan");
            }
            else if (option == 1)
            {
                return ex.ReturnTable($"select month(NgayBan),isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where year(NgayBan) = {nam} group by month(NgayBan)");
            }
            else if (option == 2)
            {
                return ex.ReturnTable($"select year(NgayBan),isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb  group by YEAR(NgayBan)");
            }
            else
            {
                return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb");
            }
        }
        /// <summary>
        /// Phương thức lấy danh sách tiền nhập
        /// </summary>
        /// <param name="option">0-Theo ngày, 1-Theo tháng, 2-Theo năm, còn lại - tổng tiền nhập</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách tiền nhập</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable DanhSachTienNhap(int option, string thang = "1", string nam = "2024")
        {
            if (option == 0)
            {
                return ex.ReturnTable($"select NgayNhap,isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where month(NgayNhap) = {thang} and year(ngayNhap)={nam} group by NgayNhap");
            }
            else if (option == 1)
            {
                return ex.ReturnTable($"select month(NgayNhap),isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where year(Ngaynhap) = {nam} group by month(NgayNhap)");
            }
            else if (option == 2)
            {
                return ex.ReturnTable($"select year(NgayNhap),isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn  group by YEAR(NgayNhap)");
            }
            else
            {
                return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn");
            }
        }
        /// <summary>
        /// Phương thức lấy danh sách tổng tiền bán (không chọn bao gồm ngày trong nội dung bảng)
        /// </summary>
        /// <param name="option">0-Theo ngày, khác-theo tháng</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách tổng tiền bán (không chọn bao gồm ngày trong nội dung bảng)</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongTienBan(int option, string thang = "1", string nam = "2024")
        {
            if (option == 0)
            {
                return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where MONTH(NgayBan) = {thang} and year(NgayBan)={nam}");
            }
            else
            {
                return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where year(NgayBan)={nam}");
            }
        }
        /// <summary>
        /// Phương thức lấy danh sách tổng tiền nhập (không chọn bao gồm ngày trong nội dung bảng)
        /// </summary>
        /// <param name="option">0-Theo ngày, khác-theo tháng</param>
        /// <param name="thang">Tháng</param>
        /// <param name="nam">Năm</param>
        /// <returns>Danh sách tổng tiền nhập (không chọn bao gồm ngày trong nội dung bảng)</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TongTienNhap(int option, string thang = "1", string nam = "2024")
        {
            if (option == 0)
            {
                return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where MONTH(NgayNhap) = {thang} and year(NgayNhap)={nam}");
            }
            else
            {
                return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where year(NgayNhap)={nam}");
            }
        }

    }
}
