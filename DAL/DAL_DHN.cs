using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDHN
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayDHN()
        {
            return ex.ReturnTable($"select MaHDN as [Mã đơn hàng nhập], MaNV as [Mã nhân viên], MaNXB as [Mã nhà xuất bản], ngaynhap as [Ngày nhập] from HDN");
        }
        public bool ThemDHN(DTODHN dhn)
        {
            return ex.ReturnBool($"insert into HDN values ('{dhn.MaDHN1}','{dhn.MaNV1}','{dhn.MaNXB1}','{dhn.NgayNhap1}')");
        }
        public bool SuaDHN(DTODHN dhn)
        {
            return ex.ReturnBool($"update HDN set MaNV = '{dhn.MaNV1}', MaNXB = '{dhn.MaNXB1}', NgayNhap = '{dhn.NgayNhap1}' where mahdn = '{dhn.MaDHN1}'");
        }
        public bool XoaDHN(string ma)
        {
            return ex.ReturnBool($"delete from HDN where MaHDN = '{ma}'");
        }
        /// <summary>
        /// Hàm tìm kiếm đơn hàng theo ngày tháng và năm.s = 0, 1,2 và 3. Nếu s = 0 tìm theo ngày, s = 1 tìm theo tháng, s = 2 tìm theo năm và s = 3 thì tìm theo cả ngày tháng và năm
        /// </summary>
        /// <param name="s">Lựa chọn</param>
        /// <param name="day">Ngày </param>
        /// <param name="month">Tháng</param>
        /// <param name="year">Năm</param>
        /// <returns></returns>
        public DataTable TimKiemDHN(int s, int day, int month, int year)
        {
            if (s == 0)
            {
                return ex.ReturnTable($"select MaHDN as [Mã đơn hàng nhập], MaNV as [Mã nhân viên], MaNXB as [Mã nhà xuất bản], ngaynhap as [Ngày nhập] from HDN where day(ngaynhap) = {day}");

            }
            else if (s == 1)
            {
                return ex.ReturnTable($"select MaHDN as [Mã đơn hàng nhập], MaNV as [Mã nhân viên], MaNXB as [Mã nhà xuất bản], ngaynhap as [Ngày nhập] from HDN where Month(ngaynhap) = {month}");

            }
            else if (s == 2)
            {
                return ex.ReturnTable($"select MaHDN as [Mã đơn hàng nhập], MaNV as [Mã nhân viên], MaNXB as [Mã nhà xuất bản], ngaynhap as [Ngày nhập] from HDN where year(ngaynhap) = {year}");

            }
            else
            {
                return ex.ReturnTable($"select MaHDN as [Mã đơn hàng nhập], MaNV as [Mã nhân viên], MaNXB as [Mã nhà xuất bản], ngaynhap as [Ngày nhập] from HDN where day(ngaynhap) = {day} and Month(ngaynhap) = {month} and year(ngaynhap) = {year} ");

            }
        }
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaHDN", "HDN", 4, "HDN0");
        }
    }
}
