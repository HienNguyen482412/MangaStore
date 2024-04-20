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
    public class DAL_TruyenTranh : DBConnect
    {
        ExcuteQuerry ex = new ExcuteQuerry();
        public DataTable LayTruyenTranh()
        {
            return ex.ReturnTable($"select matt as [Mã truyện tranh], anh as [Ảnh], tentruyen as [Tên truyện], mabt as [Mã bộ truyện], dinhdang as [Định dạng], soluong as [Số lượng], giatien as [Giá tiền] from TruyenTranh");
        }
        public bool ThemTruyenTranh(DTO_TruyenTranh tt)
        {
            try
            {
                _conn.Open();
                byte[] dla;
                FileStream fs = new FileStream(tt.TRUYENTRANH_ANH, FileMode.Open, FileAccess.Read);
                dla = new byte[fs.Length];
                fs.Read(dla, 0, Convert.ToInt32(fs.Length));
                SqlParameter imgdata = new SqlParameter("@imgdata", SqlDbType.VarBinary, -1);
                imgdata.Value = dla;
                string querry = $"insert into TruyenTranh values ('{tt.TRUYENTRANH_MATT}',@imgdata, N'{tt.TRUYENTRANH_TENTRUYEN}','{tt.TRUYENTRANH_MABT}', N'{tt.TRUYENTRANH_DINHDANG}',{tt.TRUYENTRANH_SOLUONG},{tt.TRUYENTRANH_GIATIEN})";
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
        public bool SuaTruyenTranh(DTO_TruyenTranh tt)
        {
            try
            {
                _conn.Open();
                byte[] dla;
                try
                {
                    FileStream fs = new FileStream(tt.TRUYENTRANH_ANH, FileMode.Open, FileAccess.Read);
                    dla = new byte[fs.Length];
                    fs.Read(dla, 0, Convert.ToInt32(fs.Length));
                }
                catch
                {
                    dla = Convert.FromBase64String(tt.TRUYENTRANH_ANH);
                }

                SqlParameter imgdata = new SqlParameter("@imgdata", SqlDbType.VarBinary, -1);
                imgdata.Value = dla;
                string querry = $"update TruyenTranh set Anh = @imgdata, TenTruyen = N'{tt.TRUYENTRANH_TENTRUYEN}', MaBT = '{tt.TRUYENTRANH_MABT}', DinhDang = N'{tt.TRUYENTRANH_DINHDANG}', SoLuong = {tt.TRUYENTRANH_SOLUONG}, GiaTien = {tt.TRUYENTRANH_GIATIEN} where MaTT = '{tt.TRUYENTRANH_MATT}'";
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
        public bool XoaTruyenTranh(string ma)
        {
            return ex.ReturnBool($"delete  from TruyenTranh where matt = '{ma}'");
        }
        public DataTable TimKiemTruyenTranh(string ten)
        {
            return ex.ReturnTable($"select matt as [Mã truyện tranh], anh as [Ảnh], tentruyen as [Tên truyện], mabt as [Mã bộ truyện], dinhdang as [Định dạng], soluong as [Số lượng], giatien as [Giá tiền] from TruyenTranh where MaTT='{ten}'");
        }
        public DataTable TaoMa()
        {
            return ex.AutoCreateID("MaTT", "TruyenTranh", 3, "TT0");
        }
        public string LaySoLuongTruyen(string ma)
        {
            return ex.ReturnValue($"select soluong from truyentranh where MaTT = '{ma}'");
        }
    }
}
