namespace GUI_RestaurantManager
{
    partial class GUI_NhanVienSale
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQLDH = new System.Windows.Forms.Button();
            this.btnDonDatHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContainer.Location = new System.Drawing.Point(237, 100);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1134, 638);
            this.panelContainer.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnDangXuat);
            this.groupBox1.Controls.Add(this.btnQLDH);
            this.groupBox1.Controls.Add(this.btnDonDatHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 638);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(4, 496);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(227, 71);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnQLDH
            // 
            this.btnQLDH.Location = new System.Drawing.Point(4, 401);
            this.btnQLDH.Name = "btnQLDH";
            this.btnQLDH.Size = new System.Drawing.Size(227, 71);
            this.btnQLDH.TabIndex = 1;
            this.btnQLDH.Text = "Quản lý đơn hàng";
            this.btnQLDH.UseVisualStyleBackColor = true;
            this.btnQLDH.Click += new System.EventHandler(this.btnQLDH_Click);
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.Location = new System.Drawing.Point(6, 299);
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.Size = new System.Drawing.Size(227, 71);
            this.btnDonDatHang.TabIndex = 0;
            this.btnDonDatHang.Text = "Đơn đặt hàng";
            this.btnDonDatHang.UseVisualStyleBackColor = true;
            this.btnDonDatHang.Click += new System.EventHandler(this.btnDonDatHang_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1371, 100);
            this.label1.TabIndex = 8;
            // 
            // GUI_NhanVienSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 738);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_NhanVienSale";
            this.Text = "Hê thống quản lý nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQLDH;
        private System.Windows.Forms.Button btnDonDatHang;
        private System.Windows.Forms.Label label1;
    }
}