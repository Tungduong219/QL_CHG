using BTL_QLCHG.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLCHG.Views
{
    public partial class FormBanHang : Form
    {
        private string maKhachHangChot = "KH01";
        public FormBanHang()
        {
            InitializeComponent();
        }
        private void LoadDanhSachGiay()
        {
            string query = @"
            SELECT 
                K.sMaSKU AS [Mã SKU],
                M.sMaMau AS [Mã Mẫu], 
                M.sTenMau AS [Tên Giày], 
                KT.iGiaTriSize AS [Size], 
                MS.sTenMau AS [Màu Sắc],
                M.fGiaBan AS [Giá Bán], 
                K.iSoLuong AS [Tồn Kho]
            FROM tblKhoGiay K
            INNER JOIN tblMauGiay M ON K.sMaMau = M.sMaMau
            LEFT JOIN tblKichThuoc KT ON K.sMaSize = KT.sMaSize
            LEFT JOIN tblMauSac MS ON K.sMaMauSac = MS.sMaMauSac
            WHERE K.iSoLuong > 0";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSachGiay.DataSource = dt;
                    dgvDanhSachGiay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDanhSachGiay.AllowUserToAddRows = false;
                    dgvDanhSachGiay.ReadOnly = true;

                    if (dgvDanhSachGiay.Columns["Mã SKU"] != null)
                    {
                        dgvDanhSachGiay.Columns["Mã SKU"].Visible = false;
                    }
                    if (dgvDanhSachGiay.Columns["Mã Mẫu"] != null)
                    {
                        dgvDanhSachGiay.Columns["Mã Mẫu"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy danh sách giày: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TaoCotChoGioHang()
        {
            dgvGioHang.ColumnCount = 6;
            dgvGioHang.Columns[0].Name = "Mã SKU";
            dgvGioHang.Columns[0].Visible = false; 
            dgvGioHang.Columns[1].Name = "Tên Giày";
            dgvGioHang.Columns[2].Name = "Size";
            dgvGioHang.Columns[3].Name = "Số Lượng";
            dgvGioHang.Columns[4].Name = "Đơn Giá";
            dgvGioHang.Columns[5].Name = "Thành Tiền";

            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.AllowUserToAddRows = false; 
            dgvGioHang.ReadOnly = false;
            dgvGioHang.Columns["Mã SKU"].ReadOnly = true;
            dgvGioHang.Columns["Tên Giày"].ReadOnly = true;
            dgvGioHang.Columns["Size"].ReadOnly = true;
            dgvGioHang.Columns["Đơn Giá"].ReadOnly = true;
            dgvGioHang.Columns["Thành Tiền"].ReadOnly = true;
            dgvGioHang.Columns["Số Lượng"].DefaultCellStyle.BackColor = Color.LightYellow;
        }

        private void TinhTongTien()
        {
            
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                tongTien += Convert.ToDecimal(row.Cells["Thành Tiền"].Value);
            }
            decimal phanTramGiam = 0;
            decimal tienKhuyenMai = 0;
            if (cboKhuyenMai.SelectedItem != null && cboKhuyenMai.SelectedIndex>0)
            {
                DataRowView rowView = (DataRowView)cboKhuyenMai.SelectedItem;
                phanTramGiam = Convert.ToDecimal(rowView["iPhanTramGiam"]);
                tienKhuyenMai = tongTien * (phanTramGiam / 100);
            }    

           
            decimal thanhTien = tongTien - tienKhuyenMai;
            if (thanhTien < 0) thanhTien = 0;

            lblTongTien.Text = "TỔNG TIỀN: " + tongTien.ToString("N0") + " VNĐ";
            lblKhuyenMai.Text = $"KHUYẾN MÃI: ({phanTramGiam}%)" + tienKhuyenMai.ToString("N0") + " VNĐ";
            lblThanhTien.Text = "THÀNH TIỀN: " + thanhTien.ToString("N0") + " VNĐ";
        }
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachGiay();
            TaoCotChoGioHang();
            LoadComboBoxKhuyenMai();

   
            lblNhanVien.Text = ThongTinDangNhap.TenNhanVien;
        }

        private void dgvDanhSachGiay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachGiay.Rows[e.RowIndex];
                string maSKU = row.Cells["Mã SKU"].Value.ToString();
                string tenGiay = row.Cells["Tên Giày"].Value.ToString();
                string size = row.Cells["Size"].Value.ToString();
                decimal giaBan = Convert.ToDecimal(row.Cells["Giá Bán"].Value);

                bool daCoTrongGio = false;
                foreach (DataGridViewRow gioHangRow in dgvGioHang.Rows)
                {
                    if (gioHangRow.Cells["Mã SKU"].Value.ToString() == maSKU)
                    {
                        int soLuongCu = Convert.ToInt32(gioHangRow.Cells["Số Lượng"].Value);
                        gioHangRow.Cells["Số Lượng"].Value = soLuongCu + 1;

                        gioHangRow.Cells["Thành Tiền"].Value = (soLuongCu + 1) * giaBan;

                        daCoTrongGio = true;
                        break; 
                    }
                }

                if (!daCoTrongGio)
                {
                    dgvGioHang.Rows.Add(maSKU, tenGiay, size, 1, giaBan, giaBan);
                }

                TinhTongTien();
            }
        }

        private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvGioHang.Columns[e.ColumnIndex].Name == "Số Lượng")
            {
                DataGridViewRow row = dgvGioHang.Rows[e.RowIndex];
                int soLuongMoi = Convert.ToInt32(row.Cells["Số Lượng"].Value);
                decimal donGia = Convert.ToDecimal(row.Cells["Đơn Giá"].Value);

                row.Cells["Thành Tiền"].Value = soLuongMoi * donGia;

                TinhTongTien();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn giày trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHD = TaoMaHoaDonTuDong();

            string tienChu = lblThanhTien.Text.Replace("THÀNH TIỀN: ", "").Replace(" VNĐ", "").Replace(",", "").Trim();
            decimal tongTienSauGiam = Convert.ToDecimal(tienChu);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 3. Chèn dữ liệu vào bảng tblHoaDon
                        string queryHD = @"INSERT INTO tblHoaDon (sMaHD, sMaNV, sMaKH, sMaKM, dNgayBan, fTongTien) 
                                   VALUES (@MaHD, @MaNV, @MaKH, @MaKM, GETDATE(), @TongTien)";

                        using (SqlCommand cmdHD = new SqlCommand(queryHD, conn, trans))
                        {
                            cmdHD.Parameters.AddWithValue("@MaHD", maHD);

                            // LẤY MÃ NHÂN VIÊN ĐANG ĐĂNG NHẬP (Theo ý cô giáo)
                            cmdHD.Parameters.AddWithValue("@MaNV", ThongTinDangNhap.MaNhanVien);

                            cmdHD.Parameters.AddWithValue("@MaKH", maKhachHangChot); // KH01 hoặc mã khách tìm được

                            // KIỂM TRA KHUYẾN MÃI: Nếu đang chọn dòng "Hãy chọn..." thì lưu NULL
                            if (cboKhuyenMai.SelectedIndex <= 0)
                            {
                                cmdHD.Parameters.AddWithValue("@MaKM", DBNull.Value);
                            }
                            else
                            {
                                cmdHD.Parameters.AddWithValue("@MaKM", cboKhuyenMai.SelectedValue);
                            }

                            cmdHD.Parameters.AddWithValue("@TongTien", tongTienSauGiam);
                            cmdHD.ExecuteNonQuery();
                        }

                        foreach (DataGridViewRow row in dgvGioHang.Rows)
                        {
                            if (row.Cells["Mã SKU"].Value == null) continue;

                            string maSKU = row.Cells["Mã SKU"].Value.ToString();
                            int soLuongBan = Convert.ToInt32(row.Cells["Số Lượng"].Value);
                            decimal donGia = Convert.ToDecimal(row.Cells["Đơn Giá"].Value);

                            // A. Chèn vào bảng tblChiTietHoaDon
                            string queryCTHD = @"INSERT INTO tblChiTietHoaDon (sMaHD, sMaSKU, iSoLuongBan, fDonGiaBan) 
                                         VALUES (@MaHD, @MaSKU, @SoLuong, @DonGia)";
                            using (SqlCommand cmdCTHD = new SqlCommand(queryCTHD, conn, trans))
                            {
                                cmdCTHD.Parameters.AddWithValue("@MaHD", maHD);
                                cmdCTHD.Parameters.AddWithValue("@MaSKU", maSKU);
                                cmdCTHD.Parameters.AddWithValue("@SoLuong", soLuongBan);
                                cmdCTHD.Parameters.AddWithValue("@DonGia", donGia);
                                cmdCTHD.ExecuteNonQuery();
                            }

                            // B. Cập nhật trừ số lượng trong kho tblKhoGiay
                            string queryKho = "UPDATE tblKhoGiay SET iSoLuong = iSoLuong - @SoLuong WHERE sMaSKU = @MaSKU";
                            using (SqlCommand cmdKho = new SqlCommand(queryKho, conn, trans))
                            {
                                cmdKho.Parameters.AddWithValue("@SoLuong", soLuongBan);
                                cmdKho.Parameters.AddWithValue("@MaSKU", maSKU);
                                cmdKho.ExecuteNonQuery();
                            }
                        }

                        // 5. Chốt đơn
                        trans.Commit();
                        MessageBox.Show($"Thanh toán thành công!\nHóa đơn: {maHD}\nNgười lập: {ThongTinDangNhap.TenNhanVien}",
                                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 6. Dọn dẹp giao diện sau khi bán xong
                        dgvGioHang.Rows.Clear();
                        cboKhuyenMai.SelectedIndex = 0;
                        TinhTongTien();
                        LoadDanhSachGiay(); // Load lại để cập nhật số lượng tồn kho mới lên màn hình
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback(); // Có lỗi thì hủy hết thao tác trên
                        MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string TaoMaHoaDonTuDong()
        {
            string maHDMoi = "HD00001";
            string query = "SELECT TOP 1 sMaHD FROM tblHoaDon ORDER BY CAST(RIGHT(sMaHD, LEN(sMaHD) - 2) AS INT) DESC";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        // Nếu Database đã có hóa đơn rồi
                        if (result != null && result != DBNull.Value)
                        {
                            string maHDCu = result.ToString();

                            // Cắt bỏ 2 ký tự đầu (chữ "HD"), lấy phần số phía sau
                            int soCu = Convert.ToInt32(maHDCu.Substring(2));

                            // Cộng thêm 1
                            int soMoi = soCu + 1;
                            maHDMoi = "HD" + soMoi.ToString("D5");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tự động tạo mã: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return maHDMoi;
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
        TinhTongTien();
        }



        private void LoadComboBoxKhuyenMai()
        {
            string query = "SELECT sMaKM, sTenChuongTrinh, iPhanTramGiam FROM tblKhuyenMai";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Tạo dòng gợi ý mặc định
                DataRow dr = dt.NewRow();
                dr["sMaKM"] = DBNull.Value;
                dr["sTenChuongTrinh"] = "Chọn khuyến mãi..";
                dr["iPhanTramGiam"] = 0;
                dt.Rows.InsertAt(dr, 0);

                cboKhuyenMai.DataSource = dt;
                cboKhuyenMai.DisplayMember = "sTenChuongTrinh";
                cboKhuyenMai.ValueMember = "sMaKM";

                cboKhuyenMai.SelectedIndex = 0; // Để nó hiện dòng gợi ý ngay từ đầu
            }
        }

        private void cboKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtSDTKhach_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDTKhach.Text.Trim();

            if (sdt.Length>=10)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT sMaKH,sTenKH FROM tblKhachHang WHERE sDienThoai = @SDT";
                    using (SqlCommand cmd = new SqlCommand(query,conn))
                    {
                        cmd.Parameters.AddWithValue("SDT", sdt);
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                maKhachHangChot = reader["sMaKH"].ToString();
                                lblTenKhach.Text = reader["sTenKH"].ToString();
                                lblTenKhach.ForeColor = Color.Green;
                            }
                            else {
                                maKhachHangChot = "";
                                lblTenKhach.Text = "Khách mới nhấn (+) để thêm";
                                lblTenKhach.ForeColor= Color.Red;
                            }
                        }
                    }
                }
            }
            else
            {
                maKhachHangChot = "KH01";
                lblTenKhach.Text = "....";
                lblTenKhach.ForeColor = Color.Black;
            }    
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {

        }

    }
}
