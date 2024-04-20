using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_NXB
    {
        DAL_NXB dalNXB = new DAL_NXB();
        public DataTable LayNXB()
        {
            return dalNXB.LayNXB();
        }
        public bool ThemNXB(DTO_NXB nxb)
        {
            return dalNXB.ThemNXB(nxb);
        }
        public bool SuaNXB(DTO_NXB nxb)
        {
            return dalNXB.SuaNXB(nxb);
        }
        public bool XoaNXB(string ten)
        {
            return dalNXB.XoaNCB(ten);
        }
        public DataTable TimKiemNXB(string ten)
        {
            return dalNXB.TimKiemNXB(ten);
        }
        public DataTable TaoMa()
        {
            return dalNXB.TaoMa();
        }
        public string LayTenNXB(string ma)
        {
            return dalNXB.LayTenNXB(ma);
        }
        public DataTable LayNXB(string ma)
        {
            return dalNXB.LayNXB(ma);
        }
    }
}
