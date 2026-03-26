using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BTL_QLCHG.Utils
{
    public class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString; public static SqlConnection GetConnection()

        {
            return new SqlConnection(connectionString);
        }
    }
}
