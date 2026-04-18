using BTL_QLCHG.Utils;
using BTL_QLCHG.Views.KhachHang;
using donhang;
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
using TkeKhohang;

namespace BTL_QLCHG.Views
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        private Form formHienTai = null;

        private void MoFormCon(Form formCon)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
            }
            formHienTai = formCon;

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;

            formCon.Dock = DockStyle.None;
            formCon.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(formCon);
            pnlDesktop.Tag = formCon;
            formCon.BringToFront();
            formCon.Show();
        }

        private void LoadThongKeNhanh()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // 1. DOANH THU HÔM NAY
                    // (Giả sử bảng tblHoaDon của bạn có cột dNgayLap và fTongTien)
                    string queryDoanhThu = @"SELECT ISNULL(SUM(fTongTien), 0) FROM tblHoaDon 
                                     WHERE CAST(dNgayBan AS DATE) = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(queryDoanhThu, conn))
                    {
                        decimal doanhThu = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblDoanhThuNgay.Text = doanhThu.ToString("N0") + " đ";
                    }

                    // 2. ĐƠN HÀNG MỚI HÔM NAY
                    string queryDonHang = @"SELECT COUNT(*) FROM tblHoaDon 
                                    WHERE CAST(dNgayBan AS DATE) = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(queryDonHang, conn))
                    {
                        int soDon = Convert.ToInt32(cmd.ExecuteScalar());
                        lblDonHangMoi.Text = soDon.ToString() + " đơn";
                    }

                    // 3. TỔNG KHÁCH HÀNG
                    string queryKhachHang = "SELECT COUNT(*) FROM tblKhachHang";
                    using (SqlCommand cmd = new SqlCommand(queryKhachHang, conn))
                    {
                        int soKhach = Convert.ToInt32(cmd.ExecuteScalar());
                        lblKhachHangMoi.Text = soKhach.ToString() + " khách";
                    }
                    //Top Giày
                    // 4. TOP SẢN PHẨM BÁN CHẠY NHẤT
                    // 4. TOP SẢN PHẨM BÁN CHẠY NHẤT
                    string queryTopSP = @"
                        SELECT TOP 1 
                            SUM(ct.iSoLuongBan) AS TongSoLuong, 
                            mg.sTenMau AS TenSanPham 
                        FROM tblChiTietHoaDon ct
                        -- Bắc cầu 1: Nối chi tiết hóa đơn với Kho giày qua sMaSKU
                        INNER JOIN tblKhoGiay kg ON ct.sMaSKU = kg.sMaSKU
                        -- Bắc cầu 2: Nối Kho giày với Mẫu giày qua sMaMau để lấy tên
                        INNER JOIN tblMauGiay mg ON kg.sMaMau = mg.sMaMau
                        GROUP BY mg.sTenMau
                        ORDER BY SUM(ct.iSoLuongBan) DESC";

                    using (SqlCommand cmdTop = new SqlCommand(queryTopSP, conn))
                    {
                        using (SqlDataReader reader = cmdTop.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tenSP = reader["TenSanPham"].ToString();
                                int soLuong = Convert.ToInt32(reader["TongSoLuong"]);

                                lblTopSanPham.Text = $"{soLuong} đôi\n({tenSP})";
                            }
                            else
                            {
                                lblTopSanPham.Text = "0 đôi\n(Chưa có dữ liệu)";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải thống kê: " + ex.Message);
                }
            }
        }

        private void LoadHoatDongGanDay()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string query = @"
                SELECT TOP 5 
                    hd.sMaHD AS [Mã HĐ], 
                    kh.sTenKH AS [Khách hàng], 
                    hd.fTongTien AS [Tổng tiền], 
                    nv.sTenNV AS [Nhân viên lập]
                FROM tblHoaDon hd
                LEFT JOIN tblKhachHang kh ON hd.sMaKH = kh.sMaKH
                LEFT JOIN tblNhanVien nv ON hd.sMaNV = nv.sMaNV
                ORDER BY hd.dNgayBan DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvHoatDong.AutoGenerateColumns = true;
                        dgvHoatDong.DataSource = dt;

                        dgvHoatDong.Columns["Khách hàng"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvHoatDong.Columns["Nhân viên lập"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi load bảng hoạt động: " + ex.Message);
                }
            }
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormBanHang());
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormDonHang());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormNhanVien());
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new TongKhachHang());
            lblTieuDeTrang.Text = "Khách Hàng";
        }

        private void btn_Giay_Click(object sender, EventArgs e)
        {
            MoFormCon(new BTL_QLBG.FormSanPham());
        }

        private void btn_KhoGiay_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormKhoGiay());
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormThongKe());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
           DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketqua == DialogResult.Yes)
            {
                this.Close();
                FormDangNhap frm = new FormDangNhap();
                frm.Show();
            }
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            LoadThongKeNhanh();
            LoadHoatDongGanDay();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
                formHienTai = null; // Reset lại trạng thái
            }
            lblTieuDeTrang.Text = "Trang chủ";
            LoadThongKeNhanh();
            LoadHoatDongGanDay();

        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            MoFormCon (new FormKhuyenMai());
        }
    }
}
