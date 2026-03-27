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
using BTL_QLCHG.Views.KhachHang;
namespace BTL_QLCHG.Views.KhachHang
{
    public partial class TongKhachHang : Form
    {
        public TongKhachHang()
        {
            InitializeComponent();
            dgvKhachHang.Columns.Clear();
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colMaKH",
                HeaderText = "Mã KH",
                DataPropertyName = "sMaKH",
                Width = 90
            });

            dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "colTenKH", HeaderText = "Tên KH", DataPropertyName = "sTenKH", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "colSDT", HeaderText = "Số Điện Thoại", DataPropertyName = "sDienThoai", Width = 120 });

            dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "colEmail", HeaderText = "Email", DataPropertyName = "sEmail", Width = 150 });

            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
            btnSua.Name = "colSua";
            btnSua.HeaderText = "Sửa";
            btnSua.Text = "Sửa"; // Chữ hiện trên nút
            btnSua.UseColumnTextForButtonValue = true; // Ép tất cả các dòng đều hiện chữ "Sửa"
            btnSua.Width = 60;
            dgvKhachHang.Columns.Add(btnSua);

            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            btnXoa.Name = "colXoa";
            btnXoa.HeaderText = "Xóa";
            btnXoa.Text = "Xóa";
            btnXoa.UseColumnTextForButtonValue = true;
            btnXoa.Width = 60;
            dgvKhachHang.Columns.Add(btnXoa);

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string maKH = dgvKhachHang.Rows[e.RowIndex].Cells["colMaKH"].Value.ToString();

            // 1. NẾU BẤM VÀO NÚT XÓA (Đã sửa lại thành colXoa)
            if (dgvKhachHang.Columns[e.ColumnIndex].Name == "colXoa")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = DatabaseHelper.GetConnection())
                    {
                        try
                        {
                            if (connection.State == ConnectionState.Closed)
                                connection.Open();
                            string deleteQuery = "DELETE FROM tblKhachHang WHERE sMaKH = @MaKH";
                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@MaKH", maKH);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDanhSachKhachHang(); // Tải lại danh sách sau khi xóa
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy khách hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa khách hàng (Có thể do dính khóa ngoại): " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            // 2. NẾU BẤM VÀO NÚT SỬA (Đã tách ra độc lập, không bị kẹt trong nút Xóa nữa)
            else if (dgvKhachHang.Columns[e.ColumnIndex].Name == "colSua")
            {
                FormSuaKhachHang suaForm = new FormSuaKhachHang(maKH);
                if (suaForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachKhachHang(); // Tải lại danh sách sau khi form Sửa tắt đi
                }
            }
        }

        private void LoadDanhSachKhachHang()
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "SELECT sMaKH, sTenKH, sDienThoai, sEmail, sGioiTinh, dNgaySinh, sDiaChi FROM tblKhachHang";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgvKhachHang.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void TongKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
            cboPhanLoai.Items.Clear();
            cboPhanLoai.Items.AddRange(new String[] { "Tất cả", "Nam", "Nữ", "Không rõ" });
            cboPhanLoai.SelectedIndex = 0;

            cboSapXep.Items.Clear();
            cboSapXep.Items.AddRange(new String[] { "Mặc định", "Tên A-Z", "Tên Z-A" });
            cboSapXep.SelectedIndex = 0;
        }

        private void btnThemKhachMoi_Click(object sender, EventArgs e)
        {
            FormThemKhachHang themForm = new FormThemKhachHang();
            themForm.ShowDialog();
            LoadDanhSachKhachHang();
        }

        private void XuLyLocVaSapXep()
        {
            // Đảm bảo dữ liệu trên lưới là dạng DataTable thì mới lọc được
            if (dgvKhachHang.DataSource is DataTable dt)
            {
                // Tạo một cái "giỏ" để đựng các điều kiện lọc
                List<string> cacDieuKienLoc = new List<string>();
                string sapXep = "";

                // ==========================================
                // 1. ĐIỀU KIỆN TỪ COMBOBOX PHÂN LOẠI
                // ==========================================
                string luaChonLoc = cboPhanLoai.SelectedItem?.ToString();
                if (luaChonLoc != "Tất cả" && !string.IsNullOrEmpty(luaChonLoc))
                {
                    cacDieuKienLoc.Add($"sGioiTinh = '{luaChonLoc}'");
                }

                // ==========================================
                // 2. ĐIỀU KIỆN TỪ Ô TÌM KIẾM (TextBox)
                // ==========================================
                // Giả sử ô TextBox tìm kiếm của bạn tên là txtTimKiem
                string tuKhoa = txtTimKiem.Text.Trim();

                // Bỏ qua nếu ô tìm kiếm trống, hoặc đang chứa cái chữ mờ (Placeholder)
                if (!string.IsNullOrEmpty(tuKhoa) && tuKhoa != "Tìm tên, SĐT, Email...")
                {
                    // Tìm kiếm tương đối (LIKE) trên 3 cột: Tên, SĐT, Email
                    // Dấu % đại diện cho các ký tự bất kỳ (giống như search Google)
                    string dieuKienTimKiem = $"(sTenKH LIKE '%{tuKhoa}%' OR sDienThoai LIKE '%{tuKhoa}%' OR sEmail LIKE '%{tuKhoa}%')";
                    cacDieuKienLoc.Add(dieuKienTimKiem);
                }

                // ==========================================
                // 3. XỬ LÝ SẮP XẾP (Giữ nguyên)
                // ==========================================
                string luaChonSapXep = cboSapXep.SelectedItem?.ToString();
                if (luaChonSapXep == "Tên A -> Z")
                {
                    sapXep = "sTenKH ASC";
                }
                else if (luaChonSapXep == "Tên Z -> A")
                {
                    sapXep = "sTenKH DESC";
                }
                else
                {
                    sapXep = "sMaKH DESC"; // Mới nhất lên đầu
                }

                // ==========================================
                // 4. GỘP CHUNG VÀ ÁP DỤNG VÀO LƯỚI
                // ==========================================
                // Lấy tất cả điều kiện trong "giỏ" nối lại với nhau bằng chữ " AND "
                string boLocCuoiCung = string.Join(" AND ", cacDieuKienLoc);

                // Đổ bộ lọc và sắp xếp vào DataView
                dt.DefaultView.RowFilter = boLocCuoiCung;
                dt.DefaultView.Sort = sapXep;
            }
        }
        private void cboPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            XuLyLocVaSapXep();
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            XuLyLocVaSapXep();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            XuLyLocVaSapXep();
        }
    }
}
