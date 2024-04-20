using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ExcuteQuerry : DBConnect
    {
        /// <summary>
        /// Hàm thực thi sql querry
        /// </summary>
        /// <param name="querry">câu truy vấn sql</param>
        /// <returns>datatable</returns>
        public DataTable ReturnTable(string querry)
        {
            SqlDataAdapter da = new SqlDataAdapter(querry, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Hàm thực thi sql querry
        /// </summary>
        /// <param name="querry">câu truy vấn sql</param>
        /// <returns>bool</returns>
        public bool ReturnBool(string querry)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(querry, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
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
        /// Hàm thực thi sql querry
        /// </summary>
        /// <param name="querry">câu truy vấn sql</param>
        /// <returns>string</returns>
        public string ReturnValue(string querry)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(querry, _conn);               
                return cmd.ExecuteScalar().ToString();
            }
            catch (SqlException e)
            {
                return "";
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable AutoCreateID(string tencot, string tenbang, int sokitu, string kitu)
        {
            SqlDataAdapter da = new SqlDataAdapter($"TaoMa", _conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@tencot", tencot));
            da.SelectCommand.Parameters.Add(new SqlParameter("@tenbang", tenbang));
            da.SelectCommand.Parameters.Add(new SqlParameter("@sokitu", sokitu));
            da.SelectCommand.Parameters.Add(new SqlParameter("@kitu", kitu));
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
