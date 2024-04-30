using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCTDHB
    {
        private string MaDHB;
        private string MaTT;
        private int SoLuong;
        private int GiaTien;

     

        public DTOCTDHB()
        {
            
        }
        public DTOCTDHB(string maDHB, string maTT, int soLuong, int giaTien)
        {
            this.MaDHB = maDHB;
            this.MaTT = maTT;
            this.SoLuong = soLuong;
            this.GiaTien = giaTien;
        }

        public string MaDHB1 { get => MaDHB; set => MaDHB = value; }
        public string MaTT1 { get => MaTT; set => MaTT = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int GiaTien1 { get => GiaTien; set => GiaTien = value; }
    }
}
