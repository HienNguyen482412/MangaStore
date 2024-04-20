using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTDHB
    {
        ExcuteQuerry ex = new ExcuteQuerry();

        public bool ThemCTDHB(DTO_CTDHB ct)
        {
            return ex.ReturnBool($"insert into CTHDB values ('{ct.CTDHN_MADHB}','{ct.CTDHN_MATT}',{ct.CTDHN_SOLUONG},{ct.CTDHN_GIATIEN})");
        }
        public bool SuaCTDHB(DTO_CTDHB ct)
        {
            return ex.ReturnBool($"update CTHDB set SoLuong ={ct.CTDHN_SOLUONG} , GiaTien ={ct.CTDHN_GIATIEN}  where MaHDB = '{ct.CTDHN_MADHB}' and MaTT = '{ct.CTDHN_MATT}'");
        }
        public bool XoaCTDHB(string madhn, string matt)
        {
            return ex.ReturnBool($"delete from CTHDB where MaHDB = '{madhn}' and MaTT = '{matt}'");
        }
        public DataTable LayCTDHB(string madhn)
        {
            return ex.ReturnTable($"select ct.Matt as [Mã truyện], TenTruyen as [Tên truyện], ct.SoLuong as [Số lượng], ct.giatien as [Giá tiền] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT where mahdb = '{madhn}'");
        }
        public DataTable TimKiemCTDHB(string madhb, string ten)
        {
            return ex.ReturnTable($"select ct.Matt as [Mã truyện], TenTruyen as [Tên truyện], ct.SoLuong as [Số lượng], ct.giatien as [Giá tiền] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT where mahdb = '{madhb}' and tentruyen like N'%{ten}%'");

        }
    }
}
