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
    public class BUS_TacGia
    {
        DAL_TacGia dalTacGia = new DAL_TacGia();
        public DataTable LayTacGia()
        {
            return dalTacGia.LayTacGia();
        }
        public bool ThemTacGia(DTO_TacGia tg)
        {
            return dalTacGia.ThemTacGia(tg);
        }
        public bool SuaTacGia(DTO_TacGia tg)
        {
            return dalTacGia.SuaTacGia(tg);
        }
        public bool XoaTacGia(string ma)
        {
            return dalTacGia.XoaTacGia(ma);
        }
        public DataTable TimKiemTacGia(string ten)
        {
            return dalTacGia.TimKiemTacGia(ten);
        }
        public DataTable TaoMa()
        {
            return dalTacGia.TaoMa();
        }
        public string LayTenTg(string ma)
        {
            return dalTacGia.LayTenTacGia(ma);
        }
    }
}
