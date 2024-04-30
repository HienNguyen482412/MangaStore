using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCTDHN
    {
        ExcuteQuerry ex = new ExcuteQuerry();

        public bool ThemCTDHN(DTOCTDHN ct)
        {
            return ex.ReturnBool($"insert into CTHDN values ('{ct.MaDHN1}','{ct.MaTT1}',{ct.SoLuong1},{ct.GiaTien1})");
        }
        public bool SuaCTDHN(DTOCTDHN ct)
        {
            return ex.ReturnBool($"update CTHDN set SoLuong ={ct.SoLuong1} , GiaTien ={ct.GiaTien1}  where MaHDN = '{ct.MaDHN1}' and MaTT = '{ct.MaTT1}'");
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
