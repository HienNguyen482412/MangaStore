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
    public class BUSTacGia
    {
        DALTacGia dalTacGia = new DALTacGia();
        public DataTable LayTacGia()
        {
            return dalTacGia.LayTacGia();
        }
        public bool ThemTacGia(DTOTacGia tg)
        {
            return dalTacGia.ThemTacGia(tg);
        }
        public bool SuaTacGia(DTOTacGia tg)
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
