using BTL_QLCHG.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_QLCHG.Views // Hiếu nhớ giữ nguyên namespace của bạn nhé
{
    public partial class FormThemKhachHang : Form
    {
        public FormThemKhachHang()
        {
            InitializeComponent();
            cboGioiTinh.Items.Clear(); // Xóa sạch dữ liệu cũ (nếu có)
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Không rõ");

            // Đặt mặc định khi vừa mở form lên sẽ tự chọn "Không rõ" (nằm ở vị trí số 2 trong danh sách 0-1-2)
            cboGioiTinh.SelectedIndex = 2;

            // 1. CÀI ĐẶT SỰ KIỆN CHO CHỮ MỜ (PLACEHOLDER)
            // (Lưu ý: Bạn phải chắc chắn đã gõ chữ "Số điện thoại", "Email", "Địa chỉ" vào thuộc tính Tag của các TextBox này trong bảng Properties nhé)
            txtSDT.Enter += RemovePlaceholder;
            txtSDT.Leave += SetPlaceholder;

            txtEmail.Enter += RemovePlaceholder;
            txtEmail.Leave += SetPlaceholder;

            txtDiaChi.Enter += RemovePlaceholder;
            txtDiaChi.Leave += SetPlaceholder;

            // 2. MÀU MẶC ĐỊNH KHI BẬT FORM
            txtSDT.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtDiaChi.ForeColor = Color.Gray;

            // 3. CÀI ĐẶT CHO Ô NGÀY SINH (Cho phép để trống)
            dtpNgaySinh.ShowCheckBox = true;
            dtpNgaySinh.Checked = false; // Mặc định là không tick (không nhập ngày sinh)

            // Focus tạm vào 1 lable để tránh nháy chuột vào ô nhập ngay khi mở Form
            lblPageTitle.Focus(); // Thay bằng tên Label tiêu đề của bạn
        }

        #region XỬ LÝ GIAO DIỆN (CHỮ MỜ)
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag != null && txt.Text == txt.Tag.ToString())
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag != null && string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = txt.Tag.ToString();
                txt.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region XỬ LÝ LƯU DATABASE
        // Sự kiện khi bấm nút Lưu khách hàng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. RÀNG BUỘC DỮ LIỆU (Validation)
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            // 2. GOM DỮ LIỆU
            string maKH = "KH" + DateTime.Now.ToString("ddHHmmss"); // Tạo mã tự động: KH + ngày giờ
            string tenKH = txtTenKH.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem != null ? cboGioiTinh.SelectedItem.ToString() : "Không rõ";

            // Nếu ô Text đang chứa đúng cái chữ mờ trong Tag thì coi như là rỗng ("")
            string sdt = (txtSDT.Text.Trim() == txtSDT.Tag?.ToString()) ? "" : txtSDT.Text.Trim();
            string email = (txtEmail.Text.Trim() == txtEmail.Tag?.ToString()) ? "" : txtEmail.Text.Trim();
            string diaChi = (txtDiaChi.Text.Trim() == txtDiaChi.Tag?.ToString()) ? "" : txtDiaChi.Text.Trim();

            // 3. KẾT NỐI VÀ ĐẨY LÊN SQL SERVER
            using (SqlConnection conn = DatabaseHelper.GetConnection()) // Gọi class kết nối của bạn
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // CÂU LỆNH INSERT (Hiếu nhớ check lại tên cột cho khớp SQL của bạn)
                    string query = @"INSERT INTO tblKhachHang (sMaKH, sTenKH, sDienThoai, sGioiTinh, sEmail, dNgaySinh, sDiaChi) 
                                     VALUES (@MaKH, @TenKH, @SDT, @GioiTinh, @Email, @NgaySinh, @DiaChi)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Các trường bắt buộc
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.Parameters.AddWithValue("@TenKH", tenKH);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                        // Các trường tùy chọn: Có chữ thì lưu chữ, không có thì lưu NULL
                        cmd.Parameters.AddWithValue("@SDT", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi);

                        // Ngày sinh: Kiểm tra xem có tick chọn không
                        if (dtpNgaySinh.Checked)
                        {
                            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NgaySinh", DBNull.Value); // Lưu NULL
                        }

                        // Thực thi lệnh
                        cmd.ExecuteNonQuery();
                    }

                    // 4. BÁO CÁO THÀNH CÔNG VÀ ĐÓNG FORM
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gửi tín hiệu OK ra cho Form bên ngoài biết là đã thêm xong
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện khi bấm nút Hủy bỏ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form luôn không làm gì cả
        }
        #endregion
        private void ResetForm()
        {
            // 1. Xóa trắng ô Tên khách hàng
            txtTenKH.Text = "";

            // 2. Trả lại chữ mờ (Placeholder) cho SĐT, Email, Địa chỉ
            txtSDT.Text = txtSDT.Tag?.ToString();
            txtSDT.ForeColor = Color.Gray;

            txtEmail.Text = txtEmail.Tag?.ToString();
            txtEmail.ForeColor = Color.Gray;

            txtDiaChi.Text = txtDiaChi.Tag?.ToString();
            txtDiaChi.ForeColor = Color.Gray;

            // 3. Khôi phục trạng thái mặc định cho ComboBox và Lịch
            if (cboGioiTinh.Items.Count > 2)
            {
                cboGioiTinh.SelectedIndex = 2; // Trở về "Không rõ"
            }
            dtpNgaySinh.Checked = false; // Bỏ tick ngày sinh

            // 4. Nháy con trỏ chuột sẵn vào ô Tên để thu ngân gõ luôn khách mới
            txtTenKH.Focus();
        }
    }
}
