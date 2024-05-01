using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của khách hàng gồm: mã khách hàng, tên khách hàng, giới tính, ngày sinh, địa chỉ, số điện thoại.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DTOKhachHang
    {
        private string MaKH;
        private string TenKH;
        private string GioiTinh;
        private string NgaySinh;
        private string DiaChi;
        private string SDT;


    
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        /// <summary>
        /// Constructor mặc định của DTOKhachHang
        /// </summary>
        public DTOKhachHang()
        {

        }
        /// <summary>
        /// Constructor có tham số của DTOKhachHang
        /// </summary>
        /// <param name="maKH">mã khách hàng</param>
        /// <param name="tenKH">tên khách hàng</param>
        /// <param name="gioiTinh">giới tính</param>
        /// <param name="ngaySinh">ngày sinh</param>
        /// <param name="diaChi">địa chỉ</param>
        /// <param name="sdt">số điện thoại</param>
        public DTOKhachHang(string maKH, string tenKH, string gioiTinh, string ngaySinh, string diaChi, string sdt)
            
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.SDT = sdt;
        }
    }
}
