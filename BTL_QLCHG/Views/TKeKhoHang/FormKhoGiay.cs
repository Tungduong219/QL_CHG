using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace TkeKhohang
{
    public partial class FormKhoGiay : Form
    {
        string strConnect = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;

        public FormKhoGiay()
        {
            InitializeComponent();
            btnTabNhapKho.Click += btnTabNhapKho_Click;
            btnTabTonKho.Click += btnTabTonKho_Click;
            btnTabHoanTra.Click += btnTabHoanTra_Click;
            btnTabNCC.Click += btnTabNCC_Click;
            btnLocNhap.Click += btnLocNhap_Click;
            btnTimPhieu.Click += btnTimPhieu_Click;
            btnTimTonKho.Click += btnTimTonKho_Click;
            btnLocTra.Click += btnLocTra_Click;
            btnTimNCC.Click += btnTimNCC_Click;
            btnXoaPhieu.Click += btnXoaPhieu_Click;
            btnSuaNCC.Click += btnSuaNCC_Click;
            btnXoaNCC.Click += btnXoaNCC_Click;
        }

        private void FormKhoGiay_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.AutoGenerateColumns = false;
            dgvTonKho.AutoGenerateColumns = false;
            dgvPhieuTra.AutoGenerateColumns = false;
            dgvNCC.AutoGenerateColumns = false;

            btnTabNhapKho_Click(sender, e);
        }

        #region --- 1. CHỨC NĂNG MENU TAB & ĐỔI MÀU NÚT ---
        private void ResetMenu()
        {
            btnTabNhapKho.BackColor = Color.White; btnTabNhapKho.ForeColor = Color.Black;
            btnTabTonKho.BackColor = Color.White; btnTabTonKho.ForeColor = Color.Black;
            btnTabHoanTra.BackColor = Color.White; btnTabHoanTra.ForeColor = Color.Black;
            btnTabNCC.BackColor = Color.White; btnTabNCC.ForeColor = Color.Black;
        }

        private void btnTabNhapKho_Click(object sender, EventArgs e)
        {
            tcKhoHang.SelectedIndex = 0; ResetMenu();
            btnTabNhapKho.BackColor = Color.FromArgb(51, 122, 183); btnTabNhapKho.ForeColor = Color.White;
            LoadPhieuNhap();
        }

        private void btnTabTonKho_Click(object sender, EventArgs e)
        {
            tcKhoHang.SelectedIndex = 1; ResetMenu();
            btnTabTonKho.BackColor = Color.FromArgb(51, 122, 183); btnTabTonKho.ForeColor = Color.White;
            LoadTonKho();
        }

        private void btnTabHoanTra_Click(object sender, EventArgs e)
        {
            tcKhoHang.SelectedIndex = 2; ResetMenu();
            btnTabHoanTra.BackColor = Color.FromArgb(51, 122, 183); btnTabHoanTra.ForeColor = Color.White;
            LoadPhieuTra();
        }

        private void btnTabNCC_Click(object sender, EventArgs e)
        {
            tcKhoHang.SelectedIndex = 3; ResetMenu();
            btnTabNCC.BackColor = Color.FromArgb(51, 122, 183); btnTabNCC.ForeColor = Color.White;
            LoadNCC();
        }
        #endregion

        #region --- 2. CÁC HÀM TẢI DỮ LIỆU TỪ SQL & HIỂN THỊ THÔNG BÁO TỔNG ---
        private void LoadPhieuNhap(string dieuKien = "")
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                string sql = @"SELECT pn.sMaPN, pn.dNgayNhap, ncc.sTenNCC, pn.fTongTien, nv.sTenNV 
                               FROM tblPhieuNhap pn 
                               INNER JOIN tblNhaCungCap ncc ON pn.sMaNCC = ncc.sMaNCC 
                               INNER JOIN tblNhanVien nv ON pn.sMaNV = nv.sMaNV " + dieuKien;
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable(); da.Fill(dt);
                dgvPhieuNhap.DataSource = dt;

                lblTongPhieuNhap.Text = "Tổng số phiếu nhập là: " + dgvPhieuNhap.Rows.Count.ToString();
            }
        }

        private void LoadTonKho(string dieuKien = "")
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                string sql = @"SELECT k.sMaSKU, m.sTenMau, sz.iGiaTriSize, ms.sTenMau AS TenMauSac, k.iSoLuong 
                               FROM tblKhoGiay k 
                               INNER JOIN tblMauGiay m ON k.sMaMau = m.sMaMau 
                               INNER JOIN tblKichThuoc sz ON k.sMaSize = sz.sMaSize 
                               INNER JOIN tblMauSac ms ON k.sMaMauSac = ms.sMaMauSac " + dieuKien;
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable(); da.Fill(dt);
                dgvTonKho.DataSource = dt;

                lblTongTonKho.Text = "Tổng số mã sản phẩm tồn kho: " + dgvTonKho.Rows.Count.ToString();
            }
        }

        private void LoadPhieuTra(string dieuKien = "")
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                string sql = "SELECT sMaPT, sMaHD, dNgayTra, sLyDo, fTongTienHoan FROM tblPhieuTra " + dieuKien;
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable(); da.Fill(dt);
                dgvPhieuTra.DataSource = dt;

                lblTongPhieuTra.Text = "Tổng số phiếu hoàn trả: " + dgvPhieuTra.Rows.Count.ToString();
            }
        }

        private void LoadNCC(string dieuKien = "")
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                string sql = "SELECT sMaNCC, sTenNCC, sDienThoai, sDiaChi FROM tblNhaCungCap " + dieuKien;
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable(); da.Fill(dt);
                dgvNCC.DataSource = dt;

                lblTongNCC.Text = "Tổng số nhà cung cấp đối tác: " + dgvNCC.Rows.Count.ToString();
            }
        }
        #endregion

        #region --- 3. SỰ KIỆN TÌM KIẾM & LỌC ---
        private void btnLocNhap_Click(object sender, EventArgs e)
        {
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd 23:59:59");
            LoadPhieuNhap($" WHERE pn.dNgayNhap >= '{tuNgay}' AND pn.dNgayNhap <= '{denNgay}'");
        }

        private void btnTimPhieu_Click(object sender, EventArgs e)
        {
            string tk = txtTimPhieu.Text.Trim();
            LoadPhieuNhap($" WHERE pn.sMaPN LIKE '%{tk}%' OR ncc.sTenNCC LIKE N'%{tk}%'");
        }

        private void btnTimTonKho_Click(object sender, EventArgs e)
        {
            string tk = txtTimTonKho.Text.Trim();
            LoadTonKho($" WHERE k.sMaSKU LIKE '%{tk}%' OR m.sTenMau LIKE N'%{tk}%'");
        }

        private void btnLocTra_Click(object sender, EventArgs e)
        {
            string tuNgay = dtpTuNgayTra.Value.ToString("yyyy/MM/dd");
            string denNgay = dtpDenNgayTra.Value.ToString("yyyy/MM/dd") + " 23:59:59";
            LoadPhieuTra($" WHERE dNgayTra >= '{tuNgay}' AND dNgayTra <= '{denNgay}'");
        }

        private void btnTimNCC_Click(object sender, EventArgs e)
        {
            string tk = txtTimNCC.Text.Trim();
            LoadNCC($" WHERE sTenNCC LIKE N'%{tk}%' OR sDienThoai LIKE '%{tk}%'");
        }
        #endregion

        #region --- 4. CHỨC NĂNG THÊM - SỬA - XÓA ---

        private void btnTaoPhieuMoi_Click(object sender, EventArgs e)
        {
            FormTaoPhieuNhap frm = new FormTaoPhieuNhap();
            frm.ShowDialog();
            LoadPhieuNhap();
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.CurrentRow == null || dgvPhieuNhap.CurrentRow.IsNewRow) return;

            string maPN = dgvPhieuNhap.CurrentRow.Cells["colMaPN_Tab1"].Value.ToString();

            if (MessageBox.Show($"Xóa phiếu {maPN} sẽ TRỪ kho. Dũng chắc chắn chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        string sqlGetCT = "SELECT sMaSKU, iSoLuongNhap FROM tblChiTietNhap WHERE sMaPN = @ma";
                        SqlCommand cmdGet = new SqlCommand(sqlGetCT, conn, trans);
                        cmdGet.Parameters.AddWithValue("@ma", maPN);
                        DataTable dt = new DataTable();
                        using (SqlDataReader rd = cmdGet.ExecuteReader()) { dt.Load(rd); }

                        foreach (DataRow row in dt.Rows)
                        {
                            string sqlUp = "UPDATE tblKhoGiay SET iSoLuong = iSoLuong - @sl WHERE sMaSKU = @sku";
                            SqlCommand cmdUp = new SqlCommand(sqlUp, conn, trans);
                            cmdUp.Parameters.AddWithValue("@sl", row["iSoLuongNhap"]);
                            cmdUp.Parameters.AddWithValue("@sku", row["sMaSKU"]);
                            cmdUp.ExecuteNonQuery();
                        }

                        new SqlCommand($"DELETE FROM tblChiTietNhap WHERE sMaPN = '{maPN}'", conn, trans).ExecuteNonQuery();
                        new SqlCommand($"DELETE FROM tblPhieuNhap WHERE sMaPN = '{maPN}'", conn, trans).ExecuteNonQuery();

                        trans.Commit();
                        MessageBox.Show("Xóa phiếu thành công!");
                        LoadPhieuNhap();
                    }
                    catch (Exception ex) { trans.Rollback(); MessageBox.Show("Lỗi: " + ex.Message); }
                }
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            FormThemNCC frm = new FormThemNCC();
            frm.ShowDialog();
            LoadNCC();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            if (dgvNCC.CurrentRow == null || dgvNCC.CurrentRow.IsNewRow) return;

            string ma = dgvNCC.CurrentRow.Cells["colMaNCC_Tab4"].Value?.ToString() ?? "";
            string ten = dgvNCC.CurrentRow.Cells["colTenNCC_Tab4"].Value?.ToString() ?? "";
            string sdt = dgvNCC.CurrentRow.Cells["colSDT_Tab4"].Value?.ToString() ?? "";
            string diachi = dgvNCC.CurrentRow.Cells["colDiaChi_Tab4"].Value?.ToString() ?? "";

            FormThemNCC frm = new FormThemNCC(ma, ten, sdt, diachi);
            frm.ShowDialog();
            LoadNCC();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (dgvNCC.CurrentRow == null || dgvNCC.CurrentRow.IsNewRow) return;

            string ma = dgvNCC.CurrentRow.Cells["colMaNCC_Tab4"].Value.ToString();
            string ten = dgvNCC.CurrentRow.Cells["colTenNCC_Tab4"].Value.ToString();

            if (MessageBox.Show($"Xóa NCC {ten}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    try
                    {
                        conn.Open();
                        new SqlCommand($"DELETE FROM tblNhaCungCap WHERE sMaNCC = '{ma}'", conn).ExecuteNonQuery();
                        MessageBox.Show("Đã xóa!");
                        LoadNCC();
                    }
                    catch { MessageBox.Show("Không thể xóa vì NCC đã có dữ liệu nhập hàng!"); }
                }
            }
        }
        #endregion

        private void btnTabHoanTra_Click_1(object sender, EventArgs e)
        {

        }
    }
}