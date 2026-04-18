using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_QLCHG.Utils; // THÊM DÒNG NÀY ĐỂ DÙNG DATABASEHELPER

namespace BTL_QLCHG.Views
{
    public partial class FormKhuyenMai : Form
    {
        // ĐÃ XÓA dòng connectionString cũ

        public FormKhuyenMai()
        {
            InitializeComponent();

            this.btnTim.Click += new EventHandler(btnTim_Click);
            this.btnLamMoi.Click += new EventHandler(btnLamMoi_Click);
            this.btnThem.Click += new EventHandler(btnThem_Click);
            this.btnSua.Click += new EventHandler(btnSua_Click);
            this.btnXoa.Click += new EventHandler(btnXoa_Click);

            LoadKhuyenMai();
        }

        // 1. TẢI DỮ LIỆU
        private void LoadKhuyenMai(string timKiem = "")
        {
            try
            {
                // Dùng DatabaseHelper
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // Cập nhật tên bảng và thêm tiền tố cột (s, d, f)
                    string query = "SELECT sMaKM, sTenChuongTrinh, dNgayBatDau, dNgayKetThuc, iPhanTramGiam, fSoTienGiamToiDa FROM tblKhuyenMai";

                    if (!string.IsNullOrWhiteSpace(timKiem))
                    {
                        query += " WHERE sMaKM LIKE @TimKiem OR sTenChuongTrinh LIKE @TimKiem";
                    }
                    query += " ORDER BY sMaKM";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(timKiem))
                        {
                            cmd.Parameters.AddWithValue("@TimKiem", "%" + timKiem + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvKhuyenMai.DataSource = dt;

                        // Cập nhật lại tên cột khi Format DataGridView
                        if (dgvKhuyenMai.Columns.Count > 0)
                        {
                            dgvKhuyenMai.Columns["sMaKM"].HeaderText = "Mã KM";
                            dgvKhuyenMai.Columns["sTenChuongTrinh"].HeaderText = "Tên chương trình";
                            dgvKhuyenMai.Columns["dNgayBatDau"].HeaderText = "Ngày bắt đầu";
                            dgvKhuyenMai.Columns["dNgayKetThuc"].HeaderText = "Ngày kết thúc";
                            dgvKhuyenMai.Columns["iPhanTramGiam"].HeaderText = "Giảm giá (%)";
                            dgvKhuyenMai.Columns["fSoTienGiamToiDa"].HeaderText = "Giảm tối đa (VNĐ)";
                        }

                        lblTongSo.Text = $"Tổng số: {dt.Rows.Count} khuyến mãi";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. TÌM KIẾM
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadKhuyenMai(txtTimKiem.Text.Trim());
        }

        // 3. LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadKhuyenMai();
        }

        // 4. THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormChiTietKhuyenMai formThem = new FormChiTietKhuyenMai();
            if (formThem.ShowDialog() == DialogResult.OK)
            {
                LoadKhuyenMai();
            }
        }

        // 5. SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhuyenMai.SelectedRows.Count > 0)
            {
                // Sửa thành kiểu string
                string maKM = dgvKhuyenMai.SelectedRows[0].Cells["sMaKM"].Value.ToString();

                FormChiTietKhuyenMai formSua = new FormChiTietKhuyenMai(maKM);
                if (formSua.ShowDialog() == DialogResult.OK)
                {
                    LoadKhuyenMai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 6. XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhuyenMai.SelectedRows.Count > 0)
            {
                // Sửa thành kiểu string
                string maKM = dgvKhuyenMai.SelectedRows[0].Cells["sMaKM"].Value.ToString();
                string tenKM = dgvKhuyenMai.SelectedRows[0].Cells["sTenKM"].Value.ToString();

                DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa khuyến mãi '{tenKM}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = DatabaseHelper.GetConnection())
                        {
                            if (conn.State == ConnectionState.Closed) conn.Open();

                            // Cập nhật tên bảng và tên cột
                            SqlCommand cmd = new SqlCommand("DELETE FROM tblKhuyenMai WHERE sMaKM = @MaKM", conn);
                            cmd.Parameters.AddWithValue("@MaKM", maKM);
                            cmd.ExecuteNonQuery();
                        }
                        LoadKhuyenMai();
                        MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // CÁC SỰ KIỆN CŨ GIỮ LẠI (TRỐNG)
        private void button1_Click(object sender, EventArgs e) { }
        private void lblTongSo_Click(object sender, EventArgs e) { }
    }
}