using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCTDHB
    {
        ExcuteQuerry ex = new ExcuteQuerry();

        public bool ThemCTDHB(DTOCTDHB ct)
        {
            return ex.ReturnBool($"insert into CTHDB values ('{ct.MaDHB1}','{ct.MaTT1}',{ct.SoLuong1},{ct.GiaTien1})");
        }
        public bool SuaCTDHB(DTOCTDHB ct)
        {
            return ex.ReturnBool($"update CTHDB set SoLuong ={ct.SoLuong1} , GiaTien ={ct.GiaTien1}  where MaHDB = '{ct.MaDHB1}' and MaTT = '{ct.MaTT1}'");
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
