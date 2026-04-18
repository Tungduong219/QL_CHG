namespace donhang
{
    partial class FormChiTietDon
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDeCT = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.pnlGiaoHang = new System.Windows.Forms.Panel();
            this.lblTrangThaiGiao = new System.Windows.Forms.Label();
            this.lblDonViGiao = new System.Windows.Forms.Label();
            this.pnlHoanTra = new System.Windows.Forms.Panel();
            this.lblTienHoan = new System.Windows.Forms.Label();
            this.lblLyDoTra = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colTenMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlGiaoHang.SuspendLayout();
            this.pnlHoanTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.Controls.Add(this.lblTieuDeCT);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlHeader.Size = new System.Drawing.Size(1113, 70);
            this.pnlHeader.TabIndex = 9;
            // 
            // lblTieuDeCT
            // 
            this.lblTieuDeCT.AutoSize = true;
            this.lblTieuDeCT.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeCT.ForeColor = System.Drawing.Color.White;
            this.lblTieuDeCT.Location = new System.Drawing.Point(504, 20);
            this.lblTieuDeCT.Name = "lblTieuDeCT";
            this.lblTieuDeCT.Size = new System.Drawing.Size(0, 31);
            this.lblTieuDeCT.TabIndex = 7;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(22, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(0, 38);
            this.lblTieuDe.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông tin Hóa Đơn";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Crimson;
            this.lblTongTien.Location = new System.Drawing.Point(524, 194);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(142, 30);
            this.lblTongTien.TabIndex = 15;
            this.lblTongTien.Text = "Tổng tiền: ...";
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBan.Location = new System.Drawing.Point(524, 146);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(104, 25);
            this.lblNgayBan.TabIndex = 14;
            this.lblNgayBan.Text = "Ngày lập: ...";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(22, 194);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(125, 25);
            this.lblTenKH.TabIndex = 12;
            this.lblTenKH.Text = "Khách hàng: ...";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(23, 146);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(86, 25);
            this.lblMaKH.TabIndex = 11;
            this.lblMaKH.Text = "Mã KH: ...";
            // 
            // pnlGiaoHang
            // 
            this.pnlGiaoHang.Controls.Add(this.lblTrangThaiGiao);
            this.pnlGiaoHang.Controls.Add(this.lblDonViGiao);
            this.pnlGiaoHang.Location = new System.Drawing.Point(12, 246);
            this.pnlGiaoHang.Name = "pnlGiaoHang";
            this.pnlGiaoHang.Size = new System.Drawing.Size(1089, 59);
            this.pnlGiaoHang.TabIndex = 16;
            this.pnlGiaoHang.Visible = false;
            // 
            // lblTrangThaiGiao
            // 
            this.lblTrangThaiGiao.AutoSize = true;
            this.lblTrangThaiGiao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiGiao.Location = new System.Drawing.Point(512, 9);
            this.lblTrangThaiGiao.Name = "lblTrangThaiGiao";
            this.lblTrangThaiGiao.Size = new System.Drawing.Size(0, 25);
            this.lblTrangThaiGiao.TabIndex = 18;
            // 
            // lblDonViGiao
            // 
            this.lblDonViGiao.AutoSize = true;
            this.lblDonViGiao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViGiao.Location = new System.Drawing.Point(10, 9);
            this.lblDonViGiao.Name = "lblDonViGiao";
            this.lblDonViGiao.Size = new System.Drawing.Size(0, 25);
            this.lblDonViGiao.TabIndex = 17;
            // 
            // pnlHoanTra
            // 
            this.pnlHoanTra.Controls.Add(this.lblTienHoan);
            this.pnlHoanTra.Controls.Add(this.lblLyDoTra);
            this.pnlHoanTra.Location = new System.Drawing.Point(12, 312);
            this.pnlHoanTra.Name = "pnlHoanTra";
            this.pnlHoanTra.Size = new System.Drawing.Size(1089, 59);
            this.pnlHoanTra.TabIndex = 17;
            this.pnlHoanTra.Visible = false;
            // 
            // lblTienHoan
            // 
            this.lblTienHoan.AutoSize = true;
            this.lblTienHoan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienHoan.Location = new System.Drawing.Point(512, 19);
            this.lblTienHoan.Name = "lblTienHoan";
            this.lblTienHoan.Size = new System.Drawing.Size(0, 25);
            this.lblTienHoan.TabIndex = 19;
            // 
            // lblLyDoTra
            // 
            this.lblLyDoTra.AutoSize = true;
            this.lblLyDoTra.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyDoTra.Location = new System.Drawing.Point(12, 19);
            this.lblLyDoTra.Name = "lblLyDoTra";
            this.lblLyDoTra.Size = new System.Drawing.Size(0, 25);
            this.lblLyDoTra.TabIndex = 18;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMau,
            this.colSize,
            this.colMauSac,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dgvChiTiet.Location = new System.Drawing.Point(12, 378);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(1089, 176);
            this.dgvChiTiet.TabIndex = 18;
            // 
            // colTenMau
            // 
            this.colTenMau.DataPropertyName = "sTenMau";
            this.colTenMau.HeaderText = "Tên giày";
            this.colTenMau.MinimumWidth = 6;
            this.colTenMau.Name = "colTenMau";
            // 
            // colSize
            // 
            this.colSize.DataPropertyName = "iSize";
            this.colSize.HeaderText = "Size";
            this.colSize.MinimumWidth = 6;
            this.colSize.Name = "colSize";
            // 
            // colMauSac
            // 
            this.colMauSac.DataPropertyName = "sMauSac";
            this.colMauSac.HeaderText = "Màu sắc";
            this.colMauSac.MinimumWidth = 6;
            this.colMauSac.Name = "colMauSac";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "iSoLuongBan";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "fDonGiaBan";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // FormChiTietDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 603);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.pnlHoanTra);
            this.Controls.Add(this.pnlGiaoHang);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNgayBan);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormChiTietDon";
            this.Text = "FormChiTietDon";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGiaoHang.ResumeLayout(false);
            this.pnlGiaoHang.PerformLayout();
            this.pnlHoanTra.ResumeLayout(false);
            this.pnlHoanTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDeCT;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Panel pnlGiaoHang;
        private System.Windows.Forms.Label lblTrangThaiGiao;
        private System.Windows.Forms.Label lblDonViGiao;
        private System.Windows.Forms.Panel pnlHoanTra;
        private System.Windows.Forms.Label lblTienHoan;
        private System.Windows.Forms.Label lblLyDoTra;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}