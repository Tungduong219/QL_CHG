using System.Data;
using System.Data.SqlClient;

public class SQLHelper
{
    // Lấy chuỗi kết nối từ App.config thay vì hardcode
    private string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;

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