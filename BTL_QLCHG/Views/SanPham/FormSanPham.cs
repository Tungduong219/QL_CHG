using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_QLCHG.Views.SanPham
{
    public partial class FormSanPham : Form
    {
        // Khai báo lớp xử lý dữ liệu
        GiayDAL dal = new GiayDAL();

        public FormSanPham()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // TÁCH HÀM: Định dạng lại tiêu đề cột (Dùng chung cho cả Load và Tìm Kiếm)
        private void DinhDangCot()
        {
            if (dgvGiay.Columns.Contains("sMaSKU"))
                dgvGiay.Columns["sMaSKU"].HeaderText = "Mã SKU";

            if (dgvGiay.Columns.Contains("sMaMau"))
                dgvGiay.Columns["sMaMau"].HeaderText = "Mã Mẫu";

            if (dgvGiay.Columns.Contains("iSoLuong"))
                dgvGiay.Columns["iSoLuong"].HeaderText = "Số Lượng";

            if (dgvGiay.Columns.Contains("sMaSize"))
                dgvGiay.Columns["sMaSize"].HeaderText = "Mã Size";

            if (dgvGiay.Columns.Contains("sMaMauSac"))
                dgvGiay.Columns["sMaMauSac"].HeaderText = "Mã Màu Sắc";

            // Tự động căn chỉnh độ rộng cột
            dgvGiay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Hàm nạp dữ liệu ban đầu
        void LoadData()
        {
            try
            {
                DataTable dt = dal.LayDSKho();
                dgvGiay.DataSource = dt;

                DinhDangCot(); // Gọi hàm định dạng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện Load Form
        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // 1. NÚT TÌM KIẾM
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    LoadData();
                }
                else
                {
                    // Lấy dữ liệu tìm kiếm
                    dgvGiay.DataSource = dal.TimKiem(txtTimKiem.Text.Trim());

                    // RẤT QUAN TRỌNG: Phải định dạng lại cột sau khi tìm kiếm
                    DinhDangCot();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. NÚT MỞ FORM THÊM MỚI
        private void btnMoFormThem_Click(object sender, EventArgs e)
        {
            try
            {
                FormThemSanPham f = new FormThemSanPham();
                // Kiểm tra nếu người dùng bấm "Lưu" (OK) bên form thêm thì mới Load lại lưới
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở Form Thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. NÚT QUẢN LÝ THUỘC TÍNH
        private void btnQuanLyThuocTinh_Click(object sender, EventArgs e)
        {
            try
            {
                FormThuocTinh f = new FormThuocTinh();
                f.ShowDialog();

                // (Tùy chọn) Nếu việc quản lý thuộc tính làm thay đổi tên/mã bên ngoài, bạn có thể gọi LoadData() ở đây
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở Form Thuộc Tính: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
