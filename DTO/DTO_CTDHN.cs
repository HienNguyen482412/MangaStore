using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTOCTDHN
    {
        private string MaDHN;
        private string MaTT;
        private int SoLuong;
        private int GiaTien;

        public DTOCTDHN()
        {
            
        }
        public DTOCTDHN(string maDHN,string maTT, int soLuong, int giaTien)
        {
            this.MaDHN = maDHN;
            this.MaTT = maTT;
            this.SoLuong = soLuong;
            this.GiaTien = giaTien;
        }

        public string MaDHN1 { get => MaDHN; set => MaDHN = value; }
        public string MaTT1 { get => MaTT; set => MaTT = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int GiaTien1 { get => GiaTien; set => GiaTien = value; }
    }
}
