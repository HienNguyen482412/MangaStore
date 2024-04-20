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
    public class BUS_CTDHN
    {
        DAL_CTDHN dalCTDHN = new DAL_CTDHN();
        public DataTable LayCTDHN(string madh)
        {
            return dalCTDHN.LayCTDHN(madh);
        }
        public bool ThemCTDHN(DTO_CTDHN ct)
        {
            return dalCTDHN.ThemCTDHN(ct);
        }
        public bool SuaCTDHN(DTO_CTDHN ct)
        {
            return dalCTDHN.SuaCTDHN(ct);
        }
        public bool XoaCTDHN(string madhn, string ma)
        {
            return dalCTDHN.XoaCTDHN(madhn, ma);
        }
        public DataTable TimKiemCTDHN(string madhn,string ten)
        {
            return dalCTDHN.TimKiemCTDHN(madhn, ten);
        }
    }
}
