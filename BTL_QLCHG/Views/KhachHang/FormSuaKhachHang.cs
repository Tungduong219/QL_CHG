using BTL_QLCHG.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLCHG.Views.KhachHang
{
    public partial class FormSuaKhachHang : Form
    {
        // 1. Tạo một cái "túi" (biến toàn cục) để đựng mã khách hàng được truyền sang
        private string maKHDangSua;

        // 2. Sửa lại hàm này: Nhét thêm chữ (string maKH) vào trong ngoặc
        public FormSuaKhachHang(string maKH)
        {
            InitializeComponent();

            // 3. Cất cái mã vừa nhận được vào "túi" để lát nữa dùng đi tìm trong SQL
            this.maKHDangSua = maKH;

            // Đổi luôn tiêu đề Form cho chuẩn
            this.Text = "Cập nhật thông tin khách hàng: " + maKH;
        }

        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {
            // 1. Nạp sẵn 3 tùy chọn cho ComboBox Giới tính
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Không rõ");

            // 2. Đi tìm ông khách hàng này trong SQL
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string query = "SELECT * FROM tblKhachHang WHERE sMaKH = @MaKH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKHDangSua); // Dùng cái mã nhận được từ Form kia

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Nếu tìm thấy khách hàng
                            {
                                // Đổ dữ liệu ra các ô TextBox
                                txtTenKH.Text = reader["sTenKH"].ToString();

                                // Đổ SĐT, Email, Địa chỉ và đổi màu chữ thành màu Đen (để đè cái chữ mờ Placeholder đi)
                                if (reader["sDienThoai"] != DBNull.Value)
                                { txtSDT.Text = reader["sDienThoai"].ToString(); txtSDT.ForeColor = Color.Black; }

                                if (reader["sEmail"] != DBNull.Value)
                                { txtEmail.Text = reader["sEmail"].ToString(); txtEmail.ForeColor = Color.Black; }

                                if (reader["sDiaChi"] != DBNull.Value)
                                { txtDiaChi.Text = reader["sDiaChi"].ToString(); txtDiaChi.ForeColor = Color.Black; }

                                // Chọn lại Giới tính
                                string gioiTinh = reader["sGioiTinh"].ToString();
                                cboGioiTinh.SelectedItem = string.IsNullOrEmpty(gioiTinh) ? "Không rõ" : gioiTinh;

                                // Check lại Ngày sinh
                                if (reader["dNgaySinh"] != DBNull.Value)
                                {
                                    dtpNgaySinh.Value = Convert.ToDateTime(reader["dNgaySinh"]);
                                    dtpNgaySinh.Checked = true; // Bật tick xanh lên
                                }
                                else
                                {
                                    dtpNgaySinh.Checked = false; // Tắt tick xanh đi
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải thông tin cũ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Ràng buộc Tên không được để trống
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            // 2. Gom dữ liệu mới (Nhớ xử lý cả vụ chữ mờ Placeholder y như Form Thêm)
            string tenKH = txtTenKH.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem?.ToString() ?? "Không rõ";

            string sdt = (txtSDT.Text.Trim() == txtSDT.Tag?.ToString()) ? "" : txtSDT.Text.Trim();
            string email = (txtEmail.Text.Trim() == txtEmail.Tag?.ToString()) ? "" : txtEmail.Text.Trim();
            string diaChi = (txtDiaChi.Text.Trim() == txtDiaChi.Tag?.ToString()) ? "" : txtDiaChi.Text.Trim();

            // 3. Đẩy lệnh UPDATE xuống SQL Server
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // CÂU LỆNH UPDATE THAY VÌ INSERT
                    string query = @"UPDATE tblKhachHang 
                             SET sTenKH = @TenKH, sDienThoai = @SDT, sGioiTinh = @GioiTinh, 
                                 sEmail = @Email, dNgaySinh = @NgaySinh, sDiaChi = @DiaChi 
                             WHERE sMaKH = @MaKH";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKHDangSua); // Khóa chính để biết sửa ai
                        cmd.Parameters.AddWithValue("@TenKH", tenKH);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                        cmd.Parameters.AddWithValue("@SDT", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi);

                        if (dtpNgaySinh.Checked)
                            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                        else
                            cmd.Parameters.AddWithValue("@NgaySinh", DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gửi tín hiệu OK ra ngoài cho Form Danh Sách biết đường load lại lưới, rồi tự tắt
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
