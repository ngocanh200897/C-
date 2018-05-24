namespace QuanLyNhaSach
{
    partial class FrmKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.txtSLXuat = new System.Windows.Forms.TextBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.lblSLTon = new System.Windows.Forms.Label();
            this.lblSLXuat = new System.Windows.Forms.Label();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.lblSLNhap = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayXuat);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtSoPhieu);
            this.groupBox1.Controls.Add(this.txtSLTon);
            this.groupBox1.Controls.Add(this.txtSLXuat);
            this.groupBox1.Controls.Add(this.txtSLNhap);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.lblSoPhieu);
            this.groupBox1.Controls.Add(this.lblSLTon);
            this.groupBox1.Controls.Add(this.lblSLXuat);
            this.groupBox1.Controls.Add(this.lblNgayXuat);
            this.groupBox1.Controls.Add(this.lblSLNhap);
            this.groupBox1.Controls.Add(this.lblNgayNhap);
            this.groupBox1.Controls.Add(this.lblTenSP);
            this.groupBox1.Controls.Add(this.lblMaSP);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(784, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết kho";
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuat.Location = new System.Drawing.Point(601, 37);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(147, 29);
            this.dtpNgayXuat.TabIndex = 17;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(171, 135);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(171, 29);
            this.dtpNgayNhap.TabIndex = 16;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(601, 184);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(147, 29);
            this.txtSoPhieu.TabIndex = 15;
            // 
            // txtSLTon
            // 
            this.txtSLTon.Location = new System.Drawing.Point(601, 132);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(147, 29);
            this.txtSLTon.TabIndex = 14;
            // 
            // txtSLXuat
            // 
            this.txtSLXuat.Location = new System.Drawing.Point(601, 84);
            this.txtSLXuat.Name = "txtSLXuat";
            this.txtSLXuat.Size = new System.Drawing.Size(147, 29);
            this.txtSLXuat.TabIndex = 13;
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(171, 189);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(171, 29);
            this.txtSLNhap.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(171, 92);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(171, 29);
            this.txtTenSP.TabIndex = 9;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(171, 37);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(171, 29);
            this.txtMaSP.TabIndex = 8;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(507, 189);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(76, 21);
            this.lblSoPhieu.TabIndex = 7;
            this.lblSoPhieu.Text = "Số phiếu";
            // 
            // lblSLTon
            // 
            this.lblSLTon.AutoSize = true;
            this.lblSLTon.Location = new System.Drawing.Point(443, 135);
            this.lblSLTon.Name = "lblSLTon";
            this.lblSLTon.Size = new System.Drawing.Size(140, 21);
            this.lblSLTon.TabIndex = 6;
            this.lblSLTon.Text = "Số lượng tồn kho";
            // 
            // lblSLXuat
            // 
            this.lblSLXuat.AutoSize = true;
            this.lblSLXuat.Location = new System.Drawing.Point(469, 92);
            this.lblSLXuat.Name = "lblSLXuat";
            this.lblSLXuat.Size = new System.Drawing.Size(114, 21);
            this.lblSLXuat.TabIndex = 5;
            this.lblSLXuat.Text = "Số lượng xuất";
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Location = new System.Drawing.Point(465, 43);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(118, 21);
            this.lblNgayXuat.TabIndex = 4;
            this.lblNgayXuat.Text = "Ngày xuất kho";
            // 
            // lblSLNhap
            // 
            this.lblSLNhap.AutoSize = true;
            this.lblSLNhap.Location = new System.Drawing.Point(30, 192);
            this.lblSLNhap.Name = "lblSLNhap";
            this.lblSLNhap.Size = new System.Drawing.Size(119, 21);
            this.lblSLNhap.TabIndex = 3;
            this.lblSLNhap.Text = "Số lượng nhập";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(26, 132);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(123, 21);
            this.lblNgayNhap.TabIndex = 2;
            this.lblNgayNhap.Text = "Ngày nhập kho";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(34, 92);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(115, 21);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(39, 45);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(110, 21);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyNhaSach.Properties.Resources.interact;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSua.Location = new System.Drawing.Point(240, 314);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 54);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyNhaSach.Properties.Resources.delete__4_;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoa.Location = new System.Drawing.Point(428, 314);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 54);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyNhaSach.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThoat.Location = new System.Drawing.Point(635, 314);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 54);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKho);
            this.groupBox2.Location = new System.Drawing.Point(14, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 222);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách kho";
            // 
            // dgvKho
            // 
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(22, 28);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.Size = new System.Drawing.Size(741, 174);
            this.dgvKho.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyNhaSach.Properties.Resources.insert_table;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThem.Location = new System.Drawing.Point(52, 314);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 54);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // FrmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(826, 665);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.TextBox txtSLXuat;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label lblSLTon;
        private System.Windows.Forms.Label lblSLXuat;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.Label lblSLNhap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKho;
    }
}