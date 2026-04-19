using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace donhang
{
    public partial class FormDonHang : Form
    {
        string strConnect = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;

        public FormDonHang()
        {
            InitializeComponent();
            dgvTatCa.AutoGenerateColumns = dgvGiaoHang.AutoGenerateColumns = dgvHoanTra.AutoGenerateColumns = false;

            btnTabTatCa.Click += (s, e) => ChuyenTab(0, btnTabTatCa);
            btnTabGiaoHang.Click += (s, e) => ChuyenTab(1, btnTabGiaoHang);
            btnTabHoanTra.Click += (s, e) => ChuyenTab(2, btnTabHoanTra);

            btnLoc.Click += (s, e) => LoadData();
            btnTim.Click += (s, e) => LoadData();
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            btnCapNhatGiaoHang.Click += btnCapNhatGiaoHang_Click;
            btnHuyDon.Click += btnHuyDon_Click;

            this.Load += (s, e) => {
                dtpTuNgay.Value = new DateTime(2024, 1, 1);
                dtpDenNgay.Value = DateTime.Now;
                ChuyenTab(0, btnTabTatCa);
            };
        }

        private void ChuyenTab(int index, Button btnActive)
        {
            tcDonHang.SelectedIndex = index;
            btnTabTatCa.BackColor = btnTabGiaoHang.BackColor = btnTabHoanTra.BackColor = Color.WhiteSmoke;
            btnTabTatCa.ForeColor = btnTabGiaoHang.ForeColor = btnTabHoanTra.ForeColor = Color.Black;

            btnActive.BackColor = Color.FromArgb(51, 122, 183);
            btnActive.ForeColor = Color.White;

            btnXemChiTiet.Enabled = true; btnXemChiTiet.BackColor = Color.FromArgb(51, 122, 183);

            if (index == 0)
            {
                btnHuyDon.Enabled = true; btnHuyDon.BackColor = Color.FromArgb(51, 122, 183);
                btnCapNhatGiaoHang.Enabled = false; btnCapNhatGiaoHang.BackColor = Color.LightGray;
            }
            else if (index == 1)
            {
                btnHuyDon.Enabled = true; btnHuyDon.BackColor = Color.FromArgb(51, 122, 183);
                btnCapNhatGiaoHang.Enabled = true; btnCapNhatGiaoHang.BackColor = Color.FromArgb(51, 122, 183);
            }
            else if (index == 2)
            {
                btnHuyDon.Enabled = true; btnHuyDon.BackColor = Color.FromArgb(51, 122, 183);
                btnCapNhatGiaoHang.Enabled = false; btnCapNhatGiaoHang.BackColor = Color.LightGray;
            }
            txtTimKiem.Text = "Tìm đơn hàng ...";
            dtpTuNgay.Value = new DateTime(2024, 1, 1);
            dtpDenNgay.Value = DateTime.Now;
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string sql = "";
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);
                cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@denNgay", denNgay);

                string tuKhoa = txtTimKiem.Text.Trim();
                bool coTimKiem = !string.IsNullOrEmpty(tuKhoa) && tuKhoa != "Tìm đơn hàng ...";
                if (coTimKiem)
                {
                    cmd.Parameters.AddWithValue("@tk", "%" + tuKhoa + "%");
                }

                if (tcDonHang.SelectedIndex == 0) 
                {
                    sql = @"SELECT h.sMaHD, h.dNgayBan, k.sTenKH, h.fTongTien, 
                           CASE WHEN g.iTrangThai = 1 THEN N'Đang giao'
                                WHEN g.iTrangThai = 2 THEN N'Thành công'
                                ELSE N'Mới tạo' END AS TrangThai
                    FROM tblHoaDon h 
                    LEFT JOIN tblKhachHang k ON h.sMaKH = k.sMaKH
                    LEFT JOIN tblGiaoHang g ON h.sMaHD = g.sMaHD
                    WHERE h.sMaHD NOT IN (SELECT sMaHD FROM tblPhieuTra) 
                    AND h.dNgayBan >= @tuNgay AND h.dNgayBan <= @denNgay"; 

                    if (coTimKiem) sql += " AND (h.sMaHD LIKE @tk OR k.sTenKH LIKE @tk)"; 

                    cmd.CommandText = sql;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTatCa.DataSource = dt;
                }
                else if (tcDonHang.SelectedIndex == 1) 
                {
                    sql = @"SELECT g.sMaHD, g.sMaVanDon, g.sDonViVanChuyen, 
                           CASE WHEN g.iTrangThai = 1 THEN N'Đang giao'
                                WHEN g.iTrangThai = 2 THEN N'Thành công'
                                ELSE N'Chờ lấy' END AS TrangThai
                    FROM tblGiaoHang g 
                    JOIN tblHoaDon h ON g.sMaHD = h.sMaHD
                    LEFT JOIN tblKhachHang k ON h.sMaKH = k.sMaKH
                    WHERE h.dNgayBan >= @tuNgay AND h.dNgayBan <= @denNgay"; 
                    if (coTimKiem) sql += " AND (g.sMaHD LIKE @tk OR k.sTenKH LIKE @tk OR g.sMaVanDon LIKE @tk)";

                    cmd.CommandText = sql;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvGiaoHang.DataSource = dt;
                }
                else if (tcDonHang.SelectedIndex == 2) 
                {
                    sql = @"SELECT pt.sMaPT, pt.sMaHD, pt.sLyDo, pt.fTongTienHoan 
                    FROM tblPhieuTra pt
                    JOIN tblHoaDon h ON pt.sMaHD = h.sMaHD
                    LEFT JOIN tblKhachHang k ON h.sMaKH = k.sMaKH
                    WHERE pt.dNgayTra >= @tuNgay AND pt.dNgayTra <= @denNgay"; 
                    if (coTimKiem) sql += " AND (pt.sMaPT LIKE @tk OR pt.sMaHD LIKE @tk OR k.sTenKH LIKE @tk)";

                    cmd.CommandText = sql;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHoanTra.DataSource = dt;
                }
            }
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            int tabHienTai = tcDonHang.SelectedIndex;

            if (tabHienTai == 0 && dgvTatCa.CurrentRow != null)
            {
                string maHD = dgvTatCa.CurrentRow.Cells["colMa_TC"].Value.ToString();
                new FormChiTietDon(maHD, tabHienTai).ShowDialog(); 
            }
            else if (tabHienTai == 1 && dgvGiaoHang.CurrentRow != null)
            {
                string maHD = dgvGiaoHang.CurrentRow.Cells["colMa_GH"].Value.ToString();
                new FormChiTietDon(maHD, tabHienTai).ShowDialog(); 
            }
            else if (tabHienTai == 2 && dgvHoanTra.CurrentRow != null)
            {
                string maHD = dgvHoanTra.CurrentRow.Cells["colMaHD_HT"].Value.ToString();
                string maPT = dgvHoanTra.CurrentRow.Cells["colMaPT"].Value.ToString();
                new FormChiTietDon(maHD, tabHienTai, maPT).ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCapNhatGiaoHang_Click(object sender, EventArgs e)
        {
            if (dgvGiaoHang.CurrentRow == null) return;

            string maHD = dgvGiaoHang.CurrentRow.Cells["colMa_GH"].Value.ToString();
            string trangThaiHienTai = dgvGiaoHang.CurrentRow.Cells["colTrangThai"].Value?.ToString() ?? "";

            int trangThaiMoi = -1;
            string cauHoi = "";

            if (trangThaiHienTai == "Chờ lấy")
            {
                trangThaiMoi = 1; 
                cauHoi = "Shipper đã đến lấy hàng. Xác nhận chuyển đơn [" + maHD + "] sang trạng thái ĐANG GIAO?";
            }
            else if (trangThaiHienTai == "Đang giao")
            {
                trangThaiMoi = 2; 
                cauHoi = "Khách đã nhận hàng. Xác nhận đơn [" + maHD + "] GIAO THÀNH CÔNG và đã thu tiền?";
            }
            else if (trangThaiHienTai == "Thành công")
            {
                MessageBox.Show("Đơn hàng này đã giao thành công rồi, không thể cập nhật thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Đơn hàng này đã bị hủy, không thể cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult qs = MessageBox.Show(cauHoi, "Cập nhật quy trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qs == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strConnect))
                    {
                        string sql = "UPDATE tblGiaoHang SET iTrangThai = @tt WHERE sMaHD = @ma";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@tt", trangThaiMoi);
                        cmd.Parameters.AddWithValue("@ma", maHD);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã cập nhật quy trình giao hàng!", "Thành công");
                        LoadData();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (tcDonHang.SelectedIndex == 2) {
                MessageBox.Show("Đơn này đã nằm trong danh sách Hoàn trả rồi!", "Thông báo");
                return;
            }

            // Lấy mã HĐ từ đúng tab đang chọn
            string maHD = null;
            if (tcDonHang.SelectedIndex == 0)
            {
                if (dgvTatCa.CurrentRow == null) { MessageBox.Show("Vui lòng chọn một đơn hàng!", "Thông báo"); return; }
                maHD = dgvTatCa.CurrentRow.Cells["colMa_TC"].Value.ToString();
            }
            else if (tcDonHang.SelectedIndex == 1)
            {
                if (dgvGiaoHang.CurrentRow == null) { MessageBox.Show("Vui lòng chọn một đơn hàng!", "Thông báo"); return; }
                maHD = dgvGiaoHang.CurrentRow.Cells["colMa_GH"].Value.ToString();
            }

            using (SqlConnection conn = new SqlConnection(strConnect)) 
            {
                conn.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblPhieuTra WHERE sMaHD = @ma", conn);
                checkCmd.Parameters.AddWithValue("@ma", maHD);
                if ((int)checkCmd.ExecuteScalar() > 0) {
                    MessageBox.Show("Đơn hàng này đã được xử lý Hủy/Trả trước đó rồi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult qs = MessageBox.Show(
                    "Bạn có chắc chắn muốn HỦY / TRẢ HÀNG toàn bộ đơn [" + maHD + "] không?\n\n" +
                    "- Một Phiếu Hoàn Trả sẽ tự động được tạo.\n" +
                    "- Toàn bộ số lượng giày sẽ được CỘNG LẠI VÀO KHO.", 
                    "Cảnh báo nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (qs == DialogResult.Yes)
                {
                    string lyDoTraHang = TaoPopupChonLyDo();
                    if (string.IsNullOrWhiteSpace(lyDoTraHang)) return;

                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        string maPT = "PT01";
                        string sqlLayMa = "SELECT TOP 1 sMaPT FROM tblPhieuTra ORDER BY CAST(SUBSTRING(sMaPT, 3, LEN(sMaPT)) AS INT) DESC";
                        SqlCommand cmdLayMa = new SqlCommand(sqlLayMa, conn, trans);
                        object result = cmdLayMa.ExecuteScalar();
                        if (result != null && result.ToString() != "")
                        {
                            string maCu = result.ToString();
                            int soTiepTheo = int.Parse(maCu.Substring(2)) + 1;
                            maPT = "PT" + soTiepTheo.ToString("D2");
                        }

                        string sqlPT = @"INSERT INTO tblPhieuTra(sMaPT, sMaHD, sMaNV, dNgayTra, sLyDo, fTongTienHoan) 
                                 SELECT @maPT, sMaHD, sMaNV, GETDATE(), @lyDo, fTongTien 
                                 FROM tblHoaDon WHERE sMaHD = @ma";
                        SqlCommand cmdPT = new SqlCommand(sqlPT, conn, trans);
                        cmdPT.Parameters.AddWithValue("@maPT", maPT);
                        cmdPT.Parameters.AddWithValue("@ma", maHD);
                        cmdPT.Parameters.AddWithValue("@lyDo", lyDoTraHang);
                        cmdPT.ExecuteNonQuery();

                        string sqlCTT = @"INSERT INTO tblChiTietTra(sMaPT, sMaSKU, iSoLuongTra, sTinhTrang)
                                  SELECT @maPT, sMaSKU, iSoLuongBan, N'Hàng Hoàn' FROM tblChiTietHoaDon WHERE sMaHD = @ma";
                        SqlCommand cmdCTT = new SqlCommand(sqlCTT, conn, trans);
                        cmdCTT.Parameters.AddWithValue("@maPT", maPT);
                        cmdCTT.Parameters.AddWithValue("@ma", maHD);
                        cmdCTT.ExecuteNonQuery();

                        string sqlKho = @"UPDATE k SET k.iSoLuong = k.iSoLuong + c.iSoLuongBan
                                  FROM tblKhoGiay k JOIN tblChiTietHoaDon c ON k.sMaSKU = c.sMaSKU WHERE c.sMaHD = @ma";
                        SqlCommand cmdKho = new SqlCommand(sqlKho, conn, trans);
                        cmdKho.Parameters.AddWithValue("@ma", maHD);
                        cmdKho.ExecuteNonQuery();

                        string sqlGiao = "UPDATE tblGiaoHang SET iTrangThai = 3 WHERE sMaHD = @ma";
                        SqlCommand cmdGiao = new SqlCommand(sqlGiao, conn, trans);
                        cmdGiao.Parameters.AddWithValue("@ma", maHD);
                        cmdGiao.ExecuteNonQuery();

                        trans.Commit();
                        MessageBox.Show("Xử lý thành công!\nĐã tạo Phiếu Trả [" + maPT + "] với lý do: " + lyDoTraHang, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Hệ thống phát hiện lỗi: " + ex.Message);
                    }
                }
            }
        }
        private string TaoPopupChonLyDo()
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Xác nhận lý do",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 350, Text = "Vui lòng chọn hoặc nhập lý do hoàn trả:" };

            ComboBox cmbLyDo = new ComboBox() { Left = 20, Top = 50, Width = 340 };
            cmbLyDo.Items.AddRange(new string[] {
                "Khách đổi ý / Không muốn mua nữa",
                "Sai kích cỡ (Size chật/rộng)",
                "Sản phẩm lỗi / Không giống hình",
                "Giao hàng quá chậm",
                "Không liên lạc được"
            });
            cmbLyDo.SelectedIndex = 0; 

            Button confirmation = new Button() { Text = "Xác nhận", Left = 260, Width = 100, Top = 100, DialogResult = DialogResult.OK, BackColor = Color.FromArgb(51, 122, 183), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            confirmation.FlatAppearance.BorderSize = 0;

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(cmbLyDo);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? cmbLyDo.Text : "";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTabGiaoHang_Click(object sender, EventArgs e)
        {

        }
    }
}