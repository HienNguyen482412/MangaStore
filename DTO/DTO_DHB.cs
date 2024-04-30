using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTODHB
    {
        private string MaDHB;
        private string MaNV;
        private string MaKH;
        private string NgayBan;

        public DTODHB()
        {
            
        }
        public DTODHB(string maDHB, string maNV, string maKH, string ngayBan)
        {
            this.MaDHB = maDHB;
            this.MaNV= maNV;
            this.MaKH = maKH;
            this.NgayBan = ngayBan;

        }

        public string MaDHB1 { get => MaDHB; set => MaDHB = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string NgayBan1 { get => NgayBan; set => NgayBan = value; }
    }
}
