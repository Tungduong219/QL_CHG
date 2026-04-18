namespace BTL_QLBG
{
    partial class FormThuocTinh
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnQuayLaiSize = new System.Windows.Forms.Button();
            this.lblGiaTriSize = new System.Windows.Forms.Label();
            this.lblMaSize = new System.Windows.Forms.Label();
            this.dgvSize = new System.Windows.Forms.DataGridView();
            this.btnXoaSize = new System.Windows.Forms.Button();
            this.btnThemSize = new System.Windows.Forms.Button();
            this.txtGiaTriSize = new System.Windows.Forms.TextBox();
            this.txtMaSize = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnQuayLaiMau = new System.Windows.Forms.Button();
            this.lblTenMau = new System.Windows.Forms.Label();
            this.lblMaMauSac = new System.Windows.Forms.Label();
            this.dgvMauSac = new System.Windows.Forms.DataGridView();
            this.btnXoaMauSac = new System.Windows.Forms.Button();
            this.btnThemMauSac = new System.Windows.Forms.Button();
            this.txtTenMau = new System.Windows.Forms.TextBox();
            this.txtMaMauSac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanel1 = new BTL_QLCHG.Utils.RoundPanel();
            this.roundPanel2 = new BTL_QLCHG.Utils.RoundPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMauSac)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.roundPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(776, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Size";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnQuayLaiSize
            // 
            this.btnQuayLaiSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuayLaiSize.Location = new System.Drawing.Point(26, 391);
            this.btnQuayLaiSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuayLaiSize.Name = "btnQuayLaiSize";
            this.btnQuayLaiSize.Size = new System.Drawing.Size(94, 32);
            this.btnQuayLaiSize.TabIndex = 7;
            this.btnQuayLaiSize.Text = "Quay lại";
            this.btnQuayLaiSize.UseVisualStyleBackColor = true;
            this.btnQuayLaiSize.Click += new System.EventHandler(this.btnQuayLaiSize_Click);
            // 
            // lblGiaTriSize
            // 
            this.lblGiaTriSize.AutoSize = true;
            this.lblGiaTriSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaTriSize.Location = new System.Drawing.Point(420, 40);
            this.lblGiaTriSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTriSize.Name = "lblGiaTriSize";
            this.lblGiaTriSize.Size = new System.Drawing.Size(77, 19);
            this.lblGiaTriSize.TabIndex = 6;
            this.lblGiaTriSize.Text = "Giá Trị Size:";
            // 
            // lblMaSize
            // 
            this.lblMaSize.AutoSize = true;
            this.lblMaSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaSize.Location = new System.Drawing.Point(22, 40);
            this.lblMaSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSize.Name = "lblMaSize";
            this.lblMaSize.Size = new System.Drawing.Size(59, 19);
            this.lblMaSize.TabIndex = 5;
            this.lblMaSize.Text = "Mã Size:";
            this.lblMaSize.Click += new System.EventHandler(this.lblMaSize_Click);
            // 
            // dgvSize
            // 
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSize.Location = new System.Drawing.Point(26, 98);
            this.dgvSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.RowHeadersWidth = 51;
            this.dgvSize.RowTemplate.Height = 24;
            this.dgvSize.Size = new System.Drawing.Size(677, 262);
            this.dgvSize.TabIndex = 4;
            // 
            // btnXoaSize
            // 
            this.btnXoaSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnXoaSize.Location = new System.Drawing.Point(609, 391);
            this.btnXoaSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaSize.Name = "btnXoaSize";
            this.btnXoaSize.Size = new System.Drawing.Size(94, 32);
            this.btnXoaSize.TabIndex = 3;
            this.btnXoaSize.Text = "Xóa Size";
            this.btnXoaSize.UseVisualStyleBackColor = true;
            this.btnXoaSize.Click += new System.EventHandler(this.btnXoaSize_Click);
            // 
            // btnThemSize
            // 
            this.btnThemSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThemSize.Location = new System.Drawing.Point(312, 391);
            this.btnThemSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemSize.Name = "btnThemSize";
            this.btnThemSize.Size = new System.Drawing.Size(94, 32);
            this.btnThemSize.TabIndex = 2;
            this.btnThemSize.Text = "Thêm Size";
            this.btnThemSize.UseVisualStyleBackColor = true;
            this.btnThemSize.Click += new System.EventHandler(this.btnThemSize_Click);
            // 
            // txtGiaTriSize
            // 
            this.txtGiaTriSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaTriSize.Location = new System.Drawing.Point(501, 37);
            this.txtGiaTriSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaTriSize.Name = "txtGiaTriSize";
            this.txtGiaTriSize.Size = new System.Drawing.Size(202, 25);
            this.txtGiaTriSize.TabIndex = 1;
            // 
            // txtMaSize
            // 
            this.txtMaSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaSize.Location = new System.Drawing.Point(85, 37);
            this.txtMaSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSize.Name = "txtMaSize";
            this.txtMaSize.Size = new System.Drawing.Size(194, 25);
            this.txtMaSize.TabIndex = 0;
            this.txtMaSize.TextChanged += new System.EventHandler(this.txtMaSize_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblTenMau);
            this.tabPage2.Controls.Add(this.lblMaMauSac);
            this.tabPage2.Controls.Add(this.btnXoaMauSac);
            this.tabPage2.Controls.Add(this.btnThemMauSac);
            this.tabPage2.Controls.Add(this.txtTenMau);
            this.tabPage2.Controls.Add(this.txtMaMauSac);
            this.tabPage2.Controls.Add(this.roundPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(776, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Màu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnQuayLaiMau
            // 
            this.btnQuayLaiMau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuayLaiMau.Location = new System.Drawing.Point(25, 385);
            this.btnQuayLaiMau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuayLaiMau.Name = "btnQuayLaiMau";
            this.btnQuayLaiMau.Size = new System.Drawing.Size(114, 32);
            this.btnQuayLaiMau.TabIndex = 14;
            this.btnQuayLaiMau.Text = "Quay lại";
            this.btnQuayLaiMau.UseVisualStyleBackColor = true;
            this.btnQuayLaiMau.Click += new System.EventHandler(this.btnQuayLaiMau_Click);
            // 
            // lblTenMau
            // 
            this.lblTenMau.AutoSize = true;
            this.lblTenMau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenMau.Location = new System.Drawing.Point(54, 95);
            this.lblTenMau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenMau.Name = "lblTenMau";
            this.lblTenMau.Size = new System.Drawing.Size(65, 19);
            this.lblTenMau.TabIndex = 13;
            this.lblTenMau.Text = "Tên Màu:";
            // 
            // lblMaMauSac
            // 
            this.lblMaMauSac.AutoSize = true;
            this.lblMaMauSac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaMauSac.Location = new System.Drawing.Point(440, 98);
            this.lblMaMauSac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaMauSac.Name = "lblMaMauSac";
            this.lblMaMauSac.Size = new System.Drawing.Size(88, 19);
            this.lblMaMauSac.TabIndex = 12;
            this.lblMaMauSac.Text = "Mã Màu Sắc:";
            // 
            // dgvMauSac
            // 
            this.dgvMauSac.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMauSac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMauSac.Location = new System.Drawing.Point(25, 106);
            this.dgvMauSac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMauSac.Name = "dgvMauSac";
            this.dgvMauSac.RowHeadersWidth = 51;
            this.dgvMauSac.RowTemplate.Height = 24;
            this.dgvMauSac.Size = new System.Drawing.Size(664, 249);
            this.dgvMauSac.TabIndex = 11;
            // 
            // btnXoaMauSac
            // 
            this.btnXoaMauSac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnXoaMauSac.Location = new System.Drawing.Point(627, 438);
            this.btnXoaMauSac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaMauSac.Name = "btnXoaMauSac";
            this.btnXoaMauSac.Size = new System.Drawing.Size(94, 32);
            this.btnXoaMauSac.TabIndex = 10;
            this.btnXoaMauSac.Text = "Xóa Màu";
            this.btnXoaMauSac.UseVisualStyleBackColor = true;
            this.btnXoaMauSac.Click += new System.EventHandler(this.btnXoaMau_Click);
            // 
            // btnThemMauSac
            // 
            this.btnThemMauSac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThemMauSac.Location = new System.Drawing.Point(335, 438);
            this.btnThemMauSac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemMauSac.Name = "btnThemMauSac";
            this.btnThemMauSac.Size = new System.Drawing.Size(94, 32);
            this.btnThemMauSac.TabIndex = 9;
            this.btnThemMauSac.Text = "Thêm Màu";
            this.btnThemMauSac.UseVisualStyleBackColor = true;
            this.btnThemMauSac.Click += new System.EventHandler(this.btnThemMau_Click);
            // 
            // txtTenMau
            // 
            this.txtTenMau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenMau.Location = new System.Drawing.Point(123, 93);
            this.txtTenMau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenMau.Name = "txtTenMau";
            this.txtTenMau.Size = new System.Drawing.Size(187, 25);
            this.txtTenMau.TabIndex = 8;
            // 
            // txtMaMauSac
            // 
            this.txtMaMauSac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaMauSac.Location = new System.Drawing.Point(532, 95);
            this.txtMaMauSac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaMauSac.Name = "txtMaMauSac";
            this.txtMaMauSac.Size = new System.Drawing.Size(187, 25);
            this.txtMaMauSac.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "THUỘC TÍNH SẢN PHẨM : MÀU";
            // 
            // roundPanel1
            // 
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.Controls.Add(this.dgvMauSac);
            this.roundPanel1.Controls.Add(this.btnQuayLaiMau);
            this.roundPanel1.Location = new System.Drawing.Point(32, 53);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(716, 476);
            this.roundPanel1.TabIndex = 16;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BorderRadius = 20;
            this.roundPanel2.Controls.Add(this.btnXoaSize);
            this.roundPanel2.Controls.Add(this.btnQuayLaiSize);
            this.roundPanel2.Controls.Add(this.btnThemSize);
            this.roundPanel2.Controls.Add(this.dgvSize);
            this.roundPanel2.Controls.Add(this.lblGiaTriSize);
            this.roundPanel2.Controls.Add(this.txtMaSize);
            this.roundPanel2.Controls.Add(this.lblMaSize);
            this.roundPanel2.Controls.Add(this.txtGiaTriSize);
            this.roundPanel2.Location = new System.Drawing.Point(24, 73);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(728, 450);
            this.roundPanel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "THUỘC TÍNH SẢN PHẨM : SIZE";
            // 
            // FormThuocTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 576);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThuocTinh";
            this.Text = "FormThuocTinh";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMauSac)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvSize;
        private System.Windows.Forms.Button btnXoaSize;
        private System.Windows.Forms.Button btnThemSize;
        private System.Windows.Forms.TextBox txtGiaTriSize;
        private System.Windows.Forms.TextBox txtMaSize;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblGiaTriSize;
        private System.Windows.Forms.Label lblMaSize;
        private System.Windows.Forms.Label lblTenMau;
        private System.Windows.Forms.Label lblMaMauSac;
        private System.Windows.Forms.DataGridView dgvMauSac;
        private System.Windows.Forms.Button btnXoaMauSac;
        private System.Windows.Forms.Button btnThemMauSac;
        private System.Windows.Forms.TextBox txtTenMau;
        private System.Windows.Forms.TextBox txtMaMauSac;
        private System.Windows.Forms.Button btnQuayLaiSize;
        private System.Windows.Forms.Button btnQuayLaiMau;
        private System.Windows.Forms.Label label1;
        private BTL_QLCHG.Utils.RoundPanel roundPanel1;
        private BTL_QLCHG.Utils.RoundPanel roundPanel2;
        private System.Windows.Forms.Label label2;
    }
}