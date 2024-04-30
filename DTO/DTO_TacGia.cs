using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOTacGia
    {
        private string MaTG;
        private string TenTG;

        public string MaTG1 { get => MaTG; set => MaTG = value; }
        public string TenTG1 { get => TenTG; set => TenTG = value; }

        public DTOTacGia()
        {
            
        }
        public DTOTacGia(string maTG, string tenTG)
        {   
            this.MaTG = maTG;
            this.TenTG = tenTG;
        }
    }
}
