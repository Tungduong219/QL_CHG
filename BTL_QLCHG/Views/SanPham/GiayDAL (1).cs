using System;
using System.Data;

namespace BTL_QLCHG.Views.SanPham
{
    public class GiayDAL
    {
        // Đối tượng kết nối database dùng chung cho tất cả các hàm
        private readonly SQLHelper db = new SQLHelper();

        // ============================================================
        // 1. CÁC HÀM CHO FORM SẢN PHẨM & THÊM SẢN PHẨM (Hết lỗi image_15cc80)
        // ============================================================

        public DataTable LayDSKho()
        {
            return db.GetTable("SELECT * FROM tblKhoGiay");
        }

        public DataTable TimKiem(string sku)
        {
            return db.GetTable($"SELECT * FROM tblKhoGiay WHERE sMaSKU LIKE '%{sku}%'");
        }

        // Hàm này giúp hết lỗi gạch đỏ tại FormThemSanPham.cs dòng 41
        public void ThemGiay(string sku, string maMau, int sl, string size, string maMauSac)
        {
            string sql = $"INSERT INTO tblKhoGiay (sMaSKU, sMaMau, iSoLuong, sMaSize, sMaMauSac) " +
                         $"VALUES ('{sku}', '{maMau}', {sl}, '{size}', '{maMauSac}')";
            db.ExecuteNonQuery(sql);
        }

        // ============================================================
        // 2. CÁC HÀM CHO FORM THUỘC TÍNH (Hết lỗi image_140932)
        // ============================================================

        // Lấy danh sách Size (Hết lỗi CS1061 tại FormThuocTinh dòng 27)
        public DataTable LayDSSize()
        {
            return db.GetTable("SELECT * FROM tblKichThuoc");
        }

        // Lấy danh sách Màu (Hết lỗi CS1061 tại FormThuocTinh dòng 33)
        public DataTable LayDSMau()
        {
            return db.GetTable("SELECT * FROM tblMauSac");
        }

        public void ThemSize(string ma, string giaTri)
        {
            if (!int.TryParse(giaTri, out int val)) val = 0;
            string sql = $"INSERT INTO tblKichThuoc (sMaSize, iGiaTriSize) VALUES ('{ma}', {val})";
            db.ExecuteNonQuery(sql);
        }

        public void ThemMau(string ma, string ten)
        {
            string sql = $"INSERT INTO tblMauSac (sMaMauSac, sTenMau) VALUES ('{ma}', N'{ten}')";
            db.ExecuteNonQuery(sql);
        }

        public void XoaSize(string ma)
        {
            // Xóa ràng buộc khóa ngoại trước khi xóa bảng gốc
            db.ExecuteNonQuery($"DELETE FROM tblChiTietTra WHERE sMaSKU IN (SELECT sMaSKU FROM tblKhoGiay WHERE sMaSize = '{ma}')");
            db.ExecuteNonQuery($"DELETE FROM tblKhoGiay WHERE sMaSize = '{ma}'");
            db.ExecuteNonQuery($"DELETE FROM tblKichThuoc WHERE sMaSize = '{ma}'");
        }

        public void XoaMau(string ma)
        {
            db.ExecuteNonQuery($"DELETE FROM tblKhoGiay WHERE sMaMauSac = '{ma}'");
            db.ExecuteNonQuery($"DELETE FROM tblMauSac WHERE sMaMauSac = '{ma}'");
        }

        // Hàm bổ trợ nếu Form của bạn gọi riêng lẻ
        public void XoaKhoTheoSize(string maSize)
        {
            db.ExecuteNonQuery($"DELETE FROM tblKhoGiay WHERE sMaSize = '{maSize}'");
        }
    }
}