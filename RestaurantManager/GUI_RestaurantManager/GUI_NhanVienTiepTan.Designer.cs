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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnQLBanAn = new System.Windows.Forms.Button();
            this.btnDonDatBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTiepTan = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnDangXuat);
            this.groupBox1.Controls.Add(this.btnXemThongTin);
            this.groupBox1.Controls.Add(this.btnQLBanAn);
            this.groupBox1.Controls.Add(this.btnDonDatBan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 681);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(6, 525);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(227, 71);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Location = new System.Drawing.Point(6, 433);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(225, 71);
            this.btnXemThongTin.TabIndex = 2;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            // 
            // btnQLBanAn
            // 
            this.btnQLBanAn.Location = new System.Drawing.Point(4, 333);
            this.btnQLBanAn.Name = "btnQLBanAn";
            this.btnQLBanAn.Size = new System.Drawing.Size(227, 71);
            this.btnQLBanAn.TabIndex = 1;
            this.btnQLBanAn.Text = "Quản lý bàn ăn";
            this.btnQLBanAn.UseVisualStyleBackColor = true;
            // 
            // btnDonDatBan
            // 
            this.btnDonDatBan.Location = new System.Drawing.Point(6, 231);
            this.btnDonDatBan.Name = "btnDonDatBan";
            this.btnDonDatBan.Size = new System.Drawing.Size(227, 71);
            this.btnDonDatBan.TabIndex = 0;
            this.btnDonDatBan.Text = "Đơn bàn đặt";
            this.btnDonDatBan.UseVisualStyleBackColor = true;
            this.btnDonDatBan.Click += new System.EventHandler(this.btnDonDatBan_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1191, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // panelTiepTan
            // 
            this.panelTiepTan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTiepTan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTiepTan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTiepTan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTiepTan.Location = new System.Drawing.Point(237, 100);
            this.panelTiepTan.Name = "panelTiepTan";
            this.panelTiepTan.Size = new System.Drawing.Size(1191, 581);
            this.panelTiepTan.TabIndex = 3;
            // 
            // GUI_NhanVienTiepTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 681);
            this.Controls.Add(this.panelTiepTan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_NhanVienTiepTan";
            this.Text = "Hệ thống quản lý nhà hàng MICONET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTiepTan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnQLBanAn;
        private System.Windows.Forms.Button btnDonDatBan;
    }
}