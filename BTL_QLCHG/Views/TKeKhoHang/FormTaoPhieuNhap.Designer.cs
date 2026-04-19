namespace BTL_QLCHG.Views.TKeKhoHang
{
    partial class FormTaoPhieuNhap
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
            this.gbThongTinChung = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.gbThemHang = new System.Windows.Forms.GroupBox();
            this.btnThemDong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTongKet = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbThongTinChung.SuspendLayout();
            this.gbThemHang.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.gbTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTinChung
            // 
            this.gbThongTinChung.Controls.Add(this.label4);
            this.gbThongTinChung.Controls.Add(this.cboNhanVien);
            this.gbThongTinChung.Controls.Add(this.dtpNgayNhap);
            this.gbThongTinChung.Controls.Add(this.label3);
            this.gbThongTinChung.Controls.Add(this.label2);
            this.gbThongTinChung.Controls.Add(this.cboNCC);
            this.gbThongTinChung.Controls.Add(this.label1);
            this.gbThongTinChung.Controls.Add(this.txtMaPN);
            this.gbThongTinChung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinChung.Location = new System.Drawing.Point(11, 51);
            this.gbThongTinChung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongTinChung.Name = "gbThongTinChung";
            this.gbThongTinChung.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongTinChung.Size = new System.Drawing.Size(816, 99);
            this.gbThongTinChung.TabIndex = 0;
            this.gbThongTinChung.TabStop = false;
            this.gbThongTinChung.Text = "I. Thông tin chung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhân viên lập phiếu:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(597, 49);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(189, 27);
            this.cboNhanVien.TabIndex = 6;
            this.cboNhanVien.Text = "Admin - Nguyễn Văn Admin";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(436, 50);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(104, 26);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // cboNCC
            // 
            this.cboNCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(199, 49);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(172, 27);
            this.cboNCC.TabIndex = 2;
            this.cboNCC.Text = "-- Chọn Nhà Cung Cấp --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(16, 46);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(135, 29);
            this.txtMaPN.TabIndex = 0;
            // 
            // gbThemHang
            // 
            this.gbThemHang.Controls.Add(this.btnThemDong);
            this.gbThemHang.Controls.Add(this.label5);
            this.gbThemHang.Controls.Add(this.txtDonGia);
            this.gbThemHang.Controls.Add(this.label8);
            this.gbThemHang.Controls.Add(this.txtSoLuong);
            this.gbThemHang.Controls.Add(this.label7);
            this.gbThemHang.Controls.Add(this.cboSanPham);
            this.gbThemHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThemHang.Location = new System.Drawing.Point(11, 160);
            this.gbThemHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThemHang.Name = "gbThemHang";
            this.gbThemHang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThemHang.Size = new System.Drawing.Size(816, 93);
            this.gbThemHang.TabIndex = 1;
            this.gbThemHang.TabStop = false;
            this.gbThemHang.Text = "II. Thêm chi tiết hàng";
            // 
            // btnThemDong
            // 
            this.btnThemDong.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThemDong.FlatAppearance.BorderSize = 0;
            this.btnThemDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDong.ForeColor = System.Drawing.Color.White;
            this.btnThemDong.Location = new System.Drawing.Point(653, 47);
            this.btnThemDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemDong.Name = "btnThemDong";
            this.btnThemDong.Size = new System.Drawing.Size(92, 28);
            this.btnThemDong.TabIndex = 12;
            this.btnThemDong.Text = "Thêm hàng";
            this.btnThemDong.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(469, 47);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(108, 29);
            this.txtDonGia.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(260, 47);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 29);
            this.txtSoLuong.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chọn sản phẩm:";
            // 
            // cboSanPham
            // 
            this.cboSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(16, 50);
            this.cboSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(172, 27);
            this.cboSanPham.TabIndex = 2;
            this.cboSanPham.Text = "-- Chọn SKU Sản Phẩm --";
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Controls.Add(this.dgvChiTiet);
            this.gbDanhSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDanhSach.Location = new System.Drawing.Point(11, 263);
            this.gbDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDanhSach.Size = new System.Drawing.Size(816, 173);
            this.gbDanhSach.TabIndex = 2;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "III. Danh sách chi tiết phiếu nhập";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaSKU,
            this.colTenSP,
            this.colSize,
            this.colMau,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dgvChiTiet.Location = new System.Drawing.Point(16, 28);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(784, 122);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colMaSKU
            // 
            this.colMaSKU.HeaderText = "Mã SKU";
            this.colMaSKU.MinimumWidth = 6;
            this.colMaSKU.Name = "colMaSKU";
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            // 
            // colSize
            // 
            this.colSize.HeaderText = "Size";
            this.colSize.MinimumWidth = 6;
            this.colSize.Name = "colSize";
            // 
            // colMau
            // 
            this.colMau.HeaderText = "Màu";
            this.colMau.MinimumWidth = 6;
            this.colMau.Name = "colMau";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // gbTongKet
            // 
            this.gbTongKet.Controls.Add(this.lblTongTien);
            this.gbTongKet.Controls.Add(this.label6);
            this.gbTongKet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTongKet.Location = new System.Drawing.Point(593, 460);
            this.gbTongKet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTongKet.Name = "gbTongKet";
            this.gbTongKet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTongKet.Size = new System.Drawing.Size(233, 81);
            this.gbTongKet.TabIndex = 3;
            this.gbTongKet.TabStop = false;
            this.gbTongKet.Text = "Tổng kết";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(115, 37);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(29, 21);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "0đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng cộng tiền:";
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.DarkGreen;
            this.btnHoanThanh.FlatAppearance.BorderSize = 0;
            this.btnHoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanThanh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.White;
            this.btnHoanThanh.Location = new System.Drawing.Point(323, 492);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(126, 28);
            this.btnHoanThanh.TabIndex = 13;
            this.btnHoanThanh.Text = "LƯU PHIẾU NHẬP";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(11, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "TẠO PHIẾU NHẬP MỚI";
            // 
            // FormTaoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.gbTongKet);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThemHang);
            this.Controls.Add(this.gbThongTinChung);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTaoPhieuNhap";
            this.Text = "TẠO PHIẾU NHẬP MỚI";
            this.gbThongTinChung.ResumeLayout(false);
            this.gbThongTinChung.PerformLayout();
            this.gbThemHang.ResumeLayout(false);
            this.gbThemHang.PerformLayout();
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.gbTongKet.ResumeLayout(false);
            this.gbTongKet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinChung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.GroupBox gbThemHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThemDong;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.GroupBox gbTongKet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Label label9;
    }
}