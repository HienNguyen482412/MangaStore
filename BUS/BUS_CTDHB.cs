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
    public class BUSCTDHB
    {
        DALCTDHB dalCTDHB = new DALCTDHB();
        public DataTable LayCTDHB(string madh)
        {
            return dalCTDHB.LayCTDHB(madh);
        }
        public bool ThemCTDHB(DTOCTDHB ct)
        {
            return dalCTDHB.ThemCTDHB(ct);
        }
        public bool SuaCTDHB(DTOCTDHB ct)
        {
            return dalCTDHB.SuaCTDHB(ct);
        }
        public bool XoaCTDHB(string maDHB, string ma)
        {
            return dalCTDHB.XoaCTDHB(maDHB, ma);
        }
        public DataTable TimKiemCTDHB(string ma, string ten)
        {
            return dalCTDHB.TimKiemCTDHB(ma, ten);
        }
    }
}
