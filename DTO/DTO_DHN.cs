using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của đơn hàng nhập gồm: mã đơn hàng nhập, mã nhân viên, mã nhà xuất bản, ngày nhập.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DTODHN
    {
        private string MaDHN;
        private string MaNV;
        private string MaNXB;
        private string NgayNhap;

        public string MaDHN1 { get => MaDHN; set => MaDHN = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaNXB1 { get => MaNXB; set => MaNXB = value; }
        public string NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        /// <summary>
        /// Constructor mặc định của DTODHN
        /// </summary>
        public DTODHN()
        {

        }
        /// <summary>
        /// Constructor có tham số của DTODHN
        /// </summary>
        /// <param name="maDHN">mã đơn hàng nhập</param>
        /// <param name="maNV">mã nhân viên</param>
        /// <param name="maNXB">mã nhà xuất bản</param>
        /// <param name="ngayNhap">ngày nhập</param>
        public DTODHN(string maDHN, string maNV, string maNXB, string ngayNhap)
        {
            this.MaDHN = maDHN;
            this.MaNV = maNV;
            this.MaNXB = maNXB;this.NgayNhap = ngayNhap;
        }

    }
}
