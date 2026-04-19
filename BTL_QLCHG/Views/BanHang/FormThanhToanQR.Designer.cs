namespace BTL_QLCHG.Views.BanHang
{
    partial class FormThanhToanQR
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picQR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblChuTK = new System.Windows.Forms.Label();
            this.lblSTK = new System.Windows.Forms.Label();
            this.lblNganHang = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picQR
            // 
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(310, 60);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(280, 280);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 0;
            this.picQR.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(170, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "THÔNG TIN THANH TOÁN";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Location = new System.Drawing.Point(310, 360);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(280, 45);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "XÁC NHẬN ĐÃ NHẬN TIỀN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightGray;
            this.btnHuy.Location = new System.Drawing.Point(20, 360);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(270, 45);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "QUAY LẠI";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblChuTK);
            this.groupBoxInfo.Controls.Add(this.lblSTK);
            this.groupBoxInfo.Controls.Add(this.lblNganHang);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 60);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(270, 180);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Chuyển khoản thủ công";
            // 
            // lblChuTK
            // 
            this.lblChuTK.AutoSize = true;
            this.lblChuTK.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblChuTK.Location = new System.Drawing.Point(15, 125);
            this.lblChuTK.Name = "lblChuTK";
            this.lblChuTK.Size = new System.Drawing.Size(190, 20);
            this.lblChuTK.TabIndex = 0;
            this.lblChuTK.Text = "Chủ TK: NGUYEN VAN HIEU";
            // 
            // lblSTK
            // 
            this.lblSTK.AutoSize = true;
            this.lblSTK.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSTK.ForeColor = System.Drawing.Color.Blue;
            this.lblSTK.Location = new System.Drawing.Point(15, 80);
            this.lblSTK.Name = "lblSTK";
            this.lblSTK.Size = new System.Drawing.Size(155, 25);
            this.lblSTK.TabIndex = 1;
            this.lblSTK.Text = "STK: 0345678910";
            // 
            // lblNganHang
            // 
            this.lblNganHang.AutoSize = true;
            this.lblNganHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNganHang.Location = new System.Drawing.Point(15, 40);
            this.lblNganHang.Name = "lblNganHang";
            this.lblNganHang.Size = new System.Drawing.Size(147, 20);
            this.lblNganHang.TabIndex = 2;
            this.lblNganHang.Text = "Ngân hàng: MB Bank";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSoTien.ForeColor = System.Drawing.Color.Red;
            this.lblSoTien.Location = new System.Drawing.Point(20, 290);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(88, 32);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = "0 VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "SỐ TIỀN CẦN TRẢ:";
            // 
            // FormThanhToanQR
            // 
            this.ClientSize = new System.Drawing.Size(601, 430);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picQR);
            this.Name = "FormThanhToanQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán Chuyển khoản";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblNganHang;
        private System.Windows.Forms.Label lblSTK;
        private System.Windows.Forms.Label lblChuTK;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label label2;
    }
}