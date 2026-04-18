using BTL_QLCHG.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using BTL_QLCHG.Views.BaoCao;

namespace BTL_QLCHG // Lưu ý: Nếu tên project của bạn khác, nhớ đổi dòng này
{
    public partial class FormThongKe : Form
    {
        // 1. HÀM KHỞI TẠO 
        public FormThongKe()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tự động gắn các sự kiện để không bao giờ sợ lỗi mất kết nối Designer
            this.Load += new EventHandler(FormThongKe_Load);
            this.btnXemDuLieu.Click += new EventHandler(btnXemDuLieu_Click);
            this.cboLoaiThongKe.SelectedIndexChanged += new EventHandler(cboLoaiThongKe_SelectedIndexChanged);
            this.cboNhanVien.SelectedIndexChanged += new EventHandler(cboNhanVien_SelectedIndexChanged);
        }

        // 2. SỰ KIỆN KHI MỞ FORM
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(2025, 1, 1);
            dtpDenNgay.Value = DateTime.Now;

            cboLoaiThongKe.Items.Clear();
            cboLoaiThongKe.Items.AddRange(new string[] {
                "Tất cả thời gian",
                "Hôm nay",
                "7 ngày qua",
                "Tháng này",
                "Tùy chọn"
            });

            LoadComboBoxNhanVien();

