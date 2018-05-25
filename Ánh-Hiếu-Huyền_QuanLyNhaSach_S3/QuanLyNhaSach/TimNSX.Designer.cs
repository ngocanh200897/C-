namespace QuanLyNhaSach
{
    partial class TimNSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimNSX));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbten = new System.Windows.Forms.RadioButton();
            this.rbma = new System.Windows.Forms.RadioButton();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNSX = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtnhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Tìm Kiếm";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(75, 42);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(260, 20);
            this.txtnhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.rbten);
            this.groupBox2.Controls.Add(this.rbma);
            this.groupBox2.Location = new System.Drawing.Point(388, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Mục Chọn ";
            // 
            // rbten
            // 
            this.rbten.AutoSize = true;
            this.rbten.ForeColor = System.Drawing.Color.Black;
            this.rbten.Location = new System.Drawing.Point(8, 59);
            this.rbten.Name = "rbten";
            this.rbten.Size = new System.Drawing.Size(44, 17);
            this.rbten.TabIndex = 0;
            this.rbten.TabStop = true;
            this.rbten.Text = "Tên";
            this.rbten.UseVisualStyleBackColor = true;
            // 
            // rbma
            // 
            this.rbma.AutoSize = true;
            this.rbma.ForeColor = System.Drawing.Color.Black;
            this.rbma.Location = new System.Drawing.Point(7, 23);
            this.rbma.Name = "rbma";
            this.rbma.Size = new System.Drawing.Size(40, 17);
            this.rbma.TabIndex = 0;
            this.rbma.TabStop = true;
            this.rbma.Text = "Mã";
            this.rbma.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Orange;
            this.btntimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntimkiem.Image = global::QuanLyNhaSach.Properties.Resources.mail_find;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(531, 13);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(156, 41);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = global::QuanLyNhaSach.Properties.Resources.exit1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(531, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNSX);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 274);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Tìm Kiếm";
            // 
            // dgvNSX
            // 
            this.dgvNSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNSX.Location = new System.Drawing.Point(3, 16);
            this.dgvNSX.Name = "dgvNSX";
            this.dgvNSX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNSX.Size = new System.Drawing.Size(693, 255);
            this.dgvNSX.TabIndex = 0;
            // 
            // TimNSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 406);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimNSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimNSX";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TimNSX_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbten;
        private System.Windows.Forms.RadioButton rbma;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvNSX;
    }
}