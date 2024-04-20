using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NXB
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayNXB()
        {
            return ex.ReturnTable($"select MaNXB as [Mã NXB],TenNXB as [Tên NXB], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email] from NXB");
        }
        public bool ThemNXB(DTO_NXB nxb)
        {
            return ex.ReturnBool($"insert into NXB values ('{nxb.NXB_MANXB}', N'{nxb.NXB_TENNXB}',N'{nxb.NXB_DIACHI}','{nxb.NXB_SDT}','{nxb.NXB_EMAIL}')");
        }
        public bool SuaNXB(DTO_NXB nxb)
        {

            return ex.ReturnBool($"update NXB set TenNXB = N'{nxb.NXB_TENNXB}', DiaChi = N'{nxb.NXB_DIACHI}', SDT = '{nxb.NXB_SDT}', Email = '{nxb.NXB_EMAIL}' where MaNXB = '{nxb.NXB_MANXB}'");
        }
        public bool XoaNCB(string ma)
        {
            return ex.ReturnBool($"delete from NXB where MaNXB = '{ma}'");
        }
        public DataTable TimKiemNXB(string ten)
        {
            return ex.ReturnTable($"select MaNXB as [Mã NXB],TenNXB as [Tên NXB], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email] from NXB where TenNXB like N'%{ten}%'");
        }
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaNXB", "NXB", 4, "NXB0");
        }
        public string LayTenNXB(string ma)
        {
            return ex.ReturnValue($"select TenNXB  from NXB where MaNXB = '{ma}'");
        }
        public DataTable LayNXB(string ma)
        {
            return ex.ReturnTable($"select TenNXB as [Tên NXB], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email] from NXB where MaNXB = '{ma}'");

        }
    }
}
