using System;

namespace BTL_QLCHG
{
    public static class ThongTinDangNhap
    {
        // Thông tin cơ bản
        public static string MaNhanVien { get; set; } = "";
        public static string TenNhanVien { get; set; } = "";

        // Quyền người dùng
        public static string Quyen { get; set; } = "";

        // Helper properties kiểm tra nhanh
        public static bool IsAdmin     => Quyen == "Admin";
        public static bool IsQuanLy   => Quyen == "Quản lý";
        public static bool IsNhanVien => Quyen == "Nhân viên";

        // Reset khi đăng xuất
        public static void DangXuat()
        {
            MaNhanVien  = "";
            TenNhanVien = "";
            Quyen       = "";
        }
    }
}