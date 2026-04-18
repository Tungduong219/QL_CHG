namespace donhang
{
    partial class FormDonHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.btnCapNhatGiaoHang = new System.Windows.Forms.Button();
            this.btnTabHoanTra = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnTabGiaoHang = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTabTatCa = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.tcDonHang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTatCa = new System.Windows.Forms.DataGridView();
            this.colMa_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhach_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTien_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvGiaoHang = new System.Windows.Forms.DataGridView();
            this.colMa_GH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVanDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvHoanTra = new System.Windows.Forms.DataGridView();
            this.colMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHD_HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienHoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDonHang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTatCa)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoHang)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoanTra)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.label2.UseWaitCursor = true;
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHuyDon.FlatAppearance.BorderSize = 0;
            this.btnHuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyDon.Location = new System.Drawing.Point(447, 511);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(187, 31);
            this.btnHuyDon.TabIndex = 28;
            this.btnHuyDon.Text = "Hủy đơn / Trả hàng";
            this.btnHuyDon.UseVisualStyleBackColor = false;
            this.btnHuyDon.UseWaitCursor = true;
            // 
            // btnCapNhatGiaoHang
            // 
            this.btnCapNhatGiaoHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCapNhatGiaoHang.FlatAppearance.BorderSize = 0;
            this.btnCapNhatGiaoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatGiaoHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatGiaoHang.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatGiaoHang.Location = new System.Drawing.Point(668, 511);
            this.btnCapNhatGiaoHang.Name = "btnCapNhatGiaoHang";
            this.btnCapNhatGiaoHang.Size = new System.Drawing.Size(186, 31);
            this.btnCapNhatGiaoHang.TabIndex = 27;
            this.btnCapNhatGiaoHang.Text = "Cập nhật giao hàng";
            this.btnCapNhatGiaoHang.UseVisualStyleBackColor = false;
            this.btnCapNhatGiaoHang.UseWaitCursor = true;
            // 
            // btnTabHoanTra
            // 
            this.btnTabHoanTra.BackColor = System.Drawing.Color.White;
            this.btnTabHoanTra.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnTabHoanTra.FlatAppearance.BorderSize = 0;
            this.btnTabHoanTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabHoanTra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabHoanTra.Location = new System.Drawing.Point(378, 61);
            this.btnTabHoanTra.Name = "btnTabHoanTra";
            this.btnTabHoanTra.Size = new System.Drawing.Size(149, 31);
            this.btnTabHoanTra.TabIndex = 23;
            this.btnTabHoanTra.Text = "Hoàn trả";
            this.btnTabHoanTra.UseVisualStyleBackColor = false;
            this.btnTabHoanTra.UseWaitCursor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXemChiTiet.FlatAppearance.BorderSize = 0;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(280, 511);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(128, 31);
            this.btnXemChiTiet.TabIndex = 18;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.UseWaitCursor = true;
            // 
            // btnTabGiaoHang
            // 
            this.btnTabGiaoHang.BackColor = System.Drawing.Color.White;
            this.btnTabGiaoHang.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnTabGiaoHang.FlatAppearance.BorderSize = 0;
            this.btnTabGiaoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabGiaoHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabGiaoHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTabGiaoHang.Location = new System.Drawing.Point(221, 61);
            this.btnTabGiaoHang.Name = "btnTabGiaoHang";
            this.btnTabGiaoHang.Size = new System.Drawing.Size(127, 31);
            this.btnTabGiaoHang.TabIndex = 21;
            this.btnTabGiaoHang.Text = "Giao hàng";
            this.btnTabGiaoHang.UseVisualStyleBackColor = false;
            this.btnTabGiaoHang.UseWaitCursor = true;
            this.btnTabGiaoHang.Click += new System.EventHandler(this.btnTabGiaoHang_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(1022, 111);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 25);
            this.btnTim.TabIndex = 26;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.UseWaitCursor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(773, 111);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(230, 21);
            this.txtTimKiem.TabIndex = 25;
            this.txtTimKiem.Text = "Tìm đơn hàng ...";
            this.txtTimKiem.UseWaitCursor = true;
            // 
            // btnTabTatCa
            // 
            this.btnTabTatCa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTabTatCa.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnTabTatCa.FlatAppearance.BorderSize = 0;
            this.btnTabTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTatCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTabTatCa.Location = new System.Drawing.Point(16, 61);
            this.btnTabTatCa.Name = "btnTabTatCa";
            this.btnTabTatCa.Size = new System.Drawing.Size(161, 31);
            this.btnTabTatCa.TabIndex = 19;
            this.btnTabTatCa.Text = "Tất cả đơn hàng";
            this.btnTabTatCa.UseVisualStyleBackColor = false;
            this.btnTabTatCa.UseWaitCursor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(1022, 79);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 25);
            this.btnLoc.TabIndex = 24;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.UseWaitCursor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(773, 79);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(112, 21);
            this.dtpTuNgay.TabIndex = 20;
            this.dtpTuNgay.UseWaitCursor = true;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(891, 79);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(112, 21);
            this.dtpDenNgay.TabIndex = 22;
            this.dtpDenNgay.UseWaitCursor = true;
            // 
            // tcDonHang
            // 
            this.tcDonHang.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcDonHang.Controls.Add(this.tabPage1);
            this.tcDonHang.Controls.Add(this.tabPage2);
            this.tcDonHang.Controls.Add(this.tabPage3);
            this.tcDonHang.ItemSize = new System.Drawing.Size(0, 1);
            this.tcDonHang.Location = new System.Drawing.Point(14, 166);
            this.tcDonHang.Name = "tcDonHang";
            this.tcDonHang.SelectedIndex = 0;
            this.tcDonHang.Size = new System.Drawing.Size(1084, 329);
            this.tcDonHang.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcDonHang.TabIndex = 30;
            this.tcDonHang.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTatCa);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // dgvTatCa
            // 
            this.dgvTatCa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTatCa.BackgroundColor = System.Drawing.Color.White;
            this.dgvTatCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTatCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa_TC,
            this.colKhach_TC,
            this.colNgay_TC,
            this.colTien_TC});
            this.dgvTatCa.Location = new System.Drawing.Point(7, 7);
            this.dgvTatCa.Name = "dgvTatCa";
            this.dgvTatCa.ReadOnly = true;
            this.dgvTatCa.RowHeadersWidth = 51;
            this.dgvTatCa.RowTemplate.Height = 24;
            this.dgvTatCa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTatCa.Size = new System.Drawing.Size(1063, 280);
            this.dgvTatCa.TabIndex = 0;
            this.dgvTatCa.UseWaitCursor = true;
            // 
            // colMa_TC
            // 
            this.colMa_TC.DataPropertyName = "sMaHD";
            this.colMa_TC.HeaderText = "Mã HĐ";
            this.colMa_TC.MinimumWidth = 6;
            this.colMa_TC.Name = "colMa_TC";
            this.colMa_TC.ReadOnly = true;
            // 
            // colKhach_TC
            // 
            this.colKhach_TC.DataPropertyName = "sTenKH";
            this.colKhach_TC.HeaderText = "Tên Khách Hàng";
            this.colKhach_TC.MinimumWidth = 6;
            this.colKhach_TC.Name = "colKhach_TC";
            this.colKhach_TC.ReadOnly = true;
            // 
            // colNgay_TC
            // 
            this.colNgay_TC.DataPropertyName = "dNgayBan";
            this.colNgay_TC.HeaderText = "Ngày Bán";
            this.colNgay_TC.MinimumWidth = 6;
            this.colNgay_TC.Name = "colNgay_TC";
            this.colNgay_TC.ReadOnly = true;
            // 
            // colTien_TC
            // 
            this.colTien_TC.DataPropertyName = "fTongTien";
            this.colTien_TC.HeaderText = "Tổng Tiền";
            this.colTien_TC.MinimumWidth = 6;
            this.colTien_TC.Name = "colTien_TC";
            this.colTien_TC.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvGiaoHang);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // dgvGiaoHang
            // 
            this.dgvGiaoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa_GH,
            this.colVanDon,
            this.colDonVi,
            this.colTrangThai});
            this.dgvGiaoHang.Location = new System.Drawing.Point(7, 5);
            this.dgvGiaoHang.Name = "dgvGiaoHang";
            this.dgvGiaoHang.ReadOnly = true;
            this.dgvGiaoHang.RowHeadersWidth = 51;
            this.dgvGiaoHang.RowTemplate.Height = 24;
            this.dgvGiaoHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoHang.Size = new System.Drawing.Size(1063, 280);
            this.dgvGiaoHang.TabIndex = 1;
            this.dgvGiaoHang.UseWaitCursor = true;
            // 
            // colMa_GH
            // 
            this.colMa_GH.DataPropertyName = "sMaHD";
            this.colMa_GH.HeaderText = "Mã HĐ";
            this.colMa_GH.MinimumWidth = 6;
            this.colMa_GH.Name = "colMa_GH";
            this.colMa_GH.ReadOnly = true;
            // 
            // colVanDon
            // 
            this.colVanDon.DataPropertyName = "sMaVanDon";
            this.colVanDon.HeaderText = "Mã Vận Đơn";
            this.colVanDon.MinimumWidth = 6;
            this.colVanDon.Name = "colVanDon";
            this.colVanDon.ReadOnly = true;
            // 
            // colDonVi
            // 
            this.colDonVi.DataPropertyName = "sDonViVanChuyen";
            this.colDonVi.HeaderText = "Đơn Vị Giao";
            this.colDonVi.MinimumWidth = 6;
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvHoanTra);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1076, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.UseWaitCursor = true;
            // 
            // dgvHoanTra
            // 
            this.dgvHoanTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoanTra.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoanTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoanTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPT,
            this.colMaHD_HT,
            this.colLyDo,
            this.colTienHoan});
            this.dgvHoanTra.Location = new System.Drawing.Point(7, 5);
            this.dgvHoanTra.Name = "dgvHoanTra";
            this.dgvHoanTra.ReadOnly = true;
            this.dgvHoanTra.RowHeadersWidth = 51;
            this.dgvHoanTra.RowTemplate.Height = 24;
            this.dgvHoanTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoanTra.Size = new System.Drawing.Size(1063, 280);
            this.dgvHoanTra.TabIndex = 2;
            this.dgvHoanTra.UseWaitCursor = true;
            // 
            // colMaPT
            // 
            this.colMaPT.DataPropertyName = "sMaPT";
            this.colMaPT.HeaderText = "Mã Phiếu Trả";
            this.colMaPT.MinimumWidth = 6;
            this.colMaPT.Name = "colMaPT";
            this.colMaPT.ReadOnly = true;
            // 
            // colMaHD_HT
            // 
            this.colMaHD_HT.DataPropertyName = "sMaHD";
            this.colMaHD_HT.HeaderText = "Mã HĐ Gốc";
            this.colMaHD_HT.MinimumWidth = 6;
            this.colMaHD_HT.Name = "colMaHD_HT";
            this.colMaHD_HT.ReadOnly = true;
            // 
            // colLyDo
            // 
            this.colLyDo.DataPropertyName = "sLyDo";
            this.colLyDo.HeaderText = "Lý Do Trả";
            this.colLyDo.MinimumWidth = 6;
            this.colLyDo.Name = "colLyDo";
            this.colLyDo.ReadOnly = true;
            // 
            // colTienHoan
            // 
            this.colTienHoan.DataPropertyName = "fTongTienHoan";
            this.colTienHoan.HeaderText = "Tiền Hoàn";
            this.colTienHoan.MinimumWidth = 6;
            this.colTienHoan.Name = "colTienHoan";
            this.colTienHoan.ReadOnly = true;
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 554);
            this.Controls.Add(this.tcDonHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuyDon);
            this.Controls.Add(this.btnCapNhatGiaoHang);
            this.Controls.Add(this.btnTabHoanTra);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnTabGiaoHang);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTabTatCa);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.dtpDenNgay);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDonHang";
            this.Text = "Form Quản Lý Đơn Hàng";
            this.UseWaitCursor = true;
            this.tcDonHang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTatCa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoHang)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoanTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Button btnCapNhatGiaoHang;
        private System.Windows.Forms.Button btnTabHoanTra;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnTabGiaoHang;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTabTatCa;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.TabControl tcDonHang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTatCa;
        private System.Windows.Forms.DataGridView dgvGiaoHang;
        private System.Windows.Forms.DataGridView dgvHoanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhach_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTien_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa_GH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVanDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD_HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienHoan;
    }
}

