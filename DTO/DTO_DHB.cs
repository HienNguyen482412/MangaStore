using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DHB
    {
        private string _DHN_MADHB;
        private string _DHN_MANV;
        private string _DHN_MAKH;
        private string _DHN_NGAYBAN;

        public string DHN_MADHB { get => _DHN_MADHB; set => _DHN_MADHB = value; }
        public string DHN_MANV { get => _DHN_MANV; set => _DHN_MANV = value; }
        public string DHN_MAKH { get => _DHN_MAKH; set => _DHN_MAKH = value; }
        public string DHN_NGAYBAN { get => _DHN_NGAYBAN; set => _DHN_NGAYBAN = value; }
        public DTO_DHB()
        {
            
        }
        public DTO_DHB(string madhb, string manv, string makh, string ngayban)
        {
            this.DHN_MADHB = madhb;
            this.DHN_MANV = manv;
            this.DHN_MAKH = makh;
            this.DHN_NGAYBAN = ngayban;

        }
    }
}
