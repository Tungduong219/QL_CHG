using BTL_QLCHG.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_QLCHG.Views
{
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Không rõ");
            cboGioiTinh.SelectedIndex = 2;

            txtSDT.Enter += RemovePlaceholder;
            txtSDT.Leave += SetPlaceholder;

            txtEmail.Enter += RemovePlaceholder;
            txtEmail.Leave += SetPlaceholder;

            txtDiaChi.Enter += RemovePlaceholder;
            txtDiaChi.Leave += SetPlaceholder;

            ResetForm();
        }

        #region XỬ LÝ GIAO DIỆN (CHỮ MỜ)
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag != null && txt.Text == txt.Tag.ToString())
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag != null && string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = txt.Tag.ToString();
                txt.ForeColor = Color.Gray;
            }
        }

        private void ResetForm()
        {
            txtTenKH.Text = "";

            txtSDT.Text = txtSDT.Tag?.ToString();
            txtSDT.ForeColor = Color.Gray;

            txtEmail.Text = txtEmail.Tag?.ToString();
            txtEmail.ForeColor = Color.Gray;

            txtDiaChi.Text = txtDiaChi.Tag?.ToString();
            txtDiaChi.ForeColor = Color.Gray;

            if (cboGioiTinh.Items.Count > 2) cboGioiTinh.SelectedIndex = 2;

            dtpNgaySinh.Checked = false;

            lblPageTitle.Focus();
        }
        #endregion

        #region XỬ LÝ LƯU DATABASE
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            string maKH = "KH" + DateTime.Now.ToString("ddHHmmss");
            string tenKH = txtTenKH.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem != null ? cboGioiTinh.SelectedItem.ToString() : "Không rõ";

            string sdt = (txtSDT.Text.Trim() == txtSDT.Tag?.ToString()) ? "" : txtSDT.Text.Trim();
            string email = (txtEmail.Text.Trim() == txtEmail.Tag?.ToString()) ? "" : txtEmail.Text.Trim();
            string diaChi = (txtDiaChi.Text.Trim() == txtDiaChi.Tag?.ToString()) ? "" : txtDiaChi.Text.Trim();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string query = @"INSERT INTO tblKhachHang (sMaKH, sTenKH, sDienThoai, sGioiTinh, sEmail, dNgaySinh, sDiaChi) 
                                     VALUES (@MaKH, @TenKH, @SDT, @GioiTinh, @Email, @NgaySinh, @DiaChi)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.Parameters.AddWithValue("@TenKH", tenKH);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@SDT", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi);

                        if (dtpNgaySinh.Checked)
                            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                        else
                            cmd.Parameters.AddWithValue("@NgaySinh", DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}