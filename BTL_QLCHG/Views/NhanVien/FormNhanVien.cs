using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLCHG.Views
{
    public partial class FormNhanVien : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;

        public FormNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();

            // GÁN SỰ KIỆN CLICK CHO CÁC NÚT
            this.btnTim.Click += new EventHandler(btnTim_Click);
            this.btnLamMoi.Click += new EventHandler(btnLamMoi_Click);
            this.btnThem.Click += new EventHandler(btnThem_Click);
            this.btnSua.Click += new EventHandler(btnSua_Click);
            this.btnXoa.Click += new EventHandler(btnXoa_Click);
        }

        // 1. LOAD DANH SÁCH NHÂN VIÊN
        private void LoadNhanVien(string timKiem = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // KIỂM TRA KẾT NỐI
                    string dbName = conn.Database;
                    Console.WriteLine("Đang kết nối database: " + dbName);

                    string query = "SELECT sMaNV, sTenNV, sGioiTinh, dNgayVaoLam, fLuongCoBan, sTaiKhoan, sQuyen FROM tblNhanVien";

                    if (!string.IsNullOrWhiteSpace(timKiem))
                    {
                        query += " WHERE sTenNV LIKE @TimKiem OR sTaiKhoan LIKE @TimKiem";
                    }
                    query += " ORDER BY sMaNV";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(timKiem))
                    {
                        cmd.Parameters.AddWithValue("@TimKiem", "%" + timKiem + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // KIỂM TRA SỐ LƯỢNG DỮ LIỆU
                    if (dt.Rows.Count == 0)
                    {
                        lblTongSo.Text = "Tổng số: 0 nhân viên (Chưa có dữ liệu)";
                    }
                    else
                    {
                        lblTongSo.Text = $"Tổng số: {dt.Rows.Count} nhân viên";
                    }

                    dgvNhanVien.DataSource = dt;
                    conn.Close();

                    // Đặt tên cột tiếng Việt
                    if (dgvNhanVien.Columns.Count > 0)
                    {
                        dgvNhanVien.Columns["sMaNV"].HeaderText = "Mã NV";
                        dgvNhanVien.Columns["sTenNV"].HeaderText = "Tên nhân viên";
                        dgvNhanVien.Columns["sGioiTinh"].HeaderText = "Giới tính";
                        dgvNhanVien.Columns["dNgayVaoLam"].HeaderText = "Ngày vào làm";
                        dgvNhanVien.Columns["fLuongCoBan"].HeaderText = "Lương";
                        dgvNhanVien.Columns["sTaiKhoan"].HeaderText = "Tài khoản";
                        dgvNhanVien.Columns["sQuyen"].HeaderText = "Quyền";

                        // Định dạng cột lương
                        dgvNhanVien.Columns["fLuongCoBan"].DefaultCellStyle.Format = "N0";
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message + "\n\nKiểm tra lại:\n1. SQL Server đã bật chưa?\n2. Database có tồn tại không?\n3. Bảng NhanVien đã được tạo chưa?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. NÚT TÌM KIẾM
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadNhanVien(txtTimKiem.Text.Trim());
        }

        // 3. NÚT LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadNhanVien();
        }

        // 4. NÚT THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormChiTietNhanVien formThem = new FormChiTietNhanVien();
            if (formThem.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVien();
            }
        }

        // 5. NÚT SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                String maNV = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells["sMaNV"].Value);
                FormChiTietNhanVien formSua = new FormChiTietNhanVien(maNV);
                if (formSua.ShowDialog() == DialogResult.OK)
                {
                    LoadNhanVien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 6. NÚT XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                String maNV = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells["sMaNV"].Value);
                string tenNV = dgvNhanVien.SelectedRows[0].Cells["sTenNV"].Value.ToString();

                DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên '{tenNV}'?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM tblNhanVien WHERE sMaNV = @MaNV";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadNhanVien();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Các method cũ giữ lại để tránh lỗi
        private void label1_Click(object sender, EventArgs e) { }
        private void lblTimKiem_Click(object sender, EventArgs e) { }
        private void btnLamMoi_Click_1(object sender, EventArgs e) { }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }
    }
}