using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của tác giả gồm: mã tác giả, tên tác giả .
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DTOTacGia
    {
        private string MaTG;
        private string TenTG;

        public string MaTG1 { get => MaTG; set => MaTG = value; }
        public string TenTG1 { get => TenTG; set => TenTG = value; }
        /// <summary>
        /// Constructor mặc định của DTOTacGia
        /// </summary>
        public DTOTacGia()
        {
            
        }
        /// <summary>
        /// Constructor có thám số của DTOTacGia
        /// </summary>
        /// <param name="maTG">mã tác giả</param>
        /// <param name="tenTG">tên tác giả</param>
        public DTOTacGia(string maTG, string tenTG)
        {   
            this.MaTG = maTG;
            this.TenTG = tenTG;
        }
    }
}
