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
    /// Mục đích: thực hiện các thao tác liên quan đến dữ liệu của chi tiết đơn hàng nhập trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALCTDHN
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức thêm một chi tiết đơn hàng bán vào hóa đơn nhập
        /// </summary>
        /// <param name="ct">Thông tin một chi tiết đơn hàng nhập</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemCTDHN(DTOCTDHN ct)
        {
            return ex.ReturnBool($"insert into CTHDN values ('{ct.MaDHN1}','{ct.MaTT1}',{ct.SoLuong1},{ct.GiaTien1})");
        }
        /// <summary>
        /// Phương thức sửa một chi tiết đơn hàng nhập trong một hóa đơn nhập
        /// </summary>
        /// <param name="ct">Thông tin một chi tiết đơn hàng nhập</param>
        /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaCTDHN(DTOCTDHN ct)
        {
            return ex.ReturnBool($"update CTHDN set SoLuong ={ct.SoLuong1} , GiaTien ={ct.GiaTien1}  where MaHDN = '{ct.MaDHN1}' and MaTT = '{ct.MaTT1}'");
        }
        /// <summary>
        /// Phương thức xóa một chi tiết đơn hàng nhập vào hóa đơn nhập
        /// </summary>
        /// <param name="matt">Mã truyện tranh cần xóa trong một đơn hàng nhập</param>
        /// <param name="madhn">Mã truyện tranh cần xóa trong một đơn hàng nhập</param>
        /// <returns>Trả về true nếu xóa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaCTDHN(string madhn, string matt)
        {
            return ex.ReturnBool($"delete from CTHDN where MaHDN = '{madhn}' and MaTT = '{matt}'");
        }
        /// <summary>
        /// Phương thức lấy danh sách các chi tiết hóa đơn nhập của một hóa đơn nhập
        /// </summary>
        /// <param name="madhn">Mã hóa đơn nhập</param>
        /// <returns>Danh sách các chi tiết hóa đơn nhập của một đơn hàng nhập</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayCTDHN(string madhn)
        {
            return ex.ReturnTable($"select ct.Matt as [Mã truyện], TenTruyen as [Tên truyện], ct.SoLuong as [Số lượng], ct.giatien as [Giá tiền] from cthdn ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT where mahdn = '{madhn}'");
        }
        /// <summary>
        /// Phương thức lấy về danh sách các chi tiết đơn hàng nhập có tên cần tìm
        /// </summary>
        /// <param name="madhn">Mã đơn hàng nhập</param>
        /// <param name="ten">Tên truyện tranh cần tìm trong đơn hàng nhập</param>
        /// <returns>Danh sách chi tiết đơn hàng nhập có tên tương ứng với tên cần tìm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TimKiemCTDHN(string madhn, string ten)
        {
            return ex.ReturnTable($"select ct.Matt as [Mã truyện], TenTruyen as [Tên truyện], ct.SoLuong as [Số lượng], ct.giatien as [Giá tiền] from cthdn ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT where mahdn = '{madhn}' and tentruyen like N'%{ten}%'");

        }
        public bool XoaTatCaCT(string madhn)
        {
            return ex.ReturnBool($"delete from CTHDN where MaHDN = '{madhn}'");
        }
    }
}
