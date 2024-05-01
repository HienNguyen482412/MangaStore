using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của chi tiết đơn hàng bán gồm: mã đơn hàng bán, mã truyện tranh, số lượng, giá tiền.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DTOCTDHB
    {
        private string MaDHB;
        private string MaTT;
        private int SoLuong;
        private int GiaTien;

     
        /// <summary>
        /// Constructor mặc định của DTOCTDHB
        /// </summary>
        public DTOCTDHB()
        {
            
        }
        /// <summary>
        /// Constructor có tham số của DTOCTDHB
        /// </summary>
        /// <param name="maDHB">Mã đơn hàng bán</param>
        /// <param name="maTT">Mã truyện tranh</param>
        /// <param name="soLuong">Số lượng</param>
        /// <param name="giaTien">Giá tiền</param>
        public DTOCTDHB(string maDHB, string maTT, int soLuong, int giaTien)
        {
            this.MaDHB = maDHB;
            this.MaTT = maTT;
            this.SoLuong = soLuong;
            this.GiaTien = giaTien;
        }

        public string MaDHB1 { get => MaDHB; set => MaDHB = value; }
        public string MaTT1 { get => MaTT; set => MaTT = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int GiaTien1 { get => GiaTien; set => GiaTien = value; }
    }
}
