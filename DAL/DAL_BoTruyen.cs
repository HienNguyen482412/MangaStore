using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBoTruyen
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayBoTruyen()
        {
            return ex.ReturnTable($"select MaBT as [Mã bộ truyện], TenBT as [Tên bộ truyện], matg as [Mã tác giả], manxb as [Mã nhà xuất bản],dotuoi as [Độ tuổi] from BoTruyen");
        }
        public bool ThemBoTruyen(DTOBoTruyen bt)
        {
            return ex.ReturnBool($"insert into BoTruyen values ('{bt.MaBoTruyen1}', N'{bt.TenBoTruyen1}','{bt.MaTacGia1}','{bt.MaNXB1}',{bt.DoTuoi1})");
        }
        public bool SuaBoTruyen(DTOBoTruyen bt)
        {
            return ex.ReturnBool($"update BoTruyen set TenBT = N'{bt.TenBoTruyen1}', MaTG = '{bt.MaTacGia1}', MaNXB = '{bt.MaNXB1}', DoTuoi = {bt.DoTuoi1} where MaBT = '{bt.MaBoTruyen1}'");

        }
        public bool XoaBoTruyen(string ma)
        {
            return ex.ReturnBool($"delete from BoTruyen where MaBT = '{ma}'");
        }
        public DataTable TimKiemBoTruyen(string ten)
        {
            return ex.ReturnTable($"select MaBT as [Mã bộ truyện], TenBT as [Tên bộ truyện], matg as [Mã tác giả], manxb as [Mã nhà xuất bản],dotuoi as [Độ tuổi] from BoTruyen where mabt like N'%{ten}%'");
        }
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaBT", "BoTruyen", 3, "BT0");
        }
        public string LayTenBoTruyen(string ma)
        {
            return ex.ReturnValue($"select TenBT from BoTruyen where mabt = '{ma}'");
        }
    }
}
