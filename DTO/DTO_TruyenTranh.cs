using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của truyện tranh gồm: mã truyện tranh, ảnh bìa, tên truyện, mã bộ truyện, định dạng, số lượng, giá tiền.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DTOTruyenTranh
    {
        private string MaTT;
        private string Anh;
        private string TenTruyen;
        private string MaBT;
        private string DinhDang;
        private int SoLuong;
        private int GiaTien;

        public string MaTT1 { get => MaTT; set => MaTT = value; }
        public string Anh1 { get => Anh; set => Anh = value; }
        public string TenTruyen1 { get => TenTruyen; set => TenTruyen = value; }
        public string MaBT1 { get => MaBT; set => MaBT = value; }
        public string DinhDang1 { get => DinhDang; set => DinhDang = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int GiaTien1 { get => GiaTien; set => GiaTien = value; }
        /// <summary>
        /// Constructor mặc định của DTOTruyenTranh
        /// </summary>
        public DTOTruyenTranh()
        {
            
        }
        /// <summary>
        /// Constructor có tham số của DTOTruyenTranh
        /// </summary>
        /// <param name="maTT">mã truyện tranh</param>
        /// <param name="anh">ảnh bìa</param>
        /// <param name="tenTruyen">tên truyện</param>
        /// <param name="maBT">mã bộ truyện</param>
        /// <param name="dinhDang">định dạng</param>
        /// <param name="soLuong">số lượng</param>
        /// <param name="giaTien">giá tiền</param>
        public DTOTruyenTranh(string maTT, string anh, string tenTruyen, string maBT, string dinhDang, int soLuong, int giaTien)
        {
            this.MaTT = maTT;
            this.Anh = anh;
            this.TenTruyen = tenTruyen; 
            this.MaBT = maBT;
            this.DinhDang = dinhDang;
            this.SoLuong = soLuong;
            this.GiaTien = giaTien;
        }
    }
}
