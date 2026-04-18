using System.Data;
using System.Data.SqlClient;

public class SQLHelper
{
    // Thay đổi chuỗi kết nối cho đúng với máy của bạn
    private string strCon = @"Data Source=TUNGDUONG\SQLEXPRESS;Initial Catalog=QL_BanGiayHSK;Integrated Security=True;TrustServerCertificate=True";

    public DataTable GetTable(string sql)
    {
        using (SqlConnection con = new SqlConnection(strCon))
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }

    public void ExecuteNonQuery(string sql)
    {
        using (SqlConnection con = new SqlConnection(strCon))
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}