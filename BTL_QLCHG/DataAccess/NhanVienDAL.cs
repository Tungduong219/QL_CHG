using BTL_QLCHG.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLCHG.DataAccess
{
    internal class NhanVienDAL
    {
        public bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            bool hopLe = false;

            string query = "SELECT COUNT(*) FROM tblNhanVien WHERE sTaiKhoan = @TaiKhoan AND sMatKhau = @MatKhau";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
               using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        hopLe = count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi kiểm tra đăng nhập: " + ex.Message);
                    }
                }
            }
            return hopLe;
        }
    }
}
