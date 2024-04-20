using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TacGia
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayTacGia()
        {
            return ex.ReturnTable($"select MaTG as [Mã tác giả], TenTG as [Tên tác giả] from TacGia");
        }
        public bool ThemTacGia(DTO_TacGia tg)
        {
            return ex.ReturnBool($"insert into TacGia values ('{tg.TACGIA_MATG}',N'{tg.TACGIA_TENTG}')");
        }
        public bool SuaTacGia(DTO_TacGia tg)
        {
            return ex.ReturnBool($"update TacGia set MaTG = '{tg.TACGIA_MATG}', TenTG = N'{tg.TACGIA_TENTG}'");
        }
        public bool XoaTacGia(string ma)
        {
            return ex.ReturnBool($"delete from tacgia where matg = '{ma}'");
        }
        public DataTable TimKiemTacGia(string ten)
        {
            return ex.ReturnTable($"select MaTG as [Mã tác giả], TenTG as [Tên tác giả] from TacGia where tentg = N'%{ten}%'");
        }
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaTG", "TacGia", 3, "TG0");
        }
        public string LayTenTacGia(string ma)
        {
            return ex.ReturnValue($"select TenTG from TacGia where matg = '{ma}'");
        }
    }
}
