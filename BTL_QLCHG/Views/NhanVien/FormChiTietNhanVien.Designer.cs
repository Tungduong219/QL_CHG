namespace BTL_QLCHG.Views
{
    partial class FormChiTietNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThemSuaNhanVien = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.roundPanel1 = new BTL_QLCHG.Utils.RoundPanel();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThemSuaNhanVien
            // 
            this.lblThemSuaNhanVien.AutoSize = true;
            this.lblThemSuaNhanVien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemSuaNhanVien.ForeColor = System.Drawing.Color.Navy;
            this.lblThemSuaNhanVien.Location = new System.Drawing.Point(58, 62);
            this.lblThemSuaNhanVien.Name = "lblThemSuaNhanVien";
            this.lblThemSuaNhanVien.Size = new System.Drawing.Size(248, 31);
            this.lblThemSuaNhanVien.TabIndex = 0;
            this.lblThemSuaNhanVien.Text = "Thêm/Sửa Nhân Viên \r\n";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(25, 36);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(57, 20);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(537, 36);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(55, 20);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "TenNV:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(537, 105);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(68, 20);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Click += new System.EventHandler(this.lblGioiTinh_Click);
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVaoLam.Location = new System.Drawing.Point(28, 105);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(104, 20);
            this.lblNgayVaoLam.TabIndex = 4;
            this.lblNgayVaoLam.Text = "Ngày vào làm:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(32, 68);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(460, 22);
            this.txtMaNV.TabIndex = 5;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(541, 68);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(460, 22);
            this.txtTenNV.TabIndex = 6;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(541, 137);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(460, 24);
            this.cboGioiTinh.TabIndex = 7;
            this.cboGioiTinh.Text = "Nam/Nữ";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(29, 139);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(460, 22);
            this.dtpNgayVaoLam.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(32, 354);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(445, 37);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(541, 354);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(445, 37);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(28, 265);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(54, 20);
            this.lblLuong.TabIndex = 11;
            this.lblLuong.Text = "Lương:";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(28, 192);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(74, 20);
            this.lblTaiKhoan.TabIndex = 12;
            this.lblTaiKhoan.Text = "Tài khoản:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(537, 192);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(73, 20);
            this.lblMatKhau.TabIndex = 13;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(538, 265);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(54, 20);
            this.lblQuyen.TabIndex = 14;
            this.lblQuyen.Text = "Quyền:";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(32, 301);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(460, 22);
            this.txtLuong.TabIndex = 15;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(29, 218);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(460, 22);
            this.txtTaiKhoan.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(541, 218);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(460, 22);
            this.txtMatKhau.TabIndex = 17;
            // 
            // cboQuyen
            // 
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cboQuyen.Location = new System.Drawing.Point(541, 299);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(460, 24);
            this.cboQuyen.TabIndex = 18;
            this.cboQuyen.Text = "Admin/Nhân viên";
            this.cboQuyen.SelectedIndexChanged += new System.EventHandler(this.cboQuyen_SelectedIndexChanged);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.Controls.Add(this.lblMaNV);
            this.roundPanel1.Controls.Add(this.btnLuu);
            this.roundPanel1.Controls.Add(this.btnHuy);
            this.roundPanel1.Controls.Add(this.cboQuyen);
            this.roundPanel1.Controls.Add(this.txtMaNV);
            this.roundPanel1.Controls.Add(this.lblQuyen);
            this.roundPanel1.Controls.Add(this.txtLuong);
            this.roundPanel1.Controls.Add(this.txtMatKhau);
            this.roundPanel1.Controls.Add(this.lblTenNV);
            this.roundPanel1.Controls.Add(this.lblLuong);
            this.roundPanel1.Controls.Add(this.txtTaiKhoan);
            this.roundPanel1.Controls.Add(this.txtTenNV);
            this.roundPanel1.Controls.Add(this.lblNgayVaoLam);
            this.roundPanel1.Controls.Add(this.dtpNgayVaoLam);
            this.roundPanel1.Controls.Add(this.lblMatKhau);
            this.roundPanel1.Controls.Add(this.lblGioiTinh);
            this.roundPanel1.Controls.Add(this.lblTaiKhoan);
            this.roundPanel1.Controls.Add(this.cboGioiTinh);
            this.roundPanel1.Location = new System.Drawing.Point(64, 111);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(1019, 409);
            this.roundPanel1.TabIndex = 19;
            this.roundPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundPanel1_Paint);
            // 
            // FormChiTietNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 554);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.lblThemSuaNhanVien);
            this.Name = "FormChiTietNhanVien";
            this.Text = "FormChiTietNhanVien";
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThemSuaNhanVien;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ComboBox cboQuyen;
        private Utils.RoundPanel roundPanel1;
    }
}