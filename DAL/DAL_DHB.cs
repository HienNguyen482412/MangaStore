using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDHB
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayDHB()
        {
            return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB");
        }
        public bool ThemDHB(DTODHB dhb)
        {
            return ex.ReturnBool($"insert into HDB values ('{dhb.MaDHB1}','{dhb.MaNV1}','{dhb.MaKH1}','{dhb.NgayBan1}')");
        }
        public bool SuaDHB(DTODHB dhb)
        {
            return ex.ReturnBool($"update HDB set MaNV = '{dhb.MaNV1}', MaKH = '{dhb.MaKH1}', NgayBan = '{dhb.NgayBan1}' where mahdb = '{dhb.MaDHB1}'");
        }
        public bool XoaDHB(string ma)
        {
            return ex.ReturnBool($"delete from HDB where MaHDB = '{ma}'");
        }
        /// <summary>
        /// Hàm tìm kiếm đơn hàng theo ngày tháng và năm.s = 0, 1,2 và 3. Nếu s = 0 tìm theo ngày, s = 1 tìm theo tháng, s = 2 tìm theo năm và s = 3 thì tìm theo cả ngày tháng và năm
        /// </summary>
        /// <param name="s">Lựa chọn</param>
        /// <param name="day">Ngày </param>
        /// <param name="month">Tháng</param>
        /// <param name="year">Năm</param>
        /// <returns></returns>
        public DataTable TimKiemDHB(int s, int day, int month, int year)
        {
            if (s == 0)
            {
                return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB where day(ngayban) = {day}");

            }
            else if (s == 1)
            {
                return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB where Month(ngayban) = {month}");

            }
            else if (s == 2)
            {
                return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB where year(ngayban) = {year}");

            }
            else
            {
                return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB where day(ngayban) = {day} and Month(ngayban) = {month} and year(ngayban) = {year} ");

            }
        }
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaHDB", "HDB", 4, "DHB0");
        }
      
    }
}
