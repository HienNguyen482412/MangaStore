using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TruyenTranh
    {
        private string _TRUYENTRANH_MATT;
        private string _TRUYENTRANH_ANH;
        private string _TRUYENTRANH_TENTRUYEN;
        private string _TRUYENTRANH_MABT;
        private string _TRUYENTRANH_DINHDANG;
        private int _TRUYENTRANH_SOLUONG;
        private int _TRUYENTRANH_GIATIEN;

        public string TRUYENTRANH_MATT { get => _TRUYENTRANH_MATT; set => _TRUYENTRANH_MATT = value; }
        public string TRUYENTRANH_ANH { get => _TRUYENTRANH_ANH; set => _TRUYENTRANH_ANH = value; }
        public string TRUYENTRANH_TENTRUYEN { get => _TRUYENTRANH_TENTRUYEN; set => _TRUYENTRANH_TENTRUYEN = value; }
        public string TRUYENTRANH_MABT { get => _TRUYENTRANH_MABT; set => _TRUYENTRANH_MABT = value; }
        public string TRUYENTRANH_DINHDANG { get => _TRUYENTRANH_DINHDANG; set => _TRUYENTRANH_DINHDANG = value; }
        public int TRUYENTRANH_SOLUONG { get => _TRUYENTRANH_SOLUONG; set => _TRUYENTRANH_SOLUONG = value; }
        public int TRUYENTRANH_GIATIEN { get => _TRUYENTRANH_GIATIEN; set => _TRUYENTRANH_GIATIEN = value; }

        public DTO_TruyenTranh()
        {
            
        }
        public DTO_TruyenTranh(string ma, string anh, string ten, string mabt, string dinhdang, int soluong, int giatien)
        {
            this._TRUYENTRANH_MATT = ma;
            this.TRUYENTRANH_ANH = anh;
            this.TRUYENTRANH_TENTRUYEN = ten; 
            this.TRUYENTRANH_MABT = mabt;
            this.TRUYENTRANH_DINHDANG = dinhdang;
            this.TRUYENTRANH_SOLUONG = soluong;
            this.TRUYENTRANH_GIATIEN = giatien;
        }
    }
}
