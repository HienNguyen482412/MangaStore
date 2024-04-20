using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string _KHACHHANG_MAKH;
        private string _KHACHHANG_TENKH;
        private string _KHACHHANG_GIOITINH;
        private string _KHACHHANG_NGAYSINH;
        private string _KHACHHANG_DIACHI;
        private string _KHACHHANG_SDT;


     

        public string KHACHHANG_MAKH { get => _KHACHHANG_MAKH; set => _KHACHHANG_MAKH = value; }
        public string KHACHHANG_TENKH { get => _KHACHHANG_TENKH; set => _KHACHHANG_TENKH = value; }
        public string KHACHHANG_GIOITINH { get => _KHACHHANG_GIOITINH; set => _KHACHHANG_GIOITINH = value; }
        public string KHACHHANG_NGAYSINH { get => _KHACHHANG_NGAYSINH; set => _KHACHHANG_NGAYSINH = value; }
        public string KHACHHANG_DIACHI { get => _KHACHHANG_DIACHI; set => _KHACHHANG_DIACHI = value; }
        public string KHACHHANG_SDT { get => _KHACHHANG_SDT; set => _KHACHHANG_SDT = value; }
        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(string makh, string tenkh, string gioitinh, string ngaysinh, string diachi, string sdt)
            
        {
            this.KHACHHANG_MAKH = makh;
            this.KHACHHANG_TENKH = tenkh;
            this.KHACHHANG_GIOITINH = gioitinh;
            this.KHACHHANG_NGAYSINH = ngaysinh;
            this.KHACHHANG_DIACHI = diachi;
            this.KHACHHANG_SDT = sdt;
        }
    }
}
