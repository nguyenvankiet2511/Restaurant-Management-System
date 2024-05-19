namespace GUI_RestaurantManager
{
    partial class GUI_NhanVienTiepTan
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnQLBanAn = new System.Windows.Forms.Button();
            this.btnDonDatBan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTiepTan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDangXuat.Location = new System.Drawing.Point(2, 522);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(227, 71);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.Color.SandyBrown;
            this.btnXemThongTin.Location = new System.Drawing.Point(2, 430);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(225, 71);
            this.btnXemThongTin.TabIndex = 2;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // btnQLBanAn
            // 
            this.btnQLBanAn.BackColor = System.Drawing.Color.SandyBrown;
            this.btnQLBanAn.Location = new System.Drawing.Point(0, 330);
            this.btnQLBanAn.Name = "btnQLBanAn";
            this.btnQLBanAn.Size = new System.Drawing.Size(227, 71);
            this.btnQLBanAn.TabIndex = 1;
            this.btnQLBanAn.Text = "Quản lý bàn ăn";
            this.btnQLBanAn.UseVisualStyleBackColor = false;
            this.btnQLBanAn.Click += new System.EventHandler(this.btnQLBanAn_Click);
            // 
            // btnDonDatBan
            // 
            this.btnDonDatBan.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDonDatBan.Location = new System.Drawing.Point(2, 228);
            this.btnDonDatBan.Name = "btnDonDatBan";
            this.btnDonDatBan.Size = new System.Drawing.Size(227, 71);
            this.btnDonDatBan.TabIndex = 0;
            this.btnDonDatBan.Text = "Đơn bàn đặt";
            this.btnDonDatBan.UseVisualStyleBackColor = false;
            this.btnDonDatBan.Click += new System.EventHandler(this.btnDonDatBan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_RestaurantManager.Properties.Resources.banner_seafood;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1428, 228);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnDonDatBan);
            this.panel1.Controls.Add(this.btnXemThongTin);
            this.panel1.Controls.Add(this.btnQLBanAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 453);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::GUI_RestaurantManager.Properties.Resources.logo_seafood;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panelTiepTan
            // 
            this.panelTiepTan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTiepTan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTiepTan.Location = new System.Drawing.Point(233, 228);
            this.panelTiepTan.Name = "panelTiepTan";
            this.panelTiepTan.Size = new System.Drawing.Size(1195, 453);
            this.panelTiepTan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            this.label1.Visible = false;
            // 
            // GUI_NhanVienTiepTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 681);
            this.Controls.Add(this.panelTiepTan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_NhanVienTiepTan";
            this.Text = "Hệ thống quản lý nhà hàng MICONET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_NhanVienTiepTan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnQLBanAn;
        private System.Windows.Forms.Button btnDonDatBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTiepTan;
        private System.Windows.Forms.Label label1;
    }
}