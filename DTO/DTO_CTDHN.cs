using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của chi tiết đơn hàng nhập gồm: mã đơn hàng nhập, mã truyện tranh, số lượng, giá tiền.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DTOCTDHN
    {
        private string MaDHN;
        private string MaTT;
        private int SoLuong;
        private int GiaTien;
        /// <summary>
        /// Constructor mặc định của DTOCTDHN
        /// </summary>
        public DTOCTDHN()
        {
            
        }
        /// <summary>
        /// Constructor có tham số của DTOCTDHN
        /// </summary>
        /// <param name="maDHN">mã đơn hàng nhập</param>
        /// <param name="maTT">mã truyện tranh</param>
        /// <param name="soLuong">số lượng</param>
        /// <param name="giaTien">giá tiền</param>
        public DTOCTDHN(string maDHN,string maTT, int soLuong, int giaTien)
        {
            this.MaDHN = maDHN;
            this.MaTT = maTT;
            this.SoLuong = soLuong;
            this.GiaTien = giaTien;
        }

        public string MaDHN1 { get => MaDHN; set => MaDHN = value; }
        public string MaTT1 { get => MaTT; set => MaTT = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int GiaTien1 { get => GiaTien; set => GiaTien = value; }
    }
}
