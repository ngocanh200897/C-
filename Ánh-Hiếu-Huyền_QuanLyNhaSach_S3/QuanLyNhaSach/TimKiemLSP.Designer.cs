namespace QuanLyNhaSach
{
    partial class TimKiemLSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemLSP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.tntim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbma = new System.Windows.Forms.RadioButton();
            this.rbten = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvdstimkiem = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnhap);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.tntim);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Tên";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(80, 71);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(308, 20);
            this.txtnhap.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Orange;
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Black;
            this.btnthoat.Image = global::QuanLyNhaSach.Properties.Resources.exit1;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(426, 83);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(119, 51);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // tntim
            // 
            this.tntim.BackColor = System.Drawing.Color.Orange;
            this.tntim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tntim.ForeColor = System.Drawing.Color.Black;
            this.tntim.Image = global::QuanLyNhaSach.Properties.Resources.mail_find;
            this.tntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tntim.Location = new System.Drawing.Point(426, 19);
            this.tntim.Name = "tntim";
            this.tntim.Size = new System.Drawing.Size(119, 51);
            this.tntim.TabIndex = 0;
            this.tntim.Text = "Tìm Kiếm";
            this.tntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tntim.UseVisualStyleBackColor = false;
            this.tntim.Click += new System.EventHandler(this.tntim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.rbma);
            this.groupBox2.Controls.Add(this.rbten);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(614, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Mục Chọn";
            // 
            // rbma
            // 
            this.rbma.AutoSize = true;
            this.rbma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbma.Location = new System.Drawing.Point(82, 59);
            this.rbma.Name = "rbma";
            this.rbma.Size = new System.Drawing.Size(40, 17);
            this.rbma.TabIndex = 0;
            this.rbma.TabStop = true;
            this.rbma.Text = "Mã";
            this.rbma.UseVisualStyleBackColor = true;
            // 
            // rbten
            // 
            this.rbten.AutoSize = true;
            this.rbten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbten.Location = new System.Drawing.Point(80, 28);
            this.rbten.Name = "rbten";
            this.rbten.Size = new System.Drawing.Size(44, 17);
            this.rbten.TabIndex = 0;
            this.rbten.TabStop = true;
            this.rbten.Text = "Tên";
            this.rbten.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvdstimkiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(0, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(909, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Tìm Kiếm";
            // 
            // dgvdstimkiem
            // 
            this.dgvdstimkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdstimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdstimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdstimkiem.Location = new System.Drawing.Point(3, 16);
            this.dgvdstimkiem.Name = "dgvdstimkiem";
            this.dgvdstimkiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdstimkiem.Size = new System.Drawing.Size(903, 231);
            this.dgvdstimkiem.TabIndex = 0;
            // 
            // TimKiemLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(909, 457);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemLSP";
            this.Load += new System.EventHandler(this.TimKiemLSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstimkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Button tntim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbma;
        private System.Windows.Forms.RadioButton rbten;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvdstimkiem;
    }
}