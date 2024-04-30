using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTODHN
    {
        private string MaDHN;
        private string MaNV;
        private string MaNXB;
        private string NgayNhap;

        public string MaDHN1 { get => MaDHN; set => MaDHN = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaNXB1 { get => MaNXB; set => MaNXB = value; }
        public string NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }

        public DTODHN()
        {

        }
        public DTODHN(string maDHN, string maNV, string maNXB, string ngayNhap)
        {
            this.MaDHN = maDHN;
            this.MaNV = maNV;
            this.MaNXB = maNXB;this.NgayNhap = ngayNhap;
        }

    }
}
