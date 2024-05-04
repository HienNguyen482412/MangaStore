using DTO;
using System.Data;

namespace DAL
{
    /// <summary>
    /// Mục đích: thực hiện các thao tác liên quan đến dữ liệu của bộ truyện trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALBoTruyen
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức lấy danh sách các bộ truyện
        /// </summary>
        /// <returns>Danh sách thông tin các bộ truyện</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayBoTruyen()
        {
            return ex.ReturnTable($"select MaBT as [Mã bộ truyện], TenBT as [Tên bộ truyện], matg as [Mã tác giả], manxb as [Mã nhà xuất bản],dotuoi as [Độ tuổi] from BoTruyen");
        }
        /// <summary>
        /// Phương thức thêm thông tin một bộ truyện trong cơ sở dữ liệu
        /// </summary>
        /// <param name="bt">Thông tin bộ truyện cần thêm mới</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại thì trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemBoTruyen(DTOBoTruyen bt)
        {
            return ex.ReturnBool($"insert into BoTruyen values ('{bt.MaBoTruyen1}', N'{bt.TenBoTruyen1}','{bt.MaTacGia1}','{bt.MaNXB1}',{bt.DoTuoi1})");
        }
        /// <summary>
        /// Phương thức sửa thông tin một bộ truyện trong cơ sở dữ liệu
        /// </summary>
        /// <param name="bt">Thông tin bộ truyện cần được sửa thông tin</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại thì trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaBoTruyen(DTOBoTruyen bt)
        {
            return ex.ReturnBool($"update BoTruyen set TenBT = N'{bt.TenBoTruyen1}', MaTG = '{bt.MaTacGia1}', MaNXB = '{bt.MaNXB1}', DoTuoi = {bt.DoTuoi1} where MaBT = '{bt.MaBoTruyen1}'");

        }
        /// <summary>
        /// Phương thức xóa một bộ truyện trong cơ sở dữ liệu
        /// </summary>
        /// <param name="ma">Mã bộ truyện cần xóa</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại thì trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaBoTruyen(string ma)
        {
            return ex.ReturnBool($"delete from BoTruyen where MaBT = '{ma}'");
        }
        /// <summary>
        /// Phương thức lấy danh sách các bộ truyện có tên tương ứng cần tìm
        /// </summary>
        /// <param name="ten">Tên bộ truyện cần tìm</param>
        /// <returns>Danh sách thông tin các bộ truyện có tên tương ứng cới tên đượ tìm kiếm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TimKiemBoTruyen(string ten)
        {
            return ex.ReturnTable($"select MaBT as [Mã bộ truyện], TenBT as [Tên bộ truyện], matg as [Mã tác giả], manxb as [Mã nhà xuất bản],dotuoi as [Độ tuổi] from BoTruyen where mabt like N'%{ten}%'");
        }
        /// <summary>
        /// Phương thức tự động tạo mã kế tiếp cho bộ truyện
        /// </summary>
        /// <returns>Mã bộ truyện mới được tạo cho lần nhập thông tin mới tiếp theo</returns>    
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaBT", "BoTruyen", 3, "BT0");
        }
        /// <summary>
        /// Phương thức lấy tên bộ truyện thông qua mã bộ truyện
        /// </summary>
        /// <param name="ma">Mã bộ truyện</param>
        /// <returns>Tên bộ truyện</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public string LayTenBoTruyen(string ma)
        {
            return ex.ReturnValue($"select TenBT from BoTruyen where mabt = '{ma}'");
        }
    }
}
