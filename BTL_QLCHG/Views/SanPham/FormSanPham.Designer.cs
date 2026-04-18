namespace BTL_QLBG
{
    partial class FormSanPham
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnMoFormThem = new System.Windows.Forms.Button();
            this.dgvGiay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuanLyThuocTinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.roundPanel1 = new BTL_QLCHG.Utils.RoundPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiay)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(167, 42);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(199, 25);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTimKiem.Location = new System.Drawing.Point(21, 392);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(133, 37);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Sản Phẩm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnMoFormThem
            // 
            this.btnMoFormThem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMoFormThem.Location = new System.Drawing.Point(601, 392);
            this.btnMoFormThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoFormThem.Name = "btnMoFormThem";
            this.btnMoFormThem.Size = new System.Drawing.Size(134, 37);
            this.btnMoFormThem.TabIndex = 2;
            this.btnMoFormThem.Text = "Thêm Sản Phẩm";
            this.btnMoFormThem.UseVisualStyleBackColor = true;
            this.btnMoFormThem.Click += new System.EventHandler(this.btnMoFormThem_Click);
            // 
            // dgvGiay
            // 
            this.dgvGiay.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiay.Location = new System.Drawing.Point(36, 162);
            this.dgvGiay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGiay.Name = "dgvGiay";
            this.dgvGiay.RowHeadersWidth = 51;
            this.dgvGiay.RowTemplate.Height = 24;
            this.dgvGiay.Size = new System.Drawing.Size(714, 267);
            this.dgvGiay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mã SKU:";
            // 
            // btnQuanLyThuocTinh
            // 
            this.btnQuanLyThuocTinh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuanLyThuocTinh.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuanLyThuocTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyThuocTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuanLyThuocTinh.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyThuocTinh.Location = new System.Drawing.Point(563, 45);
            this.btnQuanLyThuocTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuanLyThuocTinh.Name = "btnQuanLyThuocTinh";
            this.btnQuanLyThuocTinh.Size = new System.Drawing.Size(172, 37);
            this.btnQuanLyThuocTinh.TabIndex = 5;
            this.btnQuanLyThuocTinh.Text = "Size Giày, Màu Sắc";
            this.btnQuanLyThuocTinh.UseVisualStyleBackColor = false;
            this.btnQuanLyThuocTinh.Click += new System.EventHandler(this.btnQuanLyThuocTinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "SẢN PHẨM";
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.White;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.Controls.Add(this.txtTimKiem);
            this.roundPanel1.Controls.Add(this.btnQuanLyThuocTinh);
            this.roundPanel1.Controls.Add(this.btnTimKiem);
            this.roundPanel1.Controls.Add(this.btnMoFormThem);
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Location = new System.Drawing.Point(15, 62);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(757, 440);
            this.roundPanel1.TabIndex = 7;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGiay);
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSanPham";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiay)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnMoFormThem;
        private System.Windows.Forms.DataGridView dgvGiay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuanLyThuocTinh;
        private System.Windows.Forms.Label label2;
        private BTL_QLCHG.Utils.RoundPanel roundPanel1;
    }
}

