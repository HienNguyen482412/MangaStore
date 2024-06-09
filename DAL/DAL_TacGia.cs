using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Mục đích: thực hiện các thao tác liên quan đến dữ liệu của tác giả trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALTacGia
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức lấy danh sách các tác giả
        /// </summary>
        /// <returns>Danh sách thông tin của các tác giả</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayTacGia()
        {
            return ex.ReturnTable($"select MaTG as [Mã tác giả], TenTG as [Tên tác giả] from TacGia");
        }
        /// <summary>
        /// Phương thức thêm thông tin của một tác giả
        /// </summary>
        /// <param name="tg">Thông tin của một tác giả</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemTacGia(DTOTacGia tg)
        {
            return ex.ReturnBool($"insert into TacGia values ('{tg.MaTG1}',N'{tg.TenTG1}')");
        }
        /// <summary>
        /// Phương thức sửa thông tin tác giả
        /// </summary>
        /// <param name="tg">Thông tin tác giả</param>
        /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaTacGia(DTOTacGia tg)
        {
            return ex.ReturnBool($"update TacGia set TenTG = N'{tg.TenTG1}' where maTG = '{tg.MaTG1}'");
        }
        /// <summary>
        /// Phương thức xóa thông tin của một tác giả
        /// </summary>
        /// <param name="ma">Mã tác giả</param>
        /// <returns>Trả về true nếu xóa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaTacGia(string ma)
        {
            return ex.ReturnBool($"delete from tacgia where matg = '{ma}'");
        }
        /// <summary>
        /// Phương thức lấy danh sách tác giả có tên tương ứng
        /// </summary>
        /// <param name="ten">Tên của tác giả cần tìm</param>
        /// <returns>Danh sách tác giả có tên tương ứng với tên cần tìm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TimKiemTacGia(string ten)
        {
            return ex.ReturnTable($"select MaTG as [Mã tác giả], TenTG as [Tên tác giả] from TacGia where tentg = N'%{ten}%'");
        }
        /// <summary>
        /// Phương thức tự động tạo mã tác giả  
        /// </summary>
        /// <returns>Mã tác giả mới cho lần nhập tiếp theo</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaTG", "TacGia", 3, "TG0");
        }
        /// <summary>
        /// Phương thức lấy tên tác giả thông qua mã
        /// </summary>
        /// <param name="ma">Mã tác giả</param>
        /// <returns>Tên tác giả có mã tương ứng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public string LayTenTacGia(string ma)
        {
            return ex.ReturnValue($"select TenTG from TacGia where matg = '{ma}'");
        }
    }
}
