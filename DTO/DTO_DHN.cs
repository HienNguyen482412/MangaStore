using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DHN
    {
        private string _DHN_MADHN;
        private string _DHN_MANV;
        private string _DHN_MANXB;
        private string _DHN_NGAYNHAP;


        public string DHN_MADHN { get => _DHN_MADHN; set => _DHN_MADHN = value; }
        public string DHN_MANV { get => _DHN_MANV; set => _DHN_MANV = value; }
        public string DHN_NXB { get => _DHN_MANXB; set => _DHN_MANXB = value; }
        public string DHN_NGAYNHAP { get => _DHN_NGAYNHAP; set => _DHN_NGAYNHAP = value; }

        public DTO_DHN()
        {

        }
        public DTO_DHN(string madhn, string manv, string manxb, string ngaynhap)
        {
            this.DHN_MADHN = madhn;
            this.DHN_MANV = manv;
            this._DHN_MANXB = manxb;this._DHN_NGAYNHAP = ngaynhap;
        }

    }
}
