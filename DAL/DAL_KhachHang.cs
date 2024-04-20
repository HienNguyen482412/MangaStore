using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayKhachHang()
        {
            return ex.ReturnTable($"select MaKH as [Mã khách hàng], TenKH as [Tên khách hàng], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT] from KhachHang");
        }
        public DataTable LayKhachHang(string makh)
        {
            return ex.ReturnTable($"select TenKH as [Tên khách hàng], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT] from KhachHang where makh = '{makh}'");

        }
        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            return ex.ReturnBool($"insert into KhachHang values ('{kh.KHACHHANG_MAKH}',N'{kh.KHACHHANG_TENKH}',N'{kh.KHACHHANG_GIOITINH}','{kh.KHACHHANG_NGAYSINH}',N'{kh.KHACHHANG_DIACHI}','{kh.KHACHHANG_SDT}')");
        }
        public bool SuaKhachHang(DTO_KhachHang kh)
        {
            return ex.ReturnBool($"update KhachHang set TenKH = N'{kh.KHACHHANG_TENKH}', GioiTinh = N'{kh.KHACHHANG_GIOITINH}', NgaySinh = '{kh.KHACHHANG_NGAYSINH}', DiaChi = N'{kh.KHACHHANG_DIACHI}', SDT = '{kh.KHACHHANG_SDT}' where MaKH = '{kh.KHACHHANG_MAKH}'");
        }
        public bool XoaKhachHang(string ma)
        {
            return ex.ReturnBool($"delete from KhachHang where MaKH = '{ma}'");
        }
        public DataTable TimKiemKhachHang(string ten)
        {
            return ex.ReturnTable($"select MaKH as [Mã khách hàng], TenKH as [Tên khách hàng], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], SDT as [SĐT] from KhachHang where TenKH like N'%{ten}%'");
        }
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaKH", "KhachHang", 3, "KH0");
        }
    }
}
