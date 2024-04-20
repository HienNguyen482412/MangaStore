using System.Data;

namespace DAL
{
    public class DAL_ThongKe
    {
        ExcuteQuerry ex = new ExcuteQuerry();

        //Theo Ngày
        public DataTable ThongKeTheoNgayBan(string thang, string nam)
        {
            return ex.ReturnTable($"select ngayban,sum(soluong) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb group by ngayban having year(ngayban)={nam} and month(ngayban) = {thang}");
        }
        public DataTable ThongKeTheoNgayNhap(string thang, string nam)
        {
            return ex.ReturnTable($"select ngaynhap,sum(soluong) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn group by ngaynhap having year(ngaynhap)={nam} and month(ngaynhap) = {thang}");
        }
        public DataTable TongTienNhapTheoNgay(string ngay, string thang, string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where day(ngaynhap)={ngay} and month(ngaynhap) = {thang} and year(NgayNhap) = {nam}");
        }
        public DataTable TongTienBanTheoNgay(string ngay, string thang, string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where day(ngayban)={ngay} and month(ngayban) = {thang} and year(NgayBan) = {nam}");
        }
        public DataTable TruyenBanChayTheoNgay(string ngay, string thang, string nam)
        {
            return ex.ReturnTable($"select top 1 with ties ct.Matt as [Mã truyện tranh] , TenTruyen as [Tên truyện] , sum(ct.SoLuong) as [Số lượng đã bán] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT inner join HDB hdb on ct.MaHDB = hdb.MaHDB where day(ngayban)={ngay} and month(ngayban) = {thang} and year(ngayban) = {nam} group by ct.MaTT, TenTruyen order by [Số lượng đã bán] desc");
        }



        //Theo tháng
        public DataTable ThongKeTheoThangBan(string nam)
        {
            return ex.ReturnTable($"select month(ngayban),sum(soluong) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where year(ngayban)={nam} group by month(ngayban)");
        }
        public DataTable ThongKeTheoThangNhap(string nam)
        {
            return ex.ReturnTable($"select month(ngaynhap),sum(soluong) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where year(ngaynhap)={nam} group by month(ngaynhap)");
        }
        public DataTable TongTienNhapTheoThang(string thang, string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where month(ngaynhap) = {thang} and year(NgayNhap) = {nam}");
        }
        public DataTable TongTienBanTheoThang(string thang, string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where month(ngayban) = {thang} and year(NgayBan) = {nam}");
        }
        public DataTable TruyenBanChayTheoThang(string thang, string nam)
        {
            return ex.ReturnTable($"select top 1 with ties ct.Matt as [Mã truyện tranh] , TenTruyen as [Tên truyện] , sum(ct.SoLuong) as [Số lượng đã bán] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT inner join HDB hdb on ct.MaHDB = hdb.MaHDB where month(ngayban) = {thang} and year(ngayban) = {nam} group by ct.MaTT, TenTruyen order by [Số lượng đã bán] desc");
        }

        //Theo năm
        public DataTable ThongKeTheoNamBan()
        {
            return ex.ReturnTable($"select year(ngayban),sum(soluong) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb group by year(ngayban)");
        }
        public DataTable ThongKeTheoNamNhap()
        {
            return ex.ReturnTable($"select year(ngaynhap),sum(soluong) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn group by year(ngaynhap)");
        }
        public DataTable TongTienNhapTheoNam(string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdn inner join hdn on cthdn.mahdn = hdn.mahdn where  year(NgayNhap) = {nam}");
        }
        public DataTable TongTienBanTheoNam(string nam)
        {
            return ex.ReturnTable($"select isnull(sum(giatien*soluong),0) from cthdb inner join hdb on cthdb.mahdb = hdb.mahdb where year(NgayBan) = {nam}");
        }
        public DataTable TruyenBanChayTheoNam(string nam)
        {
            return ex.ReturnTable($"select top 1 with ties ct.Matt as [Mã truyện tranh] , TenTruyen as [Tên truyện] , sum(ct.SoLuong) as [Số lượng đã bán] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT inner join HDB hdb on ct.MaHDB = hdb.MaHDB where  year(ngayban) = {nam} group by ct.MaTT, TenTruyen order by [Số lượng đã bán] desc");
        }



        //Chung
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
        public DataTable TruyenBanE()
        {
            return ex.ReturnTable($"select top 1 with ties tt.Matt as [Mã truyện tranh] , TenTruyen as [Tên truyện] , isnull(sum(ct.SoLuong),0) as [Số lượng đã bán] from truyentranh tt full join cthdb ct on ct.MaTT = tt.MaTT full join HDB hdb on ct.MaHDB = hdb.MaHDB  group by tt.MaTT, TenTruyen order by [Số lượng đã bán] asc");
        }
        //Thống kê doanh thu
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
