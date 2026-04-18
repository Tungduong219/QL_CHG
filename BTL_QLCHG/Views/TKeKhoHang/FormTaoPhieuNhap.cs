using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace TkeKhohang
{
    public partial class FormTaoPhieuNhap : Form
    {
        // Chuỗi kết nối SQL lấy từ App.config
        string strConnect = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;

        public FormTaoPhieuNhap()
        {
            InitializeComponent();

            // ÉP CHẠY DỮ LIỆU NGAY LẬP TỨC (Không phụ thuộc vào sự kiện Load của Form nữa)
            KhoiDongDuLieu();

            // Tự động gán sự kiện cho các nút bấm
            btnThemDong.Click += btnThemDong_Click;
            btnHoanThanh.Click += btnHoanThanh_Click;
        }

        // =========================================================================
        // PHẦN 1: KHỞI ĐỘNG VÀ BƠM DỮ LIỆU VÀO COMBOBOX
        // =========================================================================
        private void KhoiDongDuLieu()
        {
            // Tắt tự sinh cột thừa ở DataGridView
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.AllowUserToAddRows = false;

            // Bơm dữ liệu vào 3 ComboBox
            LoadDataToComboBox(cboNCC, "SELECT sMaNCC, sTenNCC FROM tblNhaCungCap", "sTenNCC", "sMaNCC");
            LoadDataToComboBox(cboNhanVien, "SELECT sMaNV, sTenNV FROM tblNhanVien", "sTenNV", "sMaNV");

            string sqlSKU = @"SELECT k.sMaSKU, (k.sMaSKU + ' - ' + m.sTenMau) AS TenHienThi 
                              FROM tblKhoGiay k INNER JOIN tblMauGiay m ON k.sMaMau = m.sMaMau";
            LoadDataToComboBox(cboSanPham, sqlSKU, "TenHienThi", "sMaSKU");

            // Mở khóa ô text và sinh mã phiếu nhập
            txtMaPN.ReadOnly = false;
            GenerateMaPN();
        }

        private void LoadDataToComboBox(ComboBox cbo, string sql, string display, string value)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbo.DataSource = dt;
                    cbo.DisplayMember = display;
                    cbo.ValueMember = value;
                    cbo.SelectedIndex = -1; // Mặc định để trống không chọn gì
                }
                catch (Exception ex)
                {
                    // NẾU SQL SAI TÊN CỘT HOẶC LỖI KẾT NỐI, NÓ SẼ BÁO RA ĐÂY!
                    MessageBox.Show($"Lỗi lấy dữ liệu cho {cbo.Name}:\n{ex.Message}", "Cảnh báo SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerateMaPN()
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblPhieuNhap", conn);
                    int count = (int)cmd.ExecuteScalar();
                    txtMaPN.Text = "PN" + (count + 1).ToString("D3");
                }
                catch
                {
                    txtMaPN.Text = "PN001"; // Lỗi hoặc bảng trống thì bắt đầu từ 001
                }
            }
        }

        // =========================================================================
        // PHẦN 2: XỬ LÝ NÚT "THÊM HÀNG" VÀ TÍNH TỔNG TIỀN
        // =========================================================================
        private void btnThemDong_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (cboSanPham.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn sản phẩm!"); return; }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out int sl) || sl <= 0) { MessageBox.Show("Số lượng phải là số dương!"); return; }
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) || !decimal.TryParse(txtDonGia.Text, out decimal dg) || dg <= 0) { MessageBox.Show("Đơn giá phải là số dương!"); return; }

            string maSKU = cboSanPham.SelectedValue.ToString();
            decimal thanhTien = sl * dg;

            // Tìm chi tiết Sản phẩm (Tên, Size, Màu)
            string tenSP = "", size = "", mau = "";
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                try
                {
                    string sql = @"SELECT m.sTenMau, sz.iGiaTriSize, ms.sTenMau as MauSac 
                                   FROM tblKhoGiay k 
                                   INNER JOIN tblMauGiay m ON k.sMaMau = m.sMaMau 
                                   INNER JOIN tblKichThuoc sz ON k.sMaSize = sz.sMaSize 
                                   INNER JOIN tblMauSac ms ON k.sMaMauSac = ms.sMaMauSac 
                                   WHERE k.sMaSKU = @sku";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@sku", maSKU);
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        tenSP = rd["sTenMau"].ToString();
                        size = rd["iGiaTriSize"].ToString();
                        mau = rd["MauSac"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy thông tin sản phẩm: " + ex.Message);
                    return;
                }
            }

            // Kiểm tra mã đã có trong lưới chưa
            bool daTonTai = false;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == maSKU) // Cột 1 là Mã SKU
                {
                    int slCu = Convert.ToInt32(row.Cells[5].Value); // Cột 5 là Số lượng
                    decimal tienCu = Convert.ToDecimal(row.Cells[7].Value); // Cột 7 là Thành tiền

                    row.Cells[5].Value = slCu + sl;
                    row.Cells[7].Value = tienCu + thanhTien;
                    daTonTai = true;
                    break;
                }
            }

            // Nếu chưa có thì thêm dòng mới
            if (!daTonTai)
            {
                int stt = dgvChiTiet.Rows.Count + 1;
                dgvChiTiet.Rows.Add(stt, maSKU, tenSP, size, mau, sl, dg, thanhTien);
            }

            // Reset và tính tiền
            TinhTongTien();
            txtSoLuong.Clear(); txtDonGia.Clear(); cboSanPham.SelectedIndex = -1;
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells[7].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells[7].Value);
                }
            }
            lblTongTien.Text = tong.ToString("N0") + " VNĐ";
        }

        // =========================================================================
        // PHẦN 3: XỬ LÝ NÚT "LƯU PHIẾU NHẬP" (GHI XUỐNG SQL)
        // =========================================================================
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPN.Text)) { MessageBox.Show("Thiếu mã phiếu!"); return; }
            if (cboNCC.SelectedIndex == -1) { MessageBox.Show("Chưa chọn Nhà cung cấp!"); return; }
            if (cboNhanVien.SelectedIndex == -1) { MessageBox.Show("Chưa chọn Nhân viên!"); return; }
            if (dgvChiTiet.Rows.Count == 0) { MessageBox.Show("Chưa có món hàng nào!"); return; }

            // Chuyển đổi chuỗi tổng tiền về số
            decimal tongTienPhieu = 0;
            string tienStr = lblTongTien.Text.Replace(" VNĐ", "").Replace(",", "").Replace(".", "");
            decimal.TryParse(tienStr, out tongTienPhieu);

            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 1. Lưu tblPhieuNhap
                    string sqlPN = "INSERT INTO tblPhieuNhap (sMaPN, sMaNCC, sMaNV, dNgayNhap, fTongTien) VALUES (@ma, @ncc, @nv, @ngay, @tong)";
                    SqlCommand cmdPN = new SqlCommand(sqlPN, conn, trans);
                    cmdPN.Parameters.AddWithValue("@ma", txtMaPN.Text.Trim());
                    cmdPN.Parameters.AddWithValue("@ncc", cboNCC.SelectedValue);
                    cmdPN.Parameters.AddWithValue("@nv", cboNhanVien.SelectedValue);
                    cmdPN.Parameters.AddWithValue("@ngay", dtpNgayNhap.Value);
                    cmdPN.Parameters.AddWithValue("@tong", tongTienPhieu);
                    cmdPN.ExecuteNonQuery();

                    // 2. Lưu tblChiTietNhap và Cập nhật tblKhoGiay
                    string sqlCT = "INSERT INTO tblChiTietNhap (sMaPN, sMaSKU, iSoLuongNhap, fDonGiaNhap) VALUES (@ma, @sku, @sl, @dg)";
                    string sqlKho = "UPDATE tblKhoGiay SET iSoLuong = iSoLuong + @sl WHERE sMaSKU = @sku";

                    foreach (DataGridViewRow row in dgvChiTiet.Rows)
                    {
                        string sku = row.Cells[1].Value.ToString();
                        int sl = Convert.ToInt32(row.Cells[5].Value);
                        decimal dg = Convert.ToDecimal(row.Cells[6].Value);

                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans);
                        cmdCT.Parameters.AddWithValue("@ma", txtMaPN.Text.Trim());
                        cmdCT.Parameters.AddWithValue("@sku", sku);
                        cmdCT.Parameters.AddWithValue("@sl", sl);
                        cmdCT.Parameters.AddWithValue("@dg", dg);
                        cmdCT.ExecuteNonQuery();

                        SqlCommand cmdKho = new SqlCommand(sqlKho, conn, trans);
                        cmdKho.Parameters.AddWithValue("@sku", sku);
                        cmdKho.Parameters.AddWithValue("@sl", sl);
                        cmdKho.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Lưu Phiếu Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi ghi dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}