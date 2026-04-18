using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace donhang
{
    public partial class FormChiTietDon : Form
    {
        string strConnect = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;
        string _maHD;

        bool coGiaoHang = false;
        bool coHoanTra = false;

        public FormChiTietDon(string maHD, int tabIndex, string maPhieuTra = "")
        {
            InitializeComponent();
            _maHD = maHD;
            dgvChiTiet.AutoGenerateColumns = false;

            if (string.IsNullOrEmpty(maPhieuTra))
            {
                lblTieuDe.Text = "CHI TIẾT HÓA ĐƠN: " + maHD;
            }
            else
            {
                lblTieuDe.Text = "CHI TIẾT PHIẾU TRẢ: " + maPhieuTra;
            }

            LoadThongTinChung();
            LoadLuoiChiTiet();

            if (tabIndex == 1) 
            {
                KiemTraGiaoHang();
            }
            else if (tabIndex == 2) 
            {
                KiemTraHoanTra();
            }
            else 
            {
                KiemTraGiaoHang();
                KiemTraHoanTra();
            }
            SapXepGiaoDien();
        }

        private void SapXepGiaoDien()
        {
            int toaDoY = lblTongTien.Bottom + 20;

            if (coGiaoHang)
            {
                pnlGiaoHang.Location = new Point(pnlGiaoHang.Location.X, toaDoY);
                toaDoY = pnlGiaoHang.Bottom + 10;
            }

            if (coHoanTra)
            {
                pnlHoanTra.Location = new Point(pnlHoanTra.Location.X, toaDoY);
                toaDoY = pnlHoanTra.Bottom + 10;
            }

            dgvChiTiet.Location = new Point(dgvChiTiet.Location.X, toaDoY);
            dgvChiTiet.Height = this.ClientSize.Height - toaDoY - 20;
        }

        private void LoadThongTinChung()
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                string sql = "SELECT k.sMaKH, k.sTenKH, h.dNgayBan, h.fTongTien FROM tblHoaDon h LEFT JOIN tblKhachHang k ON h.sMaKH = k.sMaKH WHERE h.sMaHD = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", _maHD);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    lblMaKH.Text = "Mã KH: " + (rd["sMaKH"] != DBNull.Value ? rd["sMaKH"].ToString() : "Khách lẻ");
                    lblTenKH.Text = "Khách hàng: " + (rd["sTenKH"] != DBNull.Value ? rd["sTenKH"].ToString() : "N/A");
                    if (rd["dNgayBan"] != DBNull.Value)
                        lblNgayBan.Text = "Ngày bán: " + Convert.ToDateTime(rd["dNgayBan"]).ToString("dd/MM/yyyy HH:mm");
                    if (rd["fTongTien"] != DBNull.Value)
                        lblTongTien.Text = "Tổng tiền: " + Convert.ToDecimal(rd["fTongTien"]).ToString("N0") + "đ";
                }
            }
        }

        private void KiemTraGiaoHang()
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                string sql = "SELECT sDonViVanChuyen, iTrangThai FROM tblGiaoHang WHERE sMaHD = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", _maHD);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    pnlGiaoHang.Visible = true;
                    coGiaoHang = true; 

                    lblDonViGiao.Text = "ĐVVC: " + rd["sDonViVanChuyen"].ToString();
                    lblTrangThaiGiao.Text = "Trạng thái: " + (rd["iTrangThai"].ToString() == "2" ? "Giao thành công" : "Đang xử lý");
                }
            }
        }

        private void KiemTraHoanTra()
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                string sql = "SELECT sLyDo, fTongTienHoan FROM tblPhieuTra WHERE sMaHD = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", _maHD);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    pnlHoanTra.Visible = true;
                    coHoanTra = true;

                    lblLyDoTra.Text = "Lý do: " + rd["sLyDo"].ToString();
                    lblTienHoan.Text = "Tiền hoàn: " + Convert.ToDecimal(rd["fTongTienHoan"]).ToString("N0") + "đ";
                }
            }
        }

        private void LoadLuoiChiTiet()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    string sql = @"SELECT 
                                        m.sTenMau, 
                                        kt.iGiaTriSize AS iSize,      -- Đổi bí danh cho khớp với Name cột Size
                                        ms.sTenMau AS sMauSac,        -- Đổi bí danh cho khớp với Name cột Màu
                                        c.iSoLuongBan, 
                                        c.fDonGiaBan, 
                                        (c.iSoLuongBan * c.fDonGiaBan) AS ThanhTien 
                                   FROM tblChiTietHoaDon c 
                                   JOIN tblKhoGiay k ON c.sMaSKU = k.sMaSKU 
                                   JOIN tblMauGiay m ON k.sMaMau = m.sMaMau 
                                   JOIN tblKichThuoc kt ON k.sMaSize = kt.sMaSize 
                                   JOIN tblMauSac ms ON k.sMaMauSac = ms.sMaMauSac 
                                   WHERE c.sMaHD = @ma";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@ma", _maHD);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvChiTiet.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết: " + ex.Message);
            }
        }
    }
}