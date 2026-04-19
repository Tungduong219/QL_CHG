using BTL_QLCHG.Utils;
using System;
using System.Data.SqlClient;

namespace BTL_QLCHG.DataAccess
{
    /// <summary>
    /// Chứa thông tin nhân viên trả về sau khi đăng nhập thành công.
    /// </summary>
    public class NhanVienInfo
    {
        public string MaNV  { get; set; }
        public string TenNV { get; set; }
        public string Quyen { get; set; }
    }

    internal class NhanVienDAL
    {
        /// <summary>
        /// Kiểm tra đăng nhập. Trả về NhanVienInfo nếu thành công, null nếu sai tài khoản/mật khẩu.
        /// </summary>
        public NhanVienInfo KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            string query = @"SELECT sMaNV, sTenNV, sQuyen 
                             FROM tblNhanVien 
                             WHERE sTaiKhoan = @TaiKhoan AND sMatKhau = @MatKhau";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new NhanVienInfo
                                {
                                    MaNV  = reader["sMaNV"].ToString(),
                                    TenNV = reader["sTenNV"].ToString(),
                                    Quyen = reader["sQuyen"].ToString()
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi kiểm tra đăng nhập: " + ex.Message);
                    }
                }
            }
            return null; // Sai tài khoản / mật khẩu
        }
    }
}
