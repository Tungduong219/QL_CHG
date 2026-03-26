using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            formCon.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(formCon);
            pnlDesktop.Tag = formCon;
            formCon.BringToFront();
            formCon.Show();
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
            MoFormCon(new ThemKhachHang());
        }

        private void btn_Giay_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormGiay());
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
    }
}
