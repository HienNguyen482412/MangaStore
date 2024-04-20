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
    public class BUS_CTDHB
    {
        DAL_CTDHB dalCTDHB = new DAL_CTDHB();
        public DataTable LayCTDHB(string madh)
        {
            return dalCTDHB.LayCTDHB(madh);
        }
        public bool ThemCTDHB(DTO_CTDHB ct)
        {
            return dalCTDHB.ThemCTDHB(ct);
        }
        public bool SuaCTDHB(DTO_CTDHB ct)
        {
            return dalCTDHB.SuaCTDHB(ct);
        }
        public bool XoaCTDHB(string madhb, string ma)
        {
            return dalCTDHB.XoaCTDHB(madhb, ma);
        }
        public DataTable TimKiemCTDHB(string ma, string ten)
        {
            return dalCTDHB.TimKiemCTDHB(ma, ten);
        }
    }
}
