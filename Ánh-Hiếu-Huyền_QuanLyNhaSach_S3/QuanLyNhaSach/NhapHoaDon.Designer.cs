namespace QuanLyNhaSach
{
    partial class NhapHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsbTenSanPham = new System.Windows.Forms.ListBox();
            this.lsbThanhTien = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTenSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTienMat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTienTra = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN MẶT HÀNG";
            // 
            // lsbTenSanPham
            // 
            this.lsbTenSanPham.FormattingEnabled = true;
            this.lsbTenSanPham.ItemHeight = 16;
            this.lsbTenSanPham.Location = new System.Drawing.Point(15, 29);
            this.lsbTenSanPham.Name = "lsbTenSanPham";
            this.lsbTenSanPham.Size = new System.Drawing.Size(325, 276);
            this.lsbTenSanPham.TabIndex = 1;
            // 
            // lsbThanhTien
            // 
            this.lsbThanhTien.FormattingEnabled = true;
            this.lsbThanhTien.ItemHeight = 16;
            this.lsbThanhTien.Location = new System.Drawing.Point(346, 29);
            this.lsbThanhTien.Name = "lsbThanhTien";
            this.lsbThanhTien.Size = new System.Drawing.Size(199, 276);
            this.lsbThanhTien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÀNH TIỀN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // txbTenSanPham
            // 
            this.txbTenSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbTenSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbTenSanPham.Location = new System.Drawing.Point(120, 313);
            this.txbTenSanPham.Name = "txbTenSanPham";
            this.txbTenSanPham.Size = new System.Drawing.Size(220, 23);
            this.txbTenSanPham.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn Giá";
            // 
            // nudDonGia
            // 
            this.nudDonGia.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDonGia.Location = new System.Drawing.Point(120, 342);
            this.nudDonGia.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(220, 23);
            this.nudDonGia.TabIndex = 7;
            this.nudDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDonGia.ThousandsSeparator = true;
            // 
            // nudTongTien
            // 
            this.nudTongTien.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTongTien.Location = new System.Drawing.Point(120, 371);
            this.nudTongTien.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.ReadOnly = true;
            this.nudTongTien.Size = new System.Drawing.Size(220, 23);
            this.nudTongTien.TabIndex = 9;
            this.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTongTien.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Tiền";
            // 
            // nudTienMat
            // 
            this.nudTienMat.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTienMat.Location = new System.Drawing.Point(120, 400);
            this.nudTienMat.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTienMat.Name = "nudTienMat";
            this.nudTienMat.Size = new System.Drawing.Size(220, 23);
            this.nudTienMat.TabIndex = 11;
            this.nudTienMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTienMat.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tiền Mặt";
            // 
            // nudTienTra
            // 
            this.nudTienTra.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTienTra.Location = new System.Drawing.Point(120, 429);
            this.nudTienTra.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTienTra.Name = "nudTienTra";
            this.nudTienTra.ReadOnly = true;
            this.nudTienTra.Size = new System.Drawing.Size(220, 23);
            this.nudTienTra.TabIndex = 13;
            this.nudTienTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTienTra.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiền Trả";
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(385, 321);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 35);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(385, 362);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 35);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHoaDon.Location = new System.Drawing.Point(385, 403);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(105, 35);
            this.btnInHoaDon.TabIndex = 16;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // NhapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 463);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nudTienTra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudTienMat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTenSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbTenSanPham);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhapHoaDon";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbTenSanPham;
        private System.Windows.Forms.ListBox lsbThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTienMat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTienTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}