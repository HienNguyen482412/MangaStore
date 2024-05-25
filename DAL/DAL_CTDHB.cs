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
    /// Mục đích: thực hiện các thao tác liên quan đến dữ liệu của chi tiết đơn hàng bán trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALCTDHB
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức thêm một chi tiết đơn hàng bán vào hóa đơn bán
        /// </summary>
        /// <param name="ct">Thông tin một chi tiết đơn hàng bán</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemCTDHB(DTOCTDHB ct)
        {
            return ex.ReturnBool($"insert into CTHDB values ('{ct.MaDHB1}','{ct.MaTT1}',{ct.SoLuong1},{ct.GiaTien1})");
        }
        /// <summary>
        /// Phương thức sửa một chi tiết đơn hàng bán trong một hóa đơn bán
        /// </summary>
        /// <param name="ct">Thông tin một chi tiết đơn hàng bán</param>
        /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaCTDHB(DTOCTDHB ct)
        {
            return ex.ReturnBool($"update CTHDB set SoLuong ={ct.SoLuong1} , GiaTien ={ct.GiaTien1}  where MaHDB = '{ct.MaDHB1}' and MaTT = '{ct.MaTT1}'");
        }
        /// <summary>
        /// Phương thức xóa một chi tiết đơn hàng bán vào hóa đơn bán
        /// </summary>
        /// <param name="matt">Mã truyện tranh cần xóa trong một đơn hàng bán</param>
        /// <param name="madhb">Mã truyện tranh cần xóa trong một đơn hàng bán</param>
        /// <returns>Trả về true nếu xóa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaCTDHB(string madhb, string matt)
        {
            return ex.ReturnBool($"delete from CTHDB where MaHDB = '{madhb}' and MaTT = '{matt}'");
        }
        /// <summary>
        /// Phương thức lấy danh sách các chi tiết hóa đơn bán của một hóa đơn bán
        /// </summary>
        /// <param name="madhb">Mã hóa đơn bán</param>
        /// <returns>Danh sách các chi tiết hóa đơn bán của một đơn hàng bán</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayCTDHB(string madhb)
        {
            return ex.ReturnTable($"select ct.Matt as [Mã truyện], TenTruyen as [Tên truyện], ct.SoLuong as [Số lượng], ct.giatien as [Giá tiền] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT where mahdb = '{madhb}'");
        }
        /// <summary>
        /// Phương thức lấy về danh sách các chi tiết đơn hàng bán có tên cần tìm
        /// </summary>
        /// <param name="madhb">Mã đơn hàng bán</param>
        /// <param name="ten">Tên truyện tranh cần tìm trong đơn hàng bán</param>
        /// <returns>Danh sách chi tiết đơn hàng bán có tên tương ứng với tên cần tìm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TimKiemCTDHB(string madhb, string ten)
        {
            return ex.ReturnTable($"select ct.Matt as [Mã truyện], TenTruyen as [Tên truyện], ct.SoLuong as [Số lượng], ct.giatien as [Giá tiền] from cthdb ct inner join TruyenTranh tt on ct.MaTT = tt.MaTT where mahdb = '{madhb}' and tentruyen like N'%{ten}%'");

        }
        public bool XoaTatCaCT(string madhb)
        {
            return ex.ReturnBool($"delete from CTHDB where MaHDB = '{madhb}'");
        }
    }
}
