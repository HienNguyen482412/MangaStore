using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNXB
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayNXB()
        {
            return ex.ReturnTable($"select MaNXB as [Mã NXB],TenNXB as [Tên NXB], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email] from NXB");
        }
        public bool ThemNXB(DTONXB nxb)
        {
            return ex.ReturnBool($"insert into NXB values ('{nxb.MaNXB1}', N'{nxb.TenNNXB1}',N'{nxb.DiaChi1}','{nxb.SDT1}','{nxb.Email1}')");
        }
        public bool SuaNXB(DTONXB nxb)
        {

            return ex.ReturnBool($"update NXB set TenNXB = N'{nxb.TenNNXB1}', DiaChi = N'{nxb.DiaChi1}', SDT = '{nxb.SDT1}', Email = '{nxb.Email1}' where MaNXB = '{nxb.MaNXB1}'");
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
