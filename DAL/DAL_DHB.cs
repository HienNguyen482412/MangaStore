using DTO;
using System.Data;

namespace DAL
{
    public class DALDHB
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức lấy danh sách các hóa đơn bán
        /// </summary>
        /// <returns>Danh sách các thông tin của hóa đơn bán</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayDHB()
        {
            return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB");
        }
        /// <summary>
        /// Phương thức thêm một hóa đơn bán
        /// </summary>
        /// <param name="dhb">Thông tin của một hóa đơn bán</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemDHB(DTODHB dhb)
        {
            return ex.ReturnBool($"insert into HDB values ('{dhb.MaDHB1}','{dhb.MaNV1}','{dhb.MaKH1}','{dhb.NgayBan1}')");
        }
        /// <summary>
        /// Phương thức sửa một hóa đơn bán
        /// </summary>
        /// <param name="dhb">Thông tin của một hóa đơn bán</param>
        /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaDHB(DTODHB dhb)
        {
            return ex.ReturnBool($"update HDB set MaNV = '{dhb.MaNV1}', MaKH = '{dhb.MaKH1}', NgayBan = '{dhb.NgayBan1}' where mahdb = '{dhb.MaDHB1}'");
        }
        /// <summary>
        /// Phương thức xóa một hóa đơn bán
        /// </summary>
        /// <param name="ma">Mã hóa đơn bán cần xóa</param>
        /// <returns>Trả về true nếu xóa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaDHB(string ma)
        {
            return ex.ReturnBool($"delete from HDB where MaHDB = '{ma}'");
        }
        /// <summary>
        /// Hàm tìm kiếm đơn hàng theo ngày tháng và năm.s = 0, 1,2 và 3. Nếu s = 0 tìm theo ngày, s = 1 tìm theo tháng, s = 2 tìm theo năm và s = 3 thì tìm theo cả ngày tháng và năm
        /// </summary>
        /// <param name="s">Lựa chọn</param>
        /// <param name="day">Ngày </param>
        /// <param name="month">Tháng</param>
        /// <param name="year">Năm</param>
        /// <returns></returns>
        public DataTable TimKiemDHB(int s, int day, int month, int year)
        {
            if (s == 0)
            {
                return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB where day(ngayban) = {day}");

            }
            else if (s == 1)
            {
                return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB where Month(ngayban) = {month}");

            }
            else if (s == 2)
            {
                return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB where year(ngayban) = {year}");

            }
            else
            {
                return ex.ReturnTable($"select MaHDB as [Mã đơn hàng bán], MaNV as [Mã nhân viên], MaKH as [Mã khách hàng], ngayban as [Ngày bán] from HDB where day(ngayban) = {day} and Month(ngayban) = {month} and year(ngayban) = {year} ");

            }
        }
        /// <summary>
        /// Phương thức tự động tạo mã cho đơn hàng bán
        /// </summary>
        /// <returns>Mã đơn hàng bán mới cho lần nhập tiếp theo</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaHDB", "HDB", 4, "DHB0");
        }
     
    }
}
