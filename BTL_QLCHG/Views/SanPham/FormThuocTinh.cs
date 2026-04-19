using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_QLCHG.Views.SanPham
{
    public partial class FormThuocTinh : Form
    {
        // Khai báo lớp xử lý dữ liệu
        private readonly GiayDAL dal = new GiayDAL();

        public FormThuocTinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // GÁN SỰ KIỆN TƯỜNG MINH ĐỂ CHỐNG LỖI DESIGNER
            this.Load += new EventHandler(FormThuocTinh_Load);
        }

        /// <summary>
        /// Nạp lại dữ liệu cho cả 2 bảng Size và Màu
        /// </summary>
        private void LoadData()
        {
            try
            {
                // ================== 1. NẠP DỮ LIỆU SIZE ==================
                DataTable dtSize = dal.LayDSSize();
                dgvSize.DataSource = dtSize;

                // Nếu có dữ liệu, đổi tên Header theo vị trí cột
                if (dgvSize.Columns.Count >= 2)
                {
                    dgvSize.Columns[0].HeaderText = "Mã Size";
                    dgvSize.Columns[1].HeaderText = "Giá Trị Kích Cỡ";
                }

                // ================== 2. NẠP DỮ LIỆU MÀU SẮC ==================
                DataTable dtMau = dal.LayDSMau();
                dgvMauSac.DataSource = dtMau;

                if (dgvMauSac.Columns.Count >= 2)
                {
                    dgvMauSac.Columns[0].HeaderText = "Mã Màu";
                    dgvMauSac.Columns[1].HeaderText = "Tên Màu Sắc";
                }

                // Tối ưu hiển thị (Tự động giãn cột lấp đầy lưới)
                dgvSize.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMauSac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu từ cơ sở dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CHỈ GIỮ LẠI ĐÚNG 1 HÀM LOAD FORM NÀY
        private void FormThuocTinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // ==========================================
        // XỬ LÝ SIZE
        // ==========================================

        private void btnThemSize_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSize.Text) || string.IsNullOrWhiteSpace(txtGiaTriSize.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Size và Giá trị Size!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dal.ThemSize(txtMaSize.Text.Trim(), txtGiaTriSize.Text.Trim());
                LoadData();
                txtMaSize.Clear();
                txtGiaTriSize.Clear();
                txtMaSize.Focus();
                MessageBox.Show("Thêm Size thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm Size: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaSize_Click(object sender, EventArgs e)
        {
            if (dgvSize.CurrentRow == null) return;

            string ma = dgvSize.CurrentRow.Cells[0].Value.ToString();

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa Size '{ma}'?\n\nCẢNH BÁO: Việc này sẽ xóa toàn bộ giày có Size này trong kho!",
                "Xác nhận xóa nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    dal.XoaSize(ma);
                    LoadData();
                    MessageBox.Show("Xóa Size thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa Size: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // XỬ LÝ MÀU SẮC
        // ==========================================

        private void btnThemMau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMauSac.Text) || string.IsNullOrWhiteSpace(txtTenMau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã màu và Tên màu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dal.ThemMau(txtMaMauSac.Text.Trim(), txtTenMau.Text.Trim());
                LoadData();
                txtMaMauSac.Clear();
                txtTenMau.Clear();
                txtMaMauSac.Focus();
                MessageBox.Show("Thêm Màu sắc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm Màu sắc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMau_Click(object sender, EventArgs e)
        {
            if (dgvMauSac.CurrentRow == null) return;

            string ma = dgvMauSac.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa mã màu '{ma}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dal.XoaMau(ma);
                    LoadData();
                    MessageBox.Show("Xóa màu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    // Catch riêng cho trường hợp vướng khóa ngoại (Foreign Key)
                    MessageBox.Show("Không thể xóa màu này vì nó đang được gắn cho một số đôi giày trong kho!", "Từ chối xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // CÁC NÚT ĐIỀU HƯỚNG & SỰ KIỆN TRỐNG
        // ==========================================

        private void btnQuayLaiSize_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLaiMau_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Giữ lại để tránh lỗi ở file Designer
        private void txtMaSize_TextChanged(object sender, EventArgs e) { }
        private void lblMaSize_Click(object sender, EventArgs e) { }
    }
}