            if (cboLoaiThongKe.Items.Count > 0)
            {
                cboLoaiThongKe.SelectedIndex = 0;
            }
        }

        // 3. HÀM LẤY DANH SÁCH NHÂN VIÊN
        private void LoadComboBoxNhanVien()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT sMaNV, sTenNV FROM tblNhanVien";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow row = dt.NewRow();
                    row["sMaNV"] = "ALL";
                    row["sTenNV"] = "--- Tất cả nhân viên ---";
                    dt.Rows.InsertAt(row, 0);

                    cboNhanVien.SelectedIndexChanged -= cboNhanVien_SelectedIndexChanged;

                    // BẮT BUỘC ĐỂ 2 DÒNG NÀY LÊN TRÊN DATASOURCE
                    cboNhanVien.DisplayMember = "sTenNV";
                    cboNhanVien.ValueMember = "sMaNV";
                    cboNhanVien.DataSource = dt;
                    cboNhanVien.SelectedIndex = 0;

                    cboNhanVien.SelectedIndexChanged += cboNhanVien_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối khi tải danh sách nhân viên: " + ex.Message);
            }
        }

        // 4. SỰ KIỆN ĐỔI THỜI GIAN
        private void cboLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay == null || dtpDenNgay == null) return;
            DateTime today = DateTime.Now.Date;

            switch (cboLoaiThongKe.SelectedIndex)
            {
                case 0: // Tất cả thời gian
                    dtpTuNgay.Value = new DateTime(2025, 1, 1);
                    dtpDenNgay.Value = today;
                    dtpTuNgay.Enabled = dtpDenNgay.Enabled = false;
                    break;
                case 1: // Hôm nay
                    dtpTuNgay.Value = today;
                    dtpDenNgay.Value = today;
                    dtpTuNgay.Enabled = dtpDenNgay.Enabled = false;
                    break;
                case 2: // 7 ngày qua
                    dtpTuNgay.Value = today.AddDays(-7);
                    dtpDenNgay.Value = today;
                    dtpTuNgay.Enabled = dtpDenNgay.Enabled = false;
                    break;
                case 3: // Tháng này
                    dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
                    dtpDenNgay.Value = today;
                    dtpTuNgay.Enabled = dtpDenNgay.Enabled = false;
                    break;
                case 4: // Tùy chọn
                    dtpTuNgay.Enabled = dtpDenNgay.Enabled = true;
                    break;
            }
            btnXemDuLieu.PerformClick();
        }

        // 5. SỰ KIỆN ĐỔI NHÂN VIÊN (Hàm này lúc nãy bạn copy bị sót nè)
        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXemDuLieu.PerformClick();
        }

        // 6. HÀM TRUY VẤN CỐT LÕI (Hàm này cũng bị sót)
        private void btnXemDuLieu_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date) return;

            // 1. TRÍCH XUẤT MÃ NHÂN VIÊN AN TOÀN (CHỐNG LỖI DATAROWVIEW)
            string maNV = "ALL";
            if (cboNhanVien.SelectedValue != null)
            {
                if (cboNhanVien.SelectedValue is DataRowView drv)
                    maNV = drv["sMaNV"].ToString();
                else
                    maNV = cboNhanVien.SelectedValue.ToString();
            }

            bool isFilterByNhanVien = (maNV != "ALL" && maNV != "System.Data.DataRowView");

            // 2. TẠO CÂU LỆNH WHERE
            string whereClause = "WHERE CAST(hd.dNgayBan AS DATE) >= @TuNgay AND CAST(hd.dNgayBan AS DATE) <= @DenNgay ";
            if (isFilterByNhanVien)
            {
                whereClause += " AND hd.sMaNV = @MaNV ";
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // --- TRUY VẤN TỔNG KẾT ---
                    string queryTong = $@"
                SELECT 
                    COUNT(DISTINCT hd.sMaHD) AS TongDon,
                    ISNULL(SUM(cthd.iSoLuongBan * cthd.fDonGiaBan), 0) AS TongDoanhThu,
                    ISNULL(SUM(cthd.iSoLuongBan), 0) AS TongSoGiay,
                    ISNULL(SUM(cthd.iSoLuongBan * (cthd.fDonGiaBan - ISNULL(GiaNhapMoiNhat.fDonGiaNhap, 0))), 0) AS TongLoiNhuan
                FROM tblHoaDon hd
                INNER JOIN tblChiTietHoaDon cthd ON hd.sMaHD = cthd.sMaHD
                LEFT JOIN tblKhoGiay kg ON cthd.sMaSKU = kg.sMaSKU
                OUTER APPLY (
                    SELECT TOP 1 ctn.fDonGiaNhap 
                    FROM tblChiTietNhap ctn 
                    WHERE ctn.sMaSKU = kg.sMaSKU 
                    ORDER BY ctn.sMaPN DESC
                ) AS GiaNhapMoiNhat
                {whereClause}";

                    using (SqlCommand cmd = new SqlCommand(queryTong, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                        cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);

                        // Nạp đúng biến chuỗi maNV đã ép kiểu an toàn
                        if (isFilterByNhanVien) cmd.Parameters.AddWithValue("@MaNV", maNV);

                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                lblTongDonHang.Text = r["TongDon"].ToString() + " đơn";
                                lblTongDoanhThu.Text = Convert.ToDecimal(r["TongDoanhThu"]).ToString("N0") + " đ";
                                lblTongSoGiay.Text = r["TongSoGiay"].ToString() + " đôi";
                                lblTongLoiNhuan.Text = Convert.ToDecimal(r["TongLoiNhuan"]).ToString("N0") + " đ";
                            }
                        }
                    }

                    // --- TRUY VẤN LƯỚI ---
                    string queryGrid = $@"
                SELECT 
                    hd.sMaHD AS [Mã HĐ],
                    hd.dNgayBan AS [Ngày Bán],
                    nv.sTenNV AS [Nhân Viên],
                    cthd.iSoLuongBan AS [SL],
                    cthd.fDonGiaBan AS [Giá Bán],
                    (cthd.iSoLuongBan * cthd.fDonGiaBan) AS [Thành Tiền]
                FROM tblHoaDon hd
                INNER JOIN tblChiTietHoaDon cthd ON hd.sMaHD = cthd.sMaHD
                LEFT JOIN tblNhanVien nv ON hd.sMaNV = nv.sMaNV
                {whereClause}
                ORDER BY hd.dNgayBan DESC";

                    using (SqlCommand cmdGrid = new SqlCommand(queryGrid, conn))
                    {
                        cmdGrid.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                        cmdGrid.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);

                        // Nạp đúng biến chuỗi maNV đã ép kiểu an toàn
                        if (isFilterByNhanVien) cmdGrid.Parameters.AddWithValue("@MaNV", maNV);

                        SqlDataAdapter da = new SqlDataAdapter(cmdGrid);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvChiTiet.DataSource = dt;
                        dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        if (dgvChiTiet.Columns["Giá Bán"] != null)
                            dgvChiTiet.Columns["Giá Bán"].DefaultCellStyle.Format = "N0";
                        if (dgvChiTiet.Columns["Thành Tiền"] != null)
                            dgvChiTiet.Columns["Thành Tiền"].DefaultCellStyle.Format = "N0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Chặn người dùng nếu bảng đang trống không có gì để in
            if (dgvChiTiet.Rows.Count == 0 || dgvChiTiet.DataSource == null)
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 2. Lấy dữ liệu trên lưới
                DataTable dtDuLieu = ((DataTable)dgvChiTiet.DataSource).Copy();

                // Cú pháp ép tên cột: Đổi từ Tiếng Việt (trên lưới) sang không dấu (khớp với Dataset dsThongKe.xsd)
                dtDuLieu.Columns["Mã HĐ"].ColumnName = "MaHD";
                dtDuLieu.Columns["Ngày Bán"].ColumnName = "NgayBan";
                dtDuLieu.Columns["Nhân Viên"].ColumnName = "NhanVien";
                dtDuLieu.Columns["SL"].ColumnName = "SoLuong";
                dtDuLieu.Columns["Giá Bán"].ColumnName = "GiaBan";
                dtDuLieu.Columns["Thành Tiền"].ColumnName = "ThanhTien";

                // 3. Khởi tạo file Crystal Report
                rptDoanhThu rpt = new rptDoanhThu();
                rpt.SetDataSource(dtDuLieu);

                // 4. CHÍNH LÀ ĐÂY: Gán giá trị từ Label trên Form vào Parameter của bản in
                rpt.SetParameterValue("pTongDon", lblTongDonHang.Text);
                rpt.SetParameterValue("pDoanhThu", lblTongDoanhThu.Text);
                rpt.SetParameterValue("pTongGiay", lblTongSoGiay.Text);
                rpt.SetParameterValue("pLoiNhuan", lblTongLoiNhuan.Text);

                // 5. Mở Form hiển thị bản in lên
                FormXemBaoCao frm = new FormXemBaoCao();
                frm.CrystalReportViewer.ReportSource = rpt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}