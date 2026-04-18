namespace TkeKhohang
{
    partial class FormKhoGiay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTabNhapKho = new System.Windows.Forms.Button();
            this.btnTabTonKho = new System.Windows.Forms.Button();
            this.btnTabNCC = new System.Windows.Forms.Button();
            this.btnTabHoanTra = new System.Windows.Forms.Button();
            this.tcKhoHang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTongPhieuNhap = new System.Windows.Forms.Label();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimPhieu = new System.Windows.Forms.Button();
            this.txtTimPhieu = new System.Windows.Forms.TextBox();
            this.btnLocNhap = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTaoPhieuMoi = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTongTonKho = new System.Windows.Forms.Label();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.colSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimTonKho = new System.Windows.Forms.Button();
            this.txtTimTonKho = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTongPhieuTra = new System.Windows.Forms.Label();
            this.dgvPhieuTra = new System.Windows.Forms.DataGridView();
            this.colMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienHoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLocTra = new System.Windows.Forms.Button();
            this.dtpDenNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgayTra = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblTongNCC = new System.Windows.Forms.Label();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.colMaNCC_Tab4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC_Tab4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT_Tab4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi_Tab4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimNCC = new System.Windows.Forms.Button();
            this.txtTimNCC = new System.Windows.Forms.TextBox();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.tcKhoHang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "QUẢN LÝ KHO HÀNG";
            // 
            // btnTabNhapKho
            // 
            this.btnTabNhapKho.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTabNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabNhapKho.FlatAppearance.BorderSize = 0;
            this.btnTabNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabNhapKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnTabNhapKho.Location = new System.Drawing.Point(12, 51);
            this.btnTabNhapKho.Name = "btnTabNhapKho";
            this.btnTabNhapKho.Size = new System.Drawing.Size(161, 31);
            this.btnTabNhapKho.TabIndex = 6;
            this.btnTabNhapKho.Text = "Lịch sử nhập kho";
            this.btnTabNhapKho.UseVisualStyleBackColor = false;
            // 
            // btnTabTonKho
            // 
            this.btnTabTonKho.BackColor = System.Drawing.Color.White;
            this.btnTabTonKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabTonKho.FlatAppearance.BorderSize = 0;
            this.btnTabTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTonKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabTonKho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTabTonKho.Location = new System.Drawing.Point(223, 51);
            this.btnTabTonKho.Name = "btnTabTonKho";
            this.btnTabTonKho.Size = new System.Drawing.Size(97, 31);
            this.btnTabTonKho.TabIndex = 7;
            this.btnTabTonKho.Text = "Tồn kho";
            this.btnTabTonKho.UseVisualStyleBackColor = false;
            // 
            // btnTabNCC
            // 
            this.btnTabNCC.BackColor = System.Drawing.Color.White;
            this.btnTabNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabNCC.FlatAppearance.BorderSize = 0;
            this.btnTabNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabNCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabNCC.Location = new System.Drawing.Point(546, 51);
            this.btnTabNCC.Name = "btnTabNCC";
            this.btnTabNCC.Size = new System.Drawing.Size(128, 31);
            this.btnTabNCC.TabIndex = 9;
            this.btnTabNCC.Text = "Nhà cung cấp";
            this.btnTabNCC.UseVisualStyleBackColor = false;
            // 
            // btnTabHoanTra
            // 
            this.btnTabHoanTra.BackColor = System.Drawing.Color.White;
            this.btnTabHoanTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabHoanTra.FlatAppearance.BorderSize = 0;
            this.btnTabHoanTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabHoanTra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabHoanTra.Location = new System.Drawing.Point(356, 51);
            this.btnTabHoanTra.Name = "btnTabHoanTra";
            this.btnTabHoanTra.Size = new System.Drawing.Size(149, 31);
            this.btnTabHoanTra.TabIndex = 8;
            this.btnTabHoanTra.Text = "Khách hoàn trả";
            this.btnTabHoanTra.UseVisualStyleBackColor = false;
            this.btnTabHoanTra.Click += new System.EventHandler(this.btnTabHoanTra_Click_1);
            // 
            // tcKhoHang
            // 
            this.tcKhoHang.Controls.Add(this.tabPage1);
            this.tcKhoHang.Controls.Add(this.tabPage2);
            this.tcKhoHang.Controls.Add(this.tabPage3);
            this.tcKhoHang.Controls.Add(this.tabPage4);
            this.tcKhoHang.ItemSize = new System.Drawing.Size(0, 1);
            this.tcKhoHang.Location = new System.Drawing.Point(12, 100);
            this.tcKhoHang.Name = "tcKhoHang";
            this.tcKhoHang.SelectedIndex = 0;
            this.tcKhoHang.Size = new System.Drawing.Size(796, 491);
            this.tcKhoHang.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcKhoHang.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblTongPhieuNhap);
            this.tabPage1.Controls.Add(this.btnXoaPhieu);
            this.tabPage1.Controls.Add(this.dgvPhieuNhap);
            this.tabPage1.Controls.Add(this.btnTimPhieu);
            this.tabPage1.Controls.Add(this.txtTimPhieu);
            this.tabPage1.Controls.Add(this.btnLocNhap);
            this.tabPage1.Controls.Add(this.dtpDenNgay);
            this.tabPage1.Controls.Add(this.dtpTuNgay);
            this.tabPage1.Controls.Add(this.btnTaoPhieuMoi);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // lblTongPhieuNhap
            // 
            this.lblTongPhieuNhap.AutoSize = true;
            this.lblTongPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongPhieuNhap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTongPhieuNhap.Location = new System.Drawing.Point(6, 52);
            this.lblTongPhieuNhap.Name = "lblTongPhieuNhap";
            this.lblTongPhieuNhap.Size = new System.Drawing.Size(0, 19);
            this.lblTongPhieuNhap.TabIndex = 8;
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoaPhieu.FlatAppearance.BorderSize = 0;
            this.btnXoaPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieu.Location = new System.Drawing.Point(207, 7);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(183, 31);
            this.btnXoaPhieu.TabIndex = 7;
            this.btnXoaPhieu.Text = "XÓA PHIẾU ";
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPN,
            this.colNgayNhap,
            this.colTenNCC,
            this.colTongTien,
            this.colNguoiLap});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(7, 78);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(773, 398);
            this.dgvPhieuNhap.TabIndex = 6;
            // 
            // colMaPN
            // 
            this.colMaPN.DataPropertyName = "sMaPN";
            this.colMaPN.HeaderText = "Mã PN";
            this.colMaPN.MinimumWidth = 6;
            this.colMaPN.Name = "colMaPN";
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "dNgayNhap";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.colNgayNhap.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNgayNhap.HeaderText = "Ngày Nhập";
            this.colNgayNhap.MinimumWidth = 6;
            this.colNgayNhap.Name = "colNgayNhap";
            // 
            // colTenNCC
            // 
            this.colTenNCC.DataPropertyName = "sTenNCC";
            this.colTenNCC.HeaderText = "Nhà Cung Cấp";
            this.colTenNCC.MinimumWidth = 6;
            this.colTenNCC.Name = "colTenNCC";
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "fTongTien";
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.MinimumWidth = 6;
            this.colTongTien.Name = "colTongTien";
            // 
            // colNguoiLap
            // 
            this.colNguoiLap.DataPropertyName = "sTenNV";
            this.colNguoiLap.HeaderText = "Người Lập";
            this.colNguoiLap.MinimumWidth = 6;
            this.colNguoiLap.Name = "colNguoiLap";
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimPhieu.FlatAppearance.BorderSize = 0;
            this.btnTimPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimPhieu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhieu.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieu.Location = new System.Drawing.Point(705, 43);
            this.btnTimPhieu.Name = "btnTimPhieu";
            this.btnTimPhieu.Size = new System.Drawing.Size(75, 25);
            this.btnTimPhieu.TabIndex = 5;
            this.btnTimPhieu.Text = "Tìm";
            this.btnTimPhieu.UseVisualStyleBackColor = false;
            // 
            // txtTimPhieu
            // 
            this.txtTimPhieu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimPhieu.Location = new System.Drawing.Point(460, 46);
            this.txtTimPhieu.Name = "txtTimPhieu";
            this.txtTimPhieu.Size = new System.Drawing.Size(230, 21);
            this.txtTimPhieu.TabIndex = 4;
            this.txtTimPhieu.Text = "Tìm phiếu nhập...";
            // 
            // btnLocNhap
            // 
            this.btnLocNhap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLocNhap.FlatAppearance.BorderSize = 0;
            this.btnLocNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocNhap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocNhap.ForeColor = System.Drawing.Color.White;
            this.btnLocNhap.Location = new System.Drawing.Point(705, 13);
            this.btnLocNhap.Name = "btnLocNhap";
            this.btnLocNhap.Size = new System.Drawing.Size(75, 25);
            this.btnLocNhap.TabIndex = 3;
            this.btnLocNhap.Text = "Lọc";
            this.btnLocNhap.UseVisualStyleBackColor = false;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(578, 17);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(112, 21);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(460, 17);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(112, 21);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // btnTaoPhieuMoi
            // 
            this.btnTaoPhieuMoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaoPhieuMoi.FlatAppearance.BorderSize = 0;
            this.btnTaoPhieuMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieuMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoPhieuMoi.Location = new System.Drawing.Point(7, 7);
            this.btnTaoPhieuMoi.Name = "btnTaoPhieuMoi";
            this.btnTaoPhieuMoi.Size = new System.Drawing.Size(183, 31);
            this.btnTaoPhieuMoi.TabIndex = 0;
            this.btnTaoPhieuMoi.Text = "+ TẠO PHIẾU MỚI";
            this.btnTaoPhieuMoi.UseVisualStyleBackColor = false;
            this.btnTaoPhieuMoi.Click += new System.EventHandler(this.btnTaoPhieuMoi_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lblTongTonKho);
            this.tabPage2.Controls.Add(this.dgvTonKho);
            this.tabPage2.Controls.Add(this.btnTimTonKho);
            this.tabPage2.Controls.Add(this.txtTimTonKho);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lblTongTonKho
            // 
            this.lblTongTonKho.AutoSize = true;
            this.lblTongTonKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTonKho.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTongTonKho.Location = new System.Drawing.Point(6, 18);
            this.lblTongTonKho.Name = "lblTongTonKho";
            this.lblTongTonKho.Size = new System.Drawing.Size(0, 19);
            this.lblTongTonKho.TabIndex = 10;
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AllowUserToAddRows = false;
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSKU,
            this.colTenGiay,
            this.colSize,
            this.colMauSac,
            this.colSoLuongTon});
            this.dgvTonKho.Location = new System.Drawing.Point(10, 50);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.RowHeadersWidth = 51;
            this.dgvTonKho.RowTemplate.Height = 24;
            this.dgvTonKho.Size = new System.Drawing.Size(758, 426);
            this.dgvTonKho.TabIndex = 9;
            // 
            // colSKU
            // 
            this.colSKU.DataPropertyName = "sMaSKU";
            this.colSKU.HeaderText = "Mã SKU";
            this.colSKU.MinimumWidth = 6;
            this.colSKU.Name = "colSKU";
            // 
            // colTenGiay
            // 
            this.colTenGiay.DataPropertyName = "sTenMau";
            this.colTenGiay.HeaderText = "Tên Giày";
            this.colTenGiay.MinimumWidth = 6;
            this.colTenGiay.Name = "colTenGiay";
            // 
            // colSize
            // 
            this.colSize.DataPropertyName = "iGiaTriSize";
            this.colSize.HeaderText = "Size";
            this.colSize.MinimumWidth = 6;
            this.colSize.Name = "colSize";
            // 
            // colMauSac
            // 
            this.colMauSac.DataPropertyName = "TenMauSac";
            this.colMauSac.HeaderText = "Màu Sắc";
            this.colMauSac.MinimumWidth = 6;
            this.colMauSac.Name = "colMauSac";
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "iSoLuong";
            this.colSoLuongTon.HeaderText = "Số Lượng Tồn";
            this.colSoLuongTon.MinimumWidth = 6;
            this.colSoLuongTon.Name = "colSoLuongTon";
            // 
            // btnTimTonKho
            // 
            this.btnTimTonKho.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimTonKho.FlatAppearance.BorderSize = 0;
            this.btnTimTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTonKho.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTonKho.ForeColor = System.Drawing.Color.White;
            this.btnTimTonKho.Location = new System.Drawing.Point(1000, 19);
            this.btnTimTonKho.Name = "btnTimTonKho";
            this.btnTimTonKho.Size = new System.Drawing.Size(75, 25);
            this.btnTimTonKho.TabIndex = 8;
            this.btnTimTonKho.Text = "Tìm";
            this.btnTimTonKho.UseVisualStyleBackColor = false;
            // 
            // txtTimTonKho
            // 
            this.txtTimTonKho.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTonKho.Location = new System.Drawing.Point(538, 16);
            this.txtTimTonKho.Name = "txtTimTonKho";
            this.txtTimTonKho.Size = new System.Drawing.Size(230, 21);
            this.txtTimTonKho.TabIndex = 7;
            this.txtTimTonKho.Text = "Tìm mã SKU hoặc Tên giày...";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.lblTongPhieuTra);
            this.tabPage3.Controls.Add(this.dgvPhieuTra);
            this.tabPage3.Controls.Add(this.btnLocTra);
            this.tabPage3.Controls.Add(this.dtpDenNgayTra);
            this.tabPage3.Controls.Add(this.dtpTuNgayTra);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // lblTongPhieuTra
            // 
            this.lblTongPhieuTra.AutoSize = true;
            this.lblTongPhieuTra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongPhieuTra.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTongPhieuTra.Location = new System.Drawing.Point(6, 26);
            this.lblTongPhieuTra.Name = "lblTongPhieuTra";
            this.lblTongPhieuTra.Size = new System.Drawing.Size(0, 19);
            this.lblTongPhieuTra.TabIndex = 11;
            // 
            // dgvPhieuTra
            // 
            this.dgvPhieuTra.AllowUserToAddRows = false;
            this.dgvPhieuTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuTra.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPT,
            this.colMaHD,
            this.colNgayTra,
            this.colLyDo,
            this.colTienHoan});
            this.dgvPhieuTra.Location = new System.Drawing.Point(7, 50);
            this.dgvPhieuTra.Name = "dgvPhieuTra";
            this.dgvPhieuTra.RowHeadersWidth = 51;
            this.dgvPhieuTra.RowTemplate.Height = 24;
            this.dgvPhieuTra.Size = new System.Drawing.Size(769, 426);
            this.dgvPhieuTra.TabIndex = 10;
            // 
            // colMaPT
            // 
            this.colMaPT.DataPropertyName = "sMaPT";
            this.colMaPT.HeaderText = "Mã PT";
            this.colMaPT.MinimumWidth = 6;
            this.colMaPT.Name = "colMaPT";
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "sMaHD";
            this.colMaHD.HeaderText = "Mã Hóa Đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            // 
            // colNgayTra
            // 
            this.colNgayTra.DataPropertyName = "dNgayTra";
            this.colNgayTra.HeaderText = "Ngày Trả";
            this.colNgayTra.MinimumWidth = 6;
            this.colNgayTra.Name = "colNgayTra";
            // 
            // colLyDo
            // 
            this.colLyDo.DataPropertyName = "sLyDo";
            this.colLyDo.HeaderText = "Lý Do Trả";
            this.colLyDo.MinimumWidth = 6;
            this.colLyDo.Name = "colLyDo";
            // 
            // colTienHoan
            // 
            this.colTienHoan.DataPropertyName = "fTongTienHoan";
            this.colTienHoan.HeaderText = "Tiền Hoàn";
            this.colTienHoan.MinimumWidth = 6;
            this.colTienHoan.Name = "colTienHoan";
            // 
            // btnLocTra
            // 
            this.btnLocTra.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLocTra.FlatAppearance.BorderSize = 0;
            this.btnLocTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocTra.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTra.ForeColor = System.Drawing.Color.White;
            this.btnLocTra.Location = new System.Drawing.Point(881, 9);
            this.btnLocTra.Name = "btnLocTra";
            this.btnLocTra.Size = new System.Drawing.Size(75, 25);
            this.btnLocTra.TabIndex = 9;
            this.btnLocTra.Text = "Lọc";
            this.btnLocTra.UseVisualStyleBackColor = false;
            // 
            // dtpDenNgayTra
            // 
            this.dtpDenNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgayTra.Location = new System.Drawing.Point(664, 9);
            this.dtpDenNgayTra.Name = "dtpDenNgayTra";
            this.dtpDenNgayTra.Size = new System.Drawing.Size(112, 21);
            this.dtpDenNgayTra.TabIndex = 8;
            // 
            // dtpTuNgayTra
            // 
            this.dtpTuNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgayTra.Location = new System.Drawing.Point(546, 9);
            this.dtpTuNgayTra.Name = "dtpTuNgayTra";
            this.dtpTuNgayTra.Size = new System.Drawing.Size(112, 21);
            this.dtpTuNgayTra.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.lblTongNCC);
            this.tabPage4.Controls.Add(this.btnXoaNCC);
            this.tabPage4.Controls.Add(this.btnSuaNCC);
            this.tabPage4.Controls.Add(this.dgvNCC);
            this.tabPage4.Controls.Add(this.btnTimNCC);
            this.tabPage4.Controls.Add(this.txtTimNCC);
            this.tabPage4.Controls.Add(this.btnThemNCC);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(788, 482);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // lblTongNCC
            // 
            this.lblTongNCC.AutoSize = true;
            this.lblTongNCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNCC.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTongNCC.Location = new System.Drawing.Point(6, 53);
            this.lblTongNCC.Name = "lblTongNCC";
            this.lblTongNCC.Size = new System.Drawing.Size(0, 19);
            this.lblTongNCC.TabIndex = 13;
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoaNCC.FlatAppearance.BorderSize = 0;
            this.btnXoaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.ForeColor = System.Drawing.Color.White;
            this.btnXoaNCC.Location = new System.Drawing.Point(343, 19);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(138, 31);
            this.btnXoaNCC.TabIndex = 12;
            this.btnXoaNCC.Text = "XÓA THÔNG TIN";
            this.btnXoaNCC.UseVisualStyleBackColor = false;
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSuaNCC.FlatAppearance.BorderSize = 0;
            this.btnSuaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNCC.ForeColor = System.Drawing.Color.White;
            this.btnSuaNCC.Location = new System.Drawing.Point(199, 19);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(138, 31);
            this.btnSuaNCC.TabIndex = 11;
            this.btnSuaNCC.Text = "SỬA THÔNG TIN";
            this.btnSuaNCC.UseVisualStyleBackColor = false;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC_Tab4,
            this.colTenNCC_Tab4,
            this.colSDT_Tab4,
            this.colDiaChi_Tab4});
            this.dgvNCC.Location = new System.Drawing.Point(3, 77);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(758, 399);
            this.dgvNCC.TabIndex = 10;
            // 
            // colMaNCC_Tab4
            // 
            this.colMaNCC_Tab4.DataPropertyName = "sMaNCC";
            this.colMaNCC_Tab4.HeaderText = "Mã NCC";
            this.colMaNCC_Tab4.MinimumWidth = 6;
            this.colMaNCC_Tab4.Name = "colMaNCC_Tab4";
            // 
            // colTenNCC_Tab4
            // 
            this.colTenNCC_Tab4.DataPropertyName = "sTenNCC";
            this.colTenNCC_Tab4.HeaderText = "Tên Nhà Cung Cấp";
            this.colTenNCC_Tab4.MinimumWidth = 6;
            this.colTenNCC_Tab4.Name = "colTenNCC_Tab4";
            // 
            // colSDT_Tab4
            // 
            this.colSDT_Tab4.DataPropertyName = "sDienThoai";
            this.colSDT_Tab4.HeaderText = "Số Điện Thoại";
            this.colSDT_Tab4.MinimumWidth = 6;
            this.colSDT_Tab4.Name = "colSDT_Tab4";
            // 
            // colDiaChi_Tab4
            // 
            this.colDiaChi_Tab4.DataPropertyName = "sDiaChi";
            this.colDiaChi_Tab4.HeaderText = "Địa Chỉ";
            this.colDiaChi_Tab4.MinimumWidth = 6;
            this.colDiaChi_Tab4.Name = "colDiaChi_Tab4";
            // 
            // btnTimNCC
            // 
            this.btnTimNCC.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimNCC.FlatAppearance.BorderSize = 0;
            this.btnTimNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNCC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNCC.ForeColor = System.Drawing.Color.White;
            this.btnTimNCC.Location = new System.Drawing.Point(686, 25);
            this.btnTimNCC.Name = "btnTimNCC";
            this.btnTimNCC.Size = new System.Drawing.Size(75, 25);
            this.btnTimNCC.TabIndex = 9;
            this.btnTimNCC.Text = "Tìm";
            this.btnTimNCC.UseVisualStyleBackColor = false;
            // 
            // txtTimNCC
            // 
            this.txtTimNCC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNCC.Location = new System.Drawing.Point(487, 27);
            this.txtTimNCC.Name = "txtTimNCC";
            this.txtTimNCC.Size = new System.Drawing.Size(188, 21);
            this.txtTimNCC.TabIndex = 8;
            this.txtTimNCC.Text = "Tìm tên, SĐT...";
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemNCC.FlatAppearance.BorderSize = 0;
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.White;
            this.btnThemNCC.Location = new System.Drawing.Point(6, 19);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(187, 31);
            this.btnThemNCC.TabIndex = 7;
            this.btnThemNCC.Text = "+ THÊM NHÀ CUNG CẤP";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // FormKhoGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(814, 603);
            this.Controls.Add(this.tcKhoHang);
            this.Controls.Add(this.btnTabNCC);
            this.Controls.Add(this.btnTabHoanTra);
            this.Controls.Add(this.btnTabTonKho);
            this.Controls.Add(this.btnTabNhapKho);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormKhoGiay";
            this.Text = "FormKhoGiay";
            this.Load += new System.EventHandler(this.FormKhoGiay_Load);
            this.tcKhoHang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTabNhapKho;
        private System.Windows.Forms.Button btnTabTonKho;
        private System.Windows.Forms.Button btnTabNCC;
        private System.Windows.Forms.Button btnTabHoanTra;
        private System.Windows.Forms.TabControl tcKhoHang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Button btnTaoPhieuMoi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTimPhieu;
        private System.Windows.Forms.TextBox txtTimPhieu;
        private System.Windows.Forms.Button btnLocNhap;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.Button btnTimTonKho;
        private System.Windows.Forms.TextBox txtTimTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridView dgvPhieuTra;
        private System.Windows.Forms.Button btnLocTra;
        private System.Windows.Forms.DateTimePicker dtpDenNgayTra;
        private System.Windows.Forms.DateTimePicker dtpTuNgayTra;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Button btnTimNCC;
        private System.Windows.Forms.TextBox txtTimNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC_Tab4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC_Tab4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT_Tab4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi_Tab4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienHoan;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Label lblTongPhieuNhap;
        private System.Windows.Forms.Label lblTongTonKho;
        private System.Windows.Forms.Label lblTongPhieuTra;
        private System.Windows.Forms.Label lblTongNCC;
    }
}

