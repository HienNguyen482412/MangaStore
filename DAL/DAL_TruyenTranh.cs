using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Mục đích: thực hiện các thao tác liên quan đến dữ liệu của truyện tranh trong cơ sở dữ liệu.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>
    public class DALTruyenTranh : DBConnect
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        /// <summary>
        /// Phương thức lấy danh sách truyện tranh
        /// </summary>
        /// <returns>Danh sách truyện tranh</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable LayTruyenTranh()
        {
            return ex.ReturnTable($"select matt as [Mã truyện tranh], anh as [Ảnh], tentruyen as [Tên truyện], mabt as [Mã bộ truyện], dinhdang as [Định dạng], soluong as [Số lượng], giatien as [Giá tiền] from TruyenTranh");
        }
        /// <summary>
        /// Phương thức thêm thông tin của một truyện tranh
        /// </summary>
        /// <param name="tt">Thông tin của truyện tranh</param>
        /// <returns>Trả về true nếu thêm thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool ThemTruyenTranh(DTOTruyenTranh tt)
        {
            try
            {
                _conn.Open();
                byte[] dla;
                FileStream fs = new FileStream(tt.Anh1, FileMode.Open, FileAccess.Read);
                dla = new byte[fs.Length];
                fs.Read(dla, 0, Convert.ToInt32(fs.Length));
                SqlParameter imgdata = new SqlParameter("@imgdata", SqlDbType.VarBinary, -1);
                imgdata.Value = dla;
                string querry = $"insert into TruyenTranh values ('{tt.MaTT1}',@imgdata, N'{tt.TenTruyen1}','{tt.MaBT1}', N'{tt.DinhDang1}',{tt.SoLuong1},{tt.GiaTien1})";
                SqlCommand cmd = new SqlCommand(querry, _conn);
                cmd.Parameters.Add(imgdata);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch (SqlException sql)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        /// <summary>
        /// Phương thức sửa thông tin của một truyện tranh
        /// </summary>
        /// <param name="tt">Thông tin truyện tranh</param>
        /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool SuaTruyenTranh(DTOTruyenTranh tt)
        {
            try
            {
                _conn.Open();
                byte[] dla;
                try
                {
                    FileStream fs = new FileStream(tt.Anh1, FileMode.Open, FileAccess.Read);
                    dla = new byte[fs.Length];
                    fs.Read(dla, 0, Convert.ToInt32(fs.Length));
                }
                catch
                {
                    dla = Convert.FromBase64String(tt.Anh1);
                }

                SqlParameter imgdata = new SqlParameter("@imgdata", SqlDbType.VarBinary, -1);
                imgdata.Value = dla;
                string querry = $"update TruyenTranh set Anh = @imgdata, TenTruyen = N'{tt.TenTruyen1}', MaBT = '{tt.MaBT1}', DinhDang = N'{tt.DinhDang1}', SoLuong = {tt.SoLuong1}, GiaTien = {tt.GiaTien1} where MaTT = '{tt.MaTT1}'";
                SqlCommand cmd = new SqlCommand(querry, _conn);
                cmd.Parameters.Add(imgdata);

                if (cmd.ExecuteNonQuery() > 0) { return true; }
        }
            catch (SqlException sql)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        /// <summary>
        /// Phương thức xóa thông tin của một truyện tranh
        /// </summary>
        /// <param name="ma">Mã truyện tranh</param>
        /// <returns>Trả về true nếu xóa thành công, ngược lại trả về false</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public bool XoaTruyenTranh(string ma)
        {
            return ex.ReturnBool($"delete  from TruyenTranh where matt = '{ma}'");
        }
        /// <summary>
        /// Phương thức lấy danh sách truyện tranh có tên tương ứng
        /// </summary>
        /// <param name="ten">Tên truyện tranh</param>
        /// <returns>Danh sách truyện tranh có tên tương ứng với tên cần tìm</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TimKiemTruyenTranh(string ten)
        {
            return ex.ReturnTable($"select matt as [Mã truyện tranh], anh as [Ảnh], tentruyen as [Tên truyện], mabt as [Mã bộ truyện], dinhdang as [Định dạng], soluong as [Số lượng], giatien as [Giá tiền] from TruyenTranh where MaTT='{ten}'");
        }
        /// <summary>
        /// Phương thức tạo mã tự động cho truyện tranh
        /// </summary>
        /// <returns>Mã truyện tranh mới cho lần nhập tiếp theo</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaTT", "TruyenTranh", 3, "TT0");
        }
        /// <summary>
        /// Phương thức lấy số lượng truyện tranh hiện tại
        /// </summary>
        /// <param name="ma">Mã truyện tranh</param>
        /// <returns>Số lượng truyện hiện tại</returns>
        /// Created by Nguyễn Minh Hiền – 05/04/2024
        public string LaySoLuongTruyen(string ma)
        {
            return ex.ReturnValue($"select soluong from truyentranh where MaTT = '{ma}'");
        }
    }
}
