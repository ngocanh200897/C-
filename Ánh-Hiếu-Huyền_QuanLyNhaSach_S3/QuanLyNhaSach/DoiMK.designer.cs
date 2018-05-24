namespace QuanLyNhaSach
{
    partial class FrmDoiMK
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
            this.lblMkCu = new System.Windows.Forms.Label();
            this.lblMkMoi = new System.Windows.Forms.Label();
            this.lblXacNhanMk = new System.Windows.Forms.Label();
            this.txtMkCu = new System.Windows.Forms.TextBox();
            this.txtMkMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhanMk = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMkCu
            // 
            this.lblMkCu.AutoSize = true;
            this.lblMkCu.Location = new System.Drawing.Point(112, 85);
            this.lblMkCu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMkCu.Name = "lblMkCu";
            this.lblMkCu.Size = new System.Drawing.Size(102, 21);
            this.lblMkCu.TabIndex = 0;
            this.lblMkCu.Text = "Mật khẩu cũ";
            // 
            // lblMkMoi
            // 
            this.lblMkMoi.AutoSize = true;
            this.lblMkMoi.Location = new System.Drawing.Point(102, 144);
            this.lblMkMoi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMkMoi.Name = "lblMkMoi";
            this.lblMkMoi.Size = new System.Drawing.Size(112, 21);
            this.lblMkMoi.TabIndex = 1;
            this.lblMkMoi.Text = "Mật khẩu mới";
            // 
            // lblXacNhanMk
            // 
            this.lblXacNhanMk.AutoSize = true;
            this.lblXacNhanMk.Location = new System.Drawing.Point(71, 194);
            this.lblXacNhanMk.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblXacNhanMk.Name = "lblXacNhanMk";
            this.lblXacNhanMk.Size = new System.Drawing.Size(152, 21);
            this.lblXacNhanMk.TabIndex = 2;
            this.lblXacNhanMk.Text = "Xác nhận mật khẩu";
            // 
            // txtMkCu
            // 
            this.txtMkCu.Location = new System.Drawing.Point(263, 77);
            this.txtMkCu.Margin = new System.Windows.Forms.Padding(5);
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.Size = new System.Drawing.Size(257, 29);
            this.txtMkCu.TabIndex = 3;
            this.txtMkCu.UseSystemPasswordChar = true;
            // 
            // txtMkMoi
            // 
            this.txtMkMoi.Location = new System.Drawing.Point(263, 136);
            this.txtMkMoi.Margin = new System.Windows.Forms.Padding(5);
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.Size = new System.Drawing.Size(257, 29);
            this.txtMkMoi.TabIndex = 4;
            this.txtMkMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMk
            // 
            this.txtXacNhanMk.Location = new System.Drawing.Point(263, 191);
            this.txtXacNhanMk.Margin = new System.Windows.Forms.Padding(5);
            this.txtXacNhanMk.Name = "txtXacNhanMk";
            this.txtXacNhanMk.Size = new System.Drawing.Size(257, 29);
            this.txtXacNhanMk.TabIndex = 5;
            this.txtXacNhanMk.UseSystemPasswordChar = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(362, 286);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 37);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(139, 286);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(120, 37);
            this.btnDongY.TabIndex = 8;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            // 
            // FrmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 393);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtXacNhanMk);
            this.Controls.Add(this.txtMkMoi);
            this.Controls.Add(this.txtMkCu);
            this.Controls.Add(this.lblXacNhanMk);
            this.Controls.Add(this.lblMkMoi);
            this.Controls.Add(this.lblMkCu);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoiMK";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmDoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMkCu;
        private System.Windows.Forms.Label lblMkMoi;
        private System.Windows.Forms.Label lblXacNhanMk;
        private System.Windows.Forms.TextBox txtMkCu;
        private System.Windows.Forms.TextBox txtMkMoi;
        private System.Windows.Forms.TextBox txtXacNhanMk;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDongY;
    }
}