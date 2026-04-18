namespace BTL_QLCHG.Views
{
    partial class FormChiTietKhuyenMai
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
            this.lblChiTietKhuyenMai = new System.Windows.Forms.Label();
            this.roundPanel1 = new BTL_QLCHG.Utils.RoundPanel();
            this.lblMaKM = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.lblTenKM = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChiTietKhuyenMai
            // 
            this.lblChiTietKhuyenMai.AutoSize = true;
            this.lblChiTietKhuyenMai.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietKhuyenMai.ForeColor = System.Drawing.Color.Navy;
            this.lblChiTietKhuyenMai.Location = new System.Drawing.Point(56, 43);
            this.lblChiTietKhuyenMai.Name = "lblChiTietKhuyenMai";
            this.lblChiTietKhuyenMai.Size = new System.Drawing.Size(212, 31);
            this.lblChiTietKhuyenMai.TabIndex = 14;
            this.lblChiTietKhuyenMai.Text = "Chi tiết khuyến mại";
            this.lblChiTietKhuyenMai.Click += new System.EventHandler(this.lblChiTietKhuyenMai_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.Controls.Add(this.lblMaKM);
            this.roundPanel1.Controls.Add(this.txtMaKM);
            this.roundPanel1.Controls.Add(this.lblTenKM);
            this.roundPanel1.Controls.Add(this.btnHuy);
            this.roundPanel1.Controls.Add(this.txtTenKM);
            this.roundPanel1.Controls.Add(this.txtGiamGia);
            this.roundPanel1.Controls.Add(this.btnLuu);
            this.roundPanel1.Controls.Add(this.lblGiamGia);
            this.roundPanel1.Controls.Add(this.dtpNgayKetThuc);
            this.roundPanel1.Controls.Add(this.label3);
            this.roundPanel1.Controls.Add(this.lblNgayKetThuc);
            this.roundPanel1.Controls.Add(this.dtpNgayBatDau);
            this.roundPanel1.Controls.Add(this.lblNgayBatDau);
            this.roundPanel1.Controls.Add(this.txtMoTa);
            this.roundPanel1.Location = new System.Drawing.Point(46, 90);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(1019, 409);
            this.roundPanel1.TabIndex = 15;
            // 
            // lblMaKM
            // 
            this.lblMaKM.AutoSize = true;
            this.lblMaKM.Location = new System.Drawing.Point(38, 40);
            this.lblMaKM.Name = "lblMaKM";
            this.lblMaKM.Size = new System.Drawing.Size(51, 16);
            this.lblMaKM.TabIndex = 3;
            this.lblMaKM.Text = "Mã KM:";
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(41, 77);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(460, 22);
            this.txtMaKM.TabIndex = 0;
            // 
            // lblTenKM
            // 
            this.lblTenKM.AutoSize = true;
            this.lblTenKM.Location = new System.Drawing.Point(534, 40);
            this.lblTenKM.Name = "lblTenKM";
            this.lblTenKM.Size = new System.Drawing.Size(56, 16);
            this.lblTenKM.TabIndex = 4;
            this.lblTenKM.Text = "Tên KM:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(537, 332);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(445, 37);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Location = new System.Drawing.Point(537, 77);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(460, 22);
            this.txtTenKM.TabIndex = 1;
            this.txtTenKM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(41, 257);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(460, 22);
            this.txtGiamGia.TabIndex = 11;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(41, 332);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(445, 37);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(38, 221);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(64, 16);
            this.lblGiamGia.TabIndex = 10;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(537, 164);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(460, 22);
            this.dtpNgayKetThuc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả:";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(534, 130);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(94, 16);
            this.lblNgayKetThuc.TabIndex = 7;
            this.lblNgayKetThuc.Text = "Ngày kết thúc :";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(41, 164);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(460, 22);
            this.dtpNgayBatDau.TabIndex = 8;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(38, 130);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(91, 16);
            this.lblNgayBatDau.TabIndex = 6;
            this.lblNgayBatDau.Text = "Ngày bắt đầu:";
            this.lblNgayBatDau.Click += new System.EventHandler(this.lblNgayBatDau_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(537, 257);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(460, 22);
            this.txtMoTa.TabIndex = 2;
            this.txtMoTa.TextChanged += new System.EventHandler(this.txtMoTa_TextChanged);
            // 
            // FormChiTietKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 554);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.lblChiTietKhuyenMai);
            this.Name = "FormChiTietKhuyenMai";
            this.Text = "FormChiTietKhuyenMai";
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMaKM;
        private System.Windows.Forms.Label lblTenKM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblChiTietKhuyenMai;
        private Utils.RoundPanel roundPanel1;
    }
}