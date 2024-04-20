using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BoTruyen
    {
        private string _BOTRUYEN_MABT;
        private string _BOTRUYEN_TENBT;
        private string _BOTRUYEN_MATG;
        private string _BOTRUYEN_MANXB;
        private int _BOTRUYEN_DOTUOI;

        public string BOTRUYEN_MABT { get => _BOTRUYEN_MABT; set => _BOTRUYEN_MABT = value; }
        public string BOTRUYEN_TENBT { get => _BOTRUYEN_TENBT; set => _BOTRUYEN_TENBT = value; }
        public string BOTRUYEN_MATG { get => _BOTRUYEN_MATG; set => _BOTRUYEN_MATG = value; }
        public string BOTRUYEN_MANXB { get => _BOTRUYEN_MANXB; set => _BOTRUYEN_MANXB = value; }
        public int BOTRUYEN_DOTUOI { get => _BOTRUYEN_DOTUOI; set => _BOTRUYEN_DOTUOI = value; }
        public DTO_BoTruyen()
        {
            
        }
        public DTO_BoTruyen(string mabt, string tenbt, string matg, string manxb, int dotuoi)
        {
            this._BOTRUYEN_MABT = mabt;
            this.BOTRUYEN_TENBT = tenbt;
            this.BOTRUYEN_MATG = matg; this.BOTRUYEN_MANXB = manxb; this.BOTRUYEN_DOTUOI = dotuoi;
        }
    }
}
