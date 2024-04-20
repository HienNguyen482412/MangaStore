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
    public class BUS_BoTruyen
    {
        DAL_BoTruyen dalBoTruyen = new DAL_BoTruyen();
        public DataTable LayBoTruyen()
        {
            return dalBoTruyen.LayBoTruyen();
        }
        public bool ThemBoTruyen(DTO_BoTruyen bt)
        {
            return dalBoTruyen.ThemBoTruyen(bt);
        }
        public bool SuaBoTruyen(DTO_BoTruyen bt)
        {
            return dalBoTruyen.SuaBoTruyen(bt) ;
        }
        public bool XoaBoTruyen(string ma)
        {
            return dalBoTruyen.XoaBoTruyen(ma);
        }
        public DataTable TimKiemBoTruyen(string ten)
        {
            return dalBoTruyen.TimKiemBoTruyen(ten);
        }
        public DataTable TaoMa()
        {
            return dalBoTruyen.TaoMa();
        }
        public string LayTenBoTruyen(string ma)
        {
            return dalBoTruyen.LayTenBoTruyen(ma);
        }
    }
}
