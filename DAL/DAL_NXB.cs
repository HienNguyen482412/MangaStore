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
    /// Mục đích: thực hiện các thao tác liên quan đến dữ liệu của nhà xuất bản trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALNXB
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức lấy danh sách nhà xuất bản
        /// </summary>
        /// <returns>Danh sách thông tin các nhà xuất bản</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayNXB()
        {
            return ex.ReturnTable($"select MaNXB as [Mã NXB],TenNXB as [Tên NXB], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email] from NXB");
        }
        /// <summary>
        /// Phương thức thêm thông tin một nhà xuất bản
        /// </summary>
        /// <param name="nxb">Thông tin của một nhà xuất bản</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemNXB(DTONXB nxb)
        {
            return ex.ReturnBool($"insert into NXB values ('{nxb.MaNXB1}', N'{nxb.TenNNXB1}',N'{nxb.DiaChi1}','{nxb.SDT1}','{nxb.Email1}')");
        }
        /// <summary>
        /// Phương thức sửa thông tin một nhà xuất bản
        /// </summary>
        /// <param name="nxb">Thông tin của một nhà xuất bản</param>
        /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaNXB(DTONXB nxb)
        {

            return ex.ReturnBool($"update NXB set TenNXB = N'{nxb.TenNNXB1}', DiaChi = N'{nxb.DiaChi1}', SDT = '{nxb.SDT1}', Email = '{nxb.Email1}' where MaNXB = '{nxb.MaNXB1}'");
        }
        /// <summary>
        /// Phương thức xóa nhà xuất bản
        /// </summary>
        /// <param name="ma">Mã nhà xuất bản</param>
        /// <returns>Trả về true nếu xóa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaNCB(string ma)
        {
            return ex.ReturnBool($"delete from NXB where MaNXB = '{ma}'");
        }
        /// <summary>
        /// Phương thức lấy danh sách nhà xuất bản có tên tướng ứng
        /// </summary>
        /// <param name="ten">Tên nhà xuất bản cần tìm</param>
        /// <returns>Danh sách nhà xuất bản có tên tương ứng cần tìm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TimKiemNXB(string ten)
        {
            return ex.ReturnTable($"select MaNXB as [Mã NXB],TenNXB as [Tên NXB], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email] from NXB where TenNXB like N'%{ten}%'");
        }
        /// <summary>
        /// Phương thức tự động tạo mã cho nhà xuất bản
        /// </summary>
        /// <returns>Mã nhà xuất bản cho lần nhập mới tiếp theo</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaNXB", "NXB", 4, "NXB0");
        }
        /// <summary>
        /// Phương thức lấy tên của nhà xuất bản thông qua mã nhà xuất bản
        /// </summary>
        /// <param name="ma">Mã nhà xuất bản</param>
        /// <returns>Tên nhà xuất bản có mã tương ứng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public string LayTenNXB(string ma)
        {
            return ex.ReturnValue($"select TenNXB  from NXB where MaNXB = '{ma}'");
        }
        /// <summary>
        /// Phương thức lấy thông tin nhà xuất bản thông qua mã nhà xuất bản
        /// </summary>
        /// <param name="ma">Mã nhà xuất bản</param>
        /// <returns>Thông tin nhà xuất bản có mã tương ứng</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayNXB(string ma)
        {
            return ex.ReturnTable($"select TenNXB as [Tên NXB], DiaChi as [Địa chỉ], SDT as [SĐT],Email as [Email] from NXB where MaNXB = '{ma}'");

        }
    }
}
