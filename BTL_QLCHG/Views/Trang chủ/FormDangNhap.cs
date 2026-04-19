using BTL_QLCHG.DataAccess;
using BTL_QLCHG.Views;
using System;
using System.Windows.Forms;

namespace BTL_QLCHG
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát phần mềm không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau  = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                NhanVienInfo nv = nhanVienDAL.KiemTraDangNhap(taiKhoan, matKhau);

                if (nv != null)
                {
                    // Lưu đầy đủ thông tin vào ThongTinDangNhap
                    ThongTinDangNhap.MaNhanVien  = nv.MaNV;
                    ThongTinDangNhap.TenNhanVien = nv.TenNV;
                    ThongTinDangNhap.Quyen       = nv.Quyen;

                    MessageBox.Show($"Đăng nhập thành công!\nXin chào {nv.TenNV} [{nv.Quyen}]",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormTrangChu frm = new FormTrangChu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng thử lại.",
                        "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng nhập: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
