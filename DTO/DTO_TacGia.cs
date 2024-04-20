using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TacGia
    {
        private string _TACGIA_MATG;
        private string _TACGIA_TENTG;

        public string TACGIA_MATG { get => _TACGIA_MATG; set => _TACGIA_MATG = value; }
        public string TACGIA_TENTG { get => _TACGIA_TENTG; set => _TACGIA_TENTG = value; }
        public DTO_TacGia()
        {
            
        }
        public DTO_TacGia(string matg, string tentg)
        {
            this._TACGIA_MATG = matg;
            this.TACGIA_TENTG = tentg;
        }
    }
}
