using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKhachHang
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
        public bool ThemKhachHang(DTOKhachHang kh)
        {
            return ex.ReturnBool($"insert into KhachHang values ('{kh.MaKH1}',N'{kh.TenKH1}',N'{kh.GioiTinh1}','{kh.NgaySinh1}',N'{kh.DiaChi1}','{kh.SDT1}')");
        }
        public bool SuaKhachHang(DTOKhachHang kh)
        {
            return ex.ReturnBool($"update KhachHang set TenKH = N'{kh.TenKH1}', GioiTinh = N'{kh.GioiTinh1}', NgaySinh = '{kh.NgaySinh1}', DiaChi = N'{kh.DiaChi1}', SDT = '{kh.SDT1}' where MaKH = '{kh.MaKH1}'");
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
