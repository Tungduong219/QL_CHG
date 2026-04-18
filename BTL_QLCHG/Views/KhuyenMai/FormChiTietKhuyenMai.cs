using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QLCHG.Utils; // Khai báo để dùng DatabaseHelper

namespace BTL_QLCHG.Views
{
    public partial class FormChiTietKhuyenMai : Form
    {
        // 1. Đổi int? thành string
        private string maKMCu = null;
        private bool isSua = false;

        // Constructor THÊM MỚI
        public FormChiTietKhuyenMai()
        {
            InitializeComponent();
            this.Text = "THÊM KHUYẾN MÃI";

            this.btnLuu.Click += new EventHandler(btnLuu_Click);
            this.btnHuy.Click += new EventHandler(btnHuy_Click);

            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now.AddDays(30);
        }

        // Constructor SỬA - Đổi int sang string
        public FormChiTietKhuyenMai(string maKM)
        {
            InitializeComponent();
            this.maKMCu = maKM;
            this.Text = "SỬA KHUYẾN MÃI";
            isSua = true;

            this.btnLuu.Click += new EventHandler(btnLuu_Click);
            this.btnHuy.Click += new EventHandler(btnHuy_Click);

            LoadKhuyenMai();
        }

        private void LoadKhuyenMai()
        {
            // 2. Dùng chung DatabaseHelper
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                // 3. Sửa tên bảng và tên cột
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblKhuyenMai WHERE sMaKM = @MaKM", conn);
                cmd.Parameters.AddWithValue("@MaKM", maKMCu);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtMaKM.Text = reader["sMaKM"].ToString();
                        txtTenKM.Text = reader["sTenChuongTrinh"].ToString(); 
                        dtpNgayBatDau.Value = Convert.ToDateTime(reader["dNgayBatDau"]);
                        dtpNgayKetThuc.Value = Convert.ToDateTime(reader["dNgayKetThuc"]);
                        txtGiamGia.Text = reader["iPhanTramGiam"].ToString();
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKM.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khuyến mãi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKM.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenKM.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khuyến mãi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKM.Focus();
                return;
            }

            if (dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKetThuc.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiamGia.Text, out decimal giamGia) || giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Giảm giá phải từ 0% đến 100%!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamGia.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    if (isSua)
                    {
                        string queryUpdate = @"UPDATE tblKhuyenMai SET 
                 sMaKM = @MaKM,
                 sTenChuongTrinh = @TenChuongTrinh, 
                 dNgayBatDau = @NgayBatDau, 
                 dNgayKetThuc = @NgayKetThuc, 
                 iPhanTramGiam = @PhanTramGiam,
                 fSoTienGiamToiDa = 0 
                 WHERE sMaKM = @MaKMCu";
                        SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                        cmdUpdate.Parameters.AddWithValue("@MaKM", txtMaKM.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@MaKMCu", maKMCu);
                        cmdUpdate.Parameters.AddWithValue("@TenChuongTrinh", txtTenKM.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@NgayBatDau", dtpNgayBatDau.Value);
                        cmdUpdate.Parameters.AddWithValue("@NgayKetThuc", dtpNgayKetThuc.Value);
                        cmdUpdate.Parameters.AddWithValue("@PhanTramGiam", int.TryParse(txtGiamGia.Text, out int giam) ? giam : 0);
                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblKhuyenMai WHERE sMaKM = @MaKM", conn);
                        checkCmd.Parameters.AddWithValue("@MaKM", txtMaKM.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Mã khuyến mãi đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string queryInsert = @"INSERT INTO tblKhuyenMai (sMaKM, sTenChuongTrinh, dNgayBatDau, dNgayKetThuc, iPhanTramGiam, fSoTienGiamToiDa) 
                 VALUES (@MaKM, @TenChuongTrinh, @NgayBatDau, @NgayKetThuc, @PhanTramGiam, 0)";
                        SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                        cmdInsert.Parameters.AddWithValue("@MaKM", txtMaKM.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@TenChuongTrinh", txtTenKM.Text.Trim());
                        // BỎ DÒNG NÀY: cmdInsert.Parameters.AddWithValue("@MoTa", txtMoTa.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@NgayBatDau", dtpNgayBatDau.Value);
                        cmdInsert.Parameters.AddWithValue("@NgayKetThuc", dtpNgayKetThuc.Value);
                        cmdInsert.Parameters.AddWithValue("@PhanTramGiam", int.TryParse(txtGiamGia.Text, out int giamMoi) ? giamMoi : 0);
                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        // GIỮ LẠI CÁC METHOD CŨ ĐỂ TRÁNH LỖI DESIGNER
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void lblNgayBatDau_Click(object sender, EventArgs e) { }
        private void lblChiTietKhuyenMai_Click(object sender, EventArgs e) { }
        private void txtMoTa_TextChanged(object sender, EventArgs e) { }
    }
}