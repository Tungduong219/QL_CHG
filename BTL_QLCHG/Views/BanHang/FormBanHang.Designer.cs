namespace BTL_QLCHG.Views
{
    partial class FormBanHang
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
            this.cboKhuyenMai = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.roundPanel1 = new BTL_QLCHG.Utils.RoundPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDanhSachGiay = new System.Windows.Forms.DataGridView();
            this.roundPanel2 = new BTL_QLCHG.Utils.RoundPanel();
            this.lblKhuyenMai = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSDTKhach = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiay)).BeginInit();
            this.roundPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboKhuyenMai
            // 
            this.cboKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhuyenMai.FormattingEnabled = true;
            this.cboKhuyenMai.Location = new System.Drawing.Point(201, 263);
            this.cboKhuyenMai.Name = "cboKhuyenMai";
            this.cboKhuyenMai.Size = new System.Drawing.Size(161, 25);
            this.cboKhuyenMai.TabIndex = 17;
            this.cboKhuyenMai.Text = "  Chọn khuyến mại....";
            this.cboKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cboKhuyenMai_SelectedIndexChanged);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhanVien.Location = new System.Drawing.Point(20, 263);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(161, 25);
            this.cboNhanVien.TabIndex = 15;
            this.cboNhanVien.Text = "  Nhân viên tạo đơn....";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGioHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGioHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.GridColor = System.Drawing.Color.LightGray;
            this.dgvGioHang.Location = new System.Drawing.Point(18, 32);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.Size = new System.Drawing.Size(341, 167);
            this.dgvGioHang.TabIndex = 0;
            this.dgvGioHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellValueChanged);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.ForeColor = System.Drawing.Color.Navy;
            this.lb_timkiem.Location = new System.Drawing.Point(12, 9);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(217, 32);
            this.lb_timkiem.TabIndex = 0;
            this.lb_timkiem.Text = "QUẦY BÁN HÀNG";
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.White;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roundPanel1.Controls.Add(this.txtTimKiem);
            this.roundPanel1.Controls.Add(this.dgvDanhSachGiay);
            this.roundPanel1.Location = new System.Drawing.Point(18, 44);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(438, 432);
            this.roundPanel1.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(12, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(390, 25);
            this.txtTimKiem.TabIndex = 1;
            // 
            // dgvDanhSachGiay
            // 
            this.dgvDanhSachGiay.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDanhSachGiay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGiay.Location = new System.Drawing.Point(12, 41);
            this.dgvDanhSachGiay.Name = "dgvDanhSachGiay";
            this.dgvDanhSachGiay.Size = new System.Drawing.Size(390, 366);
            this.dgvDanhSachGiay.TabIndex = 2;
            this.dgvDanhSachGiay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachGiay_CellDoubleClick);
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.White;
            this.roundPanel2.BorderRadius = 20;
            this.roundPanel2.Controls.Add(this.lblKhuyenMai);
            this.roundPanel2.Controls.Add(this.btnThanhToan);
            this.roundPanel2.Controls.Add(this.label2);
            this.roundPanel2.Controls.Add(this.btnThemKhach);
            this.roundPanel2.Controls.Add(this.lblTenKhach);
            this.roundPanel2.Controls.Add(this.label3);
            this.roundPanel2.Controls.Add(this.lblThanhTien);
            this.roundPanel2.Controls.Add(this.lblTongTien);
            this.roundPanel2.Controls.Add(this.cboNhanVien);
            this.roundPanel2.Controls.Add(this.cboKhuyenMai);
            this.roundPanel2.Controls.Add(this.dgvGioHang);
            this.roundPanel2.Controls.Add(this.txtSDTKhach);
            this.roundPanel2.Controls.Add(this.linkLabel1);
            this.roundPanel2.Controls.Add(this.linkLabel2);
            this.roundPanel2.Controls.Add(this.linkLabel3);
            this.roundPanel2.Location = new System.Drawing.Point(462, 44);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(371, 432);
            this.roundPanel2.TabIndex = 4;
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.AutoSize = true;
            this.lblKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKhuyenMai.Location = new System.Drawing.Point(20, 325);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Size = new System.Drawing.Size(315, 19);
            this.lblKhuyenMai.TabIndex = 14;
            this.lblKhuyenMai.Text = "KHUYẾN MẠI:                                                   0đ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(24, 386);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(335, 32);
            this.btnThanhToan.TabIndex = 12;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "GIỎ HÀNG";
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThemKhach.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhach.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemKhach.ForeColor = System.Drawing.Color.Navy;
            this.btnThemKhach.Location = new System.Drawing.Point(253, 213);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(106, 25);
            this.btnThemKhach.TabIndex = 9;
            this.btnThemKhach.Text = "Thêm khách mới";
            this.btnThemKhach.UseVisualStyleBackColor = false;
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenKhach.Location = new System.Drawing.Point(129, 242);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(60, 19);
            this.lblTenKhach.TabIndex = 8;
            this.lblTenKhach.Text = "Khách lẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "KHÁCH HÀNG :";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThanhTien.Location = new System.Drawing.Point(19, 349);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(314, 19);
            this.lblThanhTien.TabIndex = 3;
            this.lblThanhTien.Text = "THÀNH TIỀN :                                                   0đ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongTien.Location = new System.Drawing.Point(20, 301);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(314, 19);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "TỔNG TIỀN:                                                      0đ";
            // 
            // txtSDTKhach
            // 
            this.txtSDTKhach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSDTKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSDTKhach.Location = new System.Drawing.Point(18, 213);
            this.txtSDTKhach.Name = "txtSDTKhach";
            this.txtSDTKhach.Size = new System.Drawing.Size(212, 25);
            this.txtSDTKhach.TabIndex = 6;
            this.txtSDTKhach.Text = "  Tìm khách hàng(SDT/Tên)....";
            this.txtSDTKhach.TextChanged += new System.EventHandler(this.txtSDTKhach_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(6, 196);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(361, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "                                                                                 " +
    "                                     ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(8, 280);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(361, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "                                                                                 " +
    "                                     ";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(10, 332);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(361, 13);
            this.linkLabel3.TabIndex = 21;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "                                                                                 " +
    "                                     ";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(835, 490);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiay)).EndInit();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDanhSachGiay;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboKhuyenMai;
        private System.Windows.Forms.Label lb_timkiem;
        private Utils.RoundPanel roundPanel1;
        private Utils.RoundPanel roundPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKhuyenMai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtSDTKhach;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}