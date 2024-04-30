using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONXB
    {
        private string MaNXB;
        private string TenNNXB;
        private string DiaChi;
        private string SDT;
        private string Email;

        public string MaNXB1 { get => MaNXB; set => MaNXB = value; }
        public string TenNNXB1 { get => TenNNXB; set => TenNNXB = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }

        public DTONXB()
        {
            
        }
        public DTONXB(string maNXB, string tenNXB, string diaChi, string sdt, string email)
        {
            this.MaNXB = maNXB;
            this.TenNNXB = tenNXB;
            this.DiaChi= diaChi;
            this.SDT= sdt;
            this.Email = email;
        }
    }
}
