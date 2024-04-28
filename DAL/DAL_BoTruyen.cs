using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BoTruyen
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayBoTruyen()
        {
            return ex.ReturnTable($"select MaBT as [Mã bộ truyện], TenBT as [Tên bộ truyện], matg as [Mã tác giả], manxb as [Mã nhà xuất bản],dotuoi as [Độ tuổi] from BoTruyen");
        }
        public bool ThemBoTruyen(DTO_BoTruyen bt)
        {
            return ex.ReturnBool($"insert into BoTruyen values ('{bt.BOTRUYEN_MABT}', N'{bt.BOTRUYEN_TENBT}','{bt.BOTRUYEN_MATG}','{bt.BOTRUYEN_MANXB}',{bt.BOTRUYEN_DOTUOI})");
        }
        public bool SuaBoTruyen(DTO_BoTruyen bt)
        {
            return ex.ReturnBool($"update BoTruyen set TenBT = N'{bt.BOTRUYEN_TENBT}', MaTG = '{bt.BOTRUYEN_MATG}', MaNXB = '{bt.BOTRUYEN_MANXB}', DoTuoi = {bt.BOTRUYEN_DOTUOI} where MaBT = '{bt.BOTRUYEN_MABT}'");

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
