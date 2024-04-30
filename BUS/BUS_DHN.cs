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
    public class BUSDHN
    {
        DALDHN dalDHN = new DALDHN();
        public DataTable LayDHN()
        {
            return dalDHN.LayDHN();
        }
        public bool ThemDHN(DTODHN dhn)
        {
            return dalDHN.ThemDHN(dhn);
        }
        public bool SuaDHN(DTODHN dhn)
        {
            return dalDHN.SuaDHN(dhn);
        }
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
        /// <returns></returns>
        public DataTable TimKiemDHN(int s, int day, int month, int year)
        {
            return dalDHN.TimKiemDHN(s, day, month, year);
        }
        public DataTable TaoMa()
        {
            return dalDHN.TaoMa();
        }
    }
}
