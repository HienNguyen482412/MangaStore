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
    public class BUSCTDHN
    {
        DALCTDHN dalCTDHN = new DALCTDHN();
        public DataTable LayCTDHN(string madh)
        {
            return dalCTDHN.LayCTDHN(madh);
        }
        public bool ThemCTDHN(DTOCTDHN ct)
        {
            return dalCTDHN.ThemCTDHN(ct);
        }
        public bool SuaCTDHN(DTOCTDHN ct)
        {
            return dalCTDHN.SuaCTDHN(ct);
        }
        public bool XoaCTDHN(string maDHN, string ma)
        {
            return dalCTDHN.XoaCTDHN(maDHN, ma);
        }
        public DataTable TimKiemCTDHN(string maDHN,string ten)
        {
            return dalCTDHN.TimKiemCTDHN(maDHN ,ten);
        }
    }
}
