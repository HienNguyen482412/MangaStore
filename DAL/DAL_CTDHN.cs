using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTDHN
    {
        ExcuteQuerry ex = new ExcuteQuerry();

        public bool ThemCTDHN(DTO_CTDHN ct)
        {
            return ex.ReturnBool($"insert into CTHDN values ('{ct.CTDHN_MADHN}','{ct.CTDHN_MATT}',{ct.CTDHN_SOLUONG},{ct.CTDHN_GIATIEN})");
        }
        public bool SuaCTDHN(DTO_CTDHN ct)
        {
            return ex.ReturnBool($"update CTHDN set SoLuong ={ct.CTDHN_SOLUONG} , GiaTien ={ct.CTDHN_GIATIEN}  where MaHDN = '{ct.CTDHN_MADHN}' and MaTT = '{ct.CTDHN_MATT}'");
        }
        public bool XoaCTDHN(string madhn, string matt)
        {
            return ex.ReturnBool($"delete from CTHDN where MaHDN = '{madhn}' and MaTT = '{matt}'");
        }
        public DataTable LayCTDHN(string madhn)
        {
            return ex.ReturnTable($"select ct.Matt as [Mã truyện], TenTruyen as [Tên truyện], ct.SoLuong as [Số lượng], ct.giatien as [Giá tiền] from cthdn ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT where mahdn = '{madhn}'");
        }
        public DataTable TimKiemCTDHN(string madhn, string ten)
        {
            return ex.ReturnTable($"select ct.Matt as [Mã truyện], TenTruyen as [Tên truyện], ct.SoLuong as [Số lượng], ct.giatien as [Giá tiền] from cthdn ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT where mahdn = '{madhn}' and tentruyen like N'%{ten}%'");

        }
    }
}
