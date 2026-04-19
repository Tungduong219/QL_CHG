using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLCHG.Views
{
    public partial class FormChiTietNhanVien : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;
        private String maNVCu = null;  // Lưu mã NV cũ để cập nhật
        private bool isSua = false;

        // THÊM MỚI
        public FormChiTietNhanVien()
        {
            InitializeComponent();
            this.Text = "THÊM NHÂN VIÊN";

            // Thêm items cho ComboBox
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            cboQuyen.Items.Clear();
            cboQuyen.Items.AddRange(new string[] { "Admin", "Quản lý", "Nhân viên" });
            cboQuyen.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnLuu.Click += new EventHandler(btnLuu_Click);
            this.btnHuy.Click += new EventHandler(btnHuy_Click);
        }

        // SỬA
        public FormChiTietNhanVien(String maNV)
        {
            InitializeComponent();
            this.maNVCu = maNV;  // Lưu mã NV cũ
            this.Text = "SỬA NHÂN VIÊN";
            isSua = true;

            // Thêm items cho ComboBox
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            cboQuyen.Items.Clear();
            cboQuyen.Items.AddRange(new string[] { "Admin", "Quản lý", "Nhân viên" });
            cboQuyen.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnLuu.Click += new EventHandler(btnLuu_Click);
            this.btnHuy.Click += new EventHandler(btnHuy_Click);

            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblNhanVien WHERE sMaNV = @MaNV", conn);
                cmd.Parameters.AddWithValue("@MaNV", maNVCu);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaNV.Text = reader["sMaNV"].ToString();
                    txtTenNV.Text = reader["sTenNV"].ToString();
                    cboGioiTinh.Text = reader["sGioiTinh"].ToString();
                    dtpNgayVaoLam.Value = Convert.ToDateTime(reader["dNgayVaoLam"]);
                    txtLuong.Text = reader["fLuongCoBan"].ToString();
                    txtTaiKhoan.Text = reader["sTaiKhoan"].ToString();
                    txtMatKhau.Text = reader["sMatKhau"].ToString();
                    cboQuyen.Text = reader["sQuyen"].ToString();
                }
                conn.Close();
            }
        }

        // NÚT LƯU
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    if (isSua)
                    {
                        // CẬP NHẬT - DÙNG mã NV cũ để tìm bản ghi
                        string query = @"UPDATE tblNhanVien SET 
                                         sMaNV = @MaNV,
                                         sTenNV = @TenNV, 
                                         sGioiTinh = @GioiTinh, 
                                         dNgayVaoLam = @NgayVaoLam,
                                         fLuongCoBan = @LuongCoBan, 
                                         sTaiKhoan = @TaiKhoan, 
                                         sMatKhau = @MatKhau, 
                                         sQuyen = @Quyen 
                                         WHERE sMaNV = @MaNVCu";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@MaNVCu", maNVCu);  // Dùng mã cũ để tìm
                        cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@NgayVaoLam", dtpNgayVaoLam.Value);
                        cmd.Parameters.AddWithValue("@LuongCoBan", decimal.TryParse(txtLuong.Text, out decimal luong) ? luong : 0);
                        cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@Quyen", cboQuyen.Text);

                        int result = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại! Không tìm thấy nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // KIỂM TRA MÃ NV ĐÃ TỒN TẠI
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblNhanVien WHERE sMaNV = @MaNV", conn);
                        checkCmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại! Vui lòng nhập mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMaNV.Focus();
                            conn.Close();
                            return;
                        }

                        // THÊM MỚI
                        string query = @"INSERT INTO tblNhanVien (sMaNV, sTenNV, sGioiTinh, dNgayVaoLam, fLuongCoBan, sTaiKhoan, sMatKhau, sQuyen) 
                                         VALUES (@MaNV, @TenNV, @GioiTinh, @NgayVaoLam, @LuongCoBan, @TaiKhoan, @MatKhau, @Quyen)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@NgayVaoLam", dtpNgayVaoLam.Value);
                        cmd.Parameters.AddWithValue("@LuongCoBan", decimal.TryParse(txtLuong.Text, out decimal luong) ? luong : 0);
                        cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@Quyen", cboQuyen.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NÚT HỦY
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void cboQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}