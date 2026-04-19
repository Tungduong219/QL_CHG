using BTL_QLCHG.Utils;
using BTL_QLCHG.Views;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLCHG.Views.KhachHang
{
    public partial class TongKhachHang : Form
    {
        public TongKhachHang()
        {
            InitializeComponent();

            // Sự kiện tìm kiếm real-time
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            // Sự kiện nút Thêm khách hàng
            btnThemKhachMoi.Click += btnThemKhachMoi_Click;

            // Sự kiện click nút Sửa / Xóa trong bảng
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;

            this.Load += TongKhachHang_Load;
        }

        // ===================== LOAD DỮ LIỆU =====================
        private void TongKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
        }

        private void LoadDanhSachKhachHang(string tuKhoa = "")
        {
            string query = @"SELECT sMaKH, sTenKH, sDienThoai, sEmail
                             FROM tblKhachHang";

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                query += @" WHERE sTenKH LIKE @TuKhoa
                               OR sDienThoai LIKE @TuKhoa
                               OR sEmail LIKE @TuKhoa";
            }

            query += " ORDER BY sTenKH ASC";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(tuKhoa))
                            da.SelectCommand.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Xóa dữ liệu cũ và điền lại thủ công vào DataGridView
                        dgvKhachHang.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            dgvKhachHang.Rows.Add(
                                row["sMaKH"].ToString(),
                                row["sTenKH"].ToString(),
                                row["sDienThoai"] == DBNull.Value ? "" : row["sDienThoai"].ToString(),
                                row["sEmail"] == DBNull.Value ? "" : row["sEmail"].ToString()
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ===================== TÌM KIẾM =====================
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang(txtTimKiem.Text.Trim());
        }

        // ===================== THÊM KHÁCH HÀNG =====================
        private void btnThemKhachMoi_Click(object sender, EventArgs e)
        {
            ThemKhachHang frm = new ThemKhachHang();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachKhachHang(); // Reload lại bảng sau khi thêm thành công
            }
        }

        // ===================== SỬA / XÓA TRONG BẢNG =====================
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maKH = dgvKhachHang.Rows[e.RowIndex].Cells["colMaKH"].Value?.ToString();
            if (string.IsNullOrEmpty(maKH)) return;

            // Nút SỬA
            if (dgvKhachHang.Columns[e.ColumnIndex].Name == "colSua")
            {
                FormSuaKhachHang frm = new FormSuaKhachHang();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachKhachHang();
                }
            }

            // Nút XÓA
            if (dgvKhachHang.Columns[e.ColumnIndex].Name == "colXoa")
            {
                DialogResult xacNhan = MessageBox.Show(
                    "Bạn có chắc muốn xóa khách hàng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (xacNhan == DialogResult.Yes)
                {
                    XoaKhachHang(maKH);
                }
            }
        }

        private void XoaKhachHang(string maKH)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string query = "DELETE FROM tblKhachHang WHERE sMaKH = @MaKH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
