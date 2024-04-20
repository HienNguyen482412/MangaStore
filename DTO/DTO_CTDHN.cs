using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_CTDHN
    {
        private string _CTDHN_MADHN;
        private string _CTDHN_MATT;
        private int _CTDHN_SOLUONG;
        private int _CTDHN_GIATIEN;

        public string CTDHN_MADHN { get => _CTDHN_MADHN; set => _CTDHN_MADHN = value; }
        public string CTDHN_MATT { get => _CTDHN_MATT; set => _CTDHN_MATT = value; }
        public int CTDHN_SOLUONG { get => _CTDHN_SOLUONG; set => _CTDHN_SOLUONG = value; }
        public int CTDHN_GIATIEN { get => _CTDHN_GIATIEN; set => _CTDHN_GIATIEN = value; }
        public DTO_CTDHN()
        {
            
        }
        public DTO_CTDHN(string madhn,string matt, int soluong, int giatien)
        {
            this._CTDHN_MADHN = madhn;
            this._CTDHN_MATT = matt;
            this._CTDHN_SOLUONG = soluong;
            this._CTDHN_GIATIEN = giatien;
        }
    }
}
