namespace QuanLyNhaSach
{
    partial class TimKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbten = new System.Windows.Forms.RadioButton();
            this.rbma = new System.Windows.Forms.RadioButton();
            this.btntim = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDsTim = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtnhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(514, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Tìm Kiếm";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(87, 52);
            this.txtnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(419, 23);
            this.txtnhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.rbten);
            this.groupBox2.Controls.Add(this.rbma);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(590, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(280, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Mục Chọn";
            // 
            // rbten
            // 
            this.rbten.AutoSize = true;
            this.rbten.ForeColor = System.Drawing.Color.Black;
            this.rbten.Location = new System.Drawing.Point(94, 75);
            this.rbten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbten.Name = "rbten";
            this.rbten.Size = new System.Drawing.Size(48, 20);
            this.rbten.TabIndex = 0;
            this.rbten.TabStop = true;
            this.rbten.Text = "Tên";
            this.rbten.UseVisualStyleBackColor = true;
            // 
            // rbma
            // 
            this.rbma.AutoSize = true;
            this.rbma.ForeColor = System.Drawing.Color.Black;
            this.rbma.Location = new System.Drawing.Point(94, 47);
            this.rbma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbma.Name = "rbma";
            this.rbma.Size = new System.Drawing.Size(43, 20);
            this.rbma.TabIndex = 0;
            this.rbma.TabStop = true;
            this.rbma.Text = "Mã";
            this.rbma.UseVisualStyleBackColor = true;
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.Orange;
            this.btntim.ForeColor = System.Drawing.Color.Black;
            this.btntim.Image = global::QuanLyNhaSach.Properties.Resources.mail_find;
            this.btntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntim.Location = new System.Drawing.Point(294, 187);
            this.btntim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(142, 57);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm Kiếm";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Orange;
            this.btnthoat.ForeColor = System.Drawing.Color.Black;
            this.btnthoat.Image = global::QuanLyNhaSach.Properties.Resources.exit1;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(456, 187);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(142, 57);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvDsTim);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(0, 282);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(901, 219);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Tìm Kiếm";
            // 
            // dgvDsTim
            // 
            this.dgvDsTim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsTim.Location = new System.Drawing.Point(3, 20);
            this.dgvDsTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDsTim.Name = "dgvDsTim";
            this.dgvDsTim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsTim.Size = new System.Drawing.Size(895, 195);
            this.dgvDsTim.TabIndex = 0;
            // 
            // TimKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(901, 501);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TimKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TimKH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDsTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.RadioButton rbten;
        private System.Windows.Forms.RadioButton rbma;
    }
}