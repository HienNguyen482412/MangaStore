using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NXB
    {
        private string _NXB_MANXB;
        private string _NXB_TENNXB;
        private string _NXB_DIACHI;
        private string _NXB_SDT;
        private string _NXB_EMAIL;

        public string NXB_MANXB { get => _NXB_MANXB; set => _NXB_MANXB = value; }
        public string NXB_TENNXB { get => _NXB_TENNXB; set => _NXB_TENNXB = value; }
        public string NXB_DIACHI { get => _NXB_DIACHI; set => _NXB_DIACHI = value; }
        public string NXB_SDT { get => _NXB_SDT; set => _NXB_SDT = value; }
        public string NXB_EMAIL { get => _NXB_EMAIL; set => _NXB_EMAIL = value; }
        public DTO_NXB()
        {
            
        }
        public DTO_NXB(string manxb, string tennxb, string diachi, string sdt, string email)
        {
            this._NXB_MANXB = manxb;
            this._NXB_TENNXB = tennxb;
            this._NXB_DIACHI = diachi;
            this._NXB_SDT = sdt;
            this._NXB_EMAIL = email;
        }
    }
}
