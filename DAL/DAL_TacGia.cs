using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTacGia
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayTacGia()
        {
            return ex.ReturnTable($"select MaTG as [Mã tác giả], TenTG as [Tên tác giả] from TacGia");
        }
        public bool ThemTacGia(DTOTacGia tg)
        {
            return ex.ReturnBool($"insert into TacGia values ('{tg.MaTG1}',N'{tg.TenTG1}')");
        }
        public bool SuaTacGia(DTOTacGia tg)
        {
            return ex.ReturnBool($"update TacGia set TenTG = N'{tg.TenTG1}' where maTG = '{tg.MaTG1}'");
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
