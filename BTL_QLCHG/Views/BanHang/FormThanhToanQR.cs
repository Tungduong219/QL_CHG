using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_QLCHG.Views.BanHang
{
    public partial class FormThanhToanQR : Form
    {
        public bool IsSuccess { get; set; } = false;

        public FormThanhToanQR(decimal soTien, string maHD)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            InitializeComponent();

            // 1. Cấu hình thông tin nhận tiền (Hiếu sửa ở đây)
            string nganHang = "MB Bank";
            string stk = "88888888";
            string tenChuTK = "DO TUNG DUONG";

            // 2. Hiển thị thông tin ra nhãn (Phần Hiếu yêu cầu)
            lblNganHang.Text = "Ngân hàng: " + nganHang;
            lblSTK.Text = "STK: " + stk;
            lblChuTK.Text = "Chủ TK: " + tenChuTK;
            lblSoTien.Text = soTien.ToString("N0") + " VNĐ";

            // 3. Tạo mã QR dự phòng
            picQR.Image = Properties.Resources.qrcung;
            picQR.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            IsSuccess = true;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            IsSuccess = false;
            this.Close();
        }
    }
}