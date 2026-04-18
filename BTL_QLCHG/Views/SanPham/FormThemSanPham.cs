using System;
using System.Windows.Forms;

namespace BTL_QLBG
{
    public partial class FormThemSanPham : Form
    {
        GiayDAL dal = new GiayDAL();

        public FormThemSanPham()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra nhập liệu cơ bản (Đã thêm kiểm tra txtSoLuong)
                if (string.IsNullOrWhiteSpace(txtSKU.Text) ||
                    string.IsNullOrWhiteSpace(txtMaMau.Text) ||
                    string.IsNullOrWhiteSpace(txtMaSize.Text) ||
                    string.IsNullOrWhiteSpace(txtMaMauSac.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text)) // Thêm ô Số lượng vào đây
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Lấy dữ liệu từ giao diện
                string sku = txtSKU.Text.Trim();
                string maMau = txtMaMau.Text.Trim();
                string maSize = txtMaSize.Text.Trim();
                string maMauSac = txtMaMauSac.Text.Trim();

                // 3. Ép kiểu số lượng ĐÚNG CHUẨN (Lấy từ txtSoLuong thay vì txtMaMauSac)
                if (!int.TryParse(txtSoLuong.Text.Trim(), out int sl) || sl < 0)
                {
                    MessageBox.Show("Số lượng phải là một số nguyên dương hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.Focus();
                    return;
                }

                // 4. Gọi hàm ThemGiay với ĐỦ 5 THAM SỐ
                dal.ThemGiay(sku, maMau, sl, maSize, maMauSac);

                MessageBox.Show("Thêm sản phẩm vào kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. RẤT QUAN TRỌNG: Gửi tín hiệu OK về cho FormSanPham bên ngoài biết để LoadData()
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu vào Database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}