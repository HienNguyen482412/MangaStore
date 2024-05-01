using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của đơn hàng bán gồm: mã đơn hàng bán, mã nhân viên, mã khách hàng, ngày bán.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DTODHB
    {
        private string MaDHB;
        private string MaNV;
        private string MaKH;
        private string NgayBan;
        /// <summary>
        /// Constructor mặc định của DTODHB
        /// </summary>
        public DTODHB()
        {
            
        }
        /// <summary>
        /// Constructor có tham số của DTODHB
        /// </summary>
        /// <param name="maDHB">mã đơn hàng bán</param>
        /// <param name="maNV">mã nhân viên</param>
        /// <param name="maKH">mã khách hàng</param>
        /// <param name="ngayBan">ngày bán</param>
        public DTODHB(string maDHB, string maNV, string maKH, string ngayBan)
        {
            this.MaDHB = maDHB;
            this.MaNV= maNV;
            this.MaKH = maKH;
            this.NgayBan = ngayBan;

        }

        public string MaDHB1 { get => MaDHB; set => MaDHB = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string NgayBan1 { get => NgayBan; set => NgayBan = value; }
    }
}
