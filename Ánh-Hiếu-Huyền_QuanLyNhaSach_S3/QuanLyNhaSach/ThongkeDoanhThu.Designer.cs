namespace QuanLyNhaSach
{
    partial class ThongkeDoanhThu
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
            this.lsbDanhSachHoaDon = new System.Windows.Forms.ListBox();
            this.lsbThanhTien = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Hóa Đơn";
            // 
            // lsbDanhSachHoaDon
            // 
            this.lsbDanhSachHoaDon.FormattingEnabled = true;
            this.lsbDanhSachHoaDon.ItemHeight = 16;
            this.lsbDanhSachHoaDon.Location = new System.Drawing.Point(3, 29);
            this.lsbDanhSachHoaDon.Name = "lsbDanhSachHoaDon";
            this.lsbDanhSachHoaDon.Size = new System.Drawing.Size(241, 276);
            this.lsbDanhSachHoaDon.TabIndex = 1;
            // 
            // lsbThanhTien
            // 
            this.lsbThanhTien.FormattingEnabled = true;
            this.lsbThanhTien.ItemHeight = 16;
            this.lsbThanhTien.Location = new System.Drawing.Point(250, 29);
            this.lsbThanhTien.Name = "lsbThanhTien";
            this.lsbThanhTien.Size = new System.Drawing.Size(295, 276);
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
            // nudTongTien
            // 
            this.nudTongTien.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTongTien.Location = new System.Drawing.Point(215, 323);
            this.nudTongTien.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.ReadOnly = true;
            this.nudTongTien.Size = new System.Drawing.Size(315, 23);
            this.nudTongTien.TabIndex = 9;
            this.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTongTien.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Orange;
            this.btnThoat.Image = global::QuanLyNhaSach.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThoat.Location = new System.Drawing.Point(448, 422);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(0, 0);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Image = global::QuanLyNhaSach.Properties.Resources.delete__4_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(384, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "    Xóa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Image = global::QuanLyNhaSach.Properties.Resources.interact;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSua.Location = new System.Drawing.Point(280, 374);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 43);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Image = global::QuanLyNhaSach.Properties.Resources.insert_table;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(176, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "     Thêm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Orange;
            this.btnIn.Image = global::QuanLyNhaSach.Properties.Resources.insert_table;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIn.Location = new System.Drawing.Point(65, 374);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(105, 43);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "      Xuất HD";
            this.btnIn.UseVisualStyleBackColor = false;
            // 
            // ThongkeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 463);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsbThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbDanhSachHoaDon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongkeDoanhThu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbDanhSachHoaDon;
        private System.Windows.Forms.ListBox lsbThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIn;
    }
}