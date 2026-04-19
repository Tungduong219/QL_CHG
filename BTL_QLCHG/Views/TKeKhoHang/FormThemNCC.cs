using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace BTL_QLCHG.Views.TKeKhoHang
{
    public partial class FormThemNCC : Form
    {
        string strConnect = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;
        private bool isEditMode = false;

        public FormThemNCC()
        {
            InitializeComponent();
            isEditMode = false;
            this.Text = "Thêm mới Nhà Cung Cấp";
            btnLuu.Text = "Lưu lại";
        }

        public FormThemNCC(string ma, string ten, string sdt, string diachi)
        {
            InitializeComponent();
            isEditMode = true;
            this.Text = "Sửa thông tin Nhà Cung Cấp";
            btnLuu.Text = "Cập nhật";
            txtMaNCC.Text = ma;
            txtMaNCC.ReadOnly = true;
            txtTenNCC.Text = ten;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text) || string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Mã và Tên Nhà cung cấp không được để trống!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                try
                {
                    conn.Open();
                    string sql = "";
                    if (isEditMode)
                    {
                        sql = "UPDATE tblNhaCungCap SET sTenNCC = @ten, sDienThoai = @sdt, sDiaChi = @dc WHERE sMaNCC = @ma";
                    }
                    else
                    {
                        sql = "INSERT INTO tblNhaCungCap (sMaNCC, sTenNCC, sDienThoai, sDiaChi) VALUES (@ma, @ten, @sdt, @dc)";
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaNCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTenNCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(isEditMode ? "Cập nhật thành công!" : "Thêm mới thành công!", "Thông báo");
                    this.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thao tác dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}