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
    public class BUS_DHB
    {
        DALDHB dalDHB = new DALDHB();
        public DataTable LayDHB()
        {
            return dalDHB.LayDHB();
        }
        public bool ThemDHB(DTODHB dhb)
        {
            return dalDHB.ThemDHB(dhb);
        }
        public bool SuaDHB(DTODHB dhb)
        {
            return dalDHB.SuaDHB(dhb);
        }
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
        /// <returns></returns>
        public DataTable TimKiemDHB(int s, int day, int month, int year)
        {
            return dalDHB.TimKiemDHB(s, day, month, year);
        }
        public DataTable TaoMa()
        {
            return dalDHB.TaoMa();
        }
    }
}
