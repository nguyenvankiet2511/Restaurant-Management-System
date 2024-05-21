namespace GUI_RestaurantManager
{
    partial class GUI_KhachHang
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
            this.menuCustomer = new System.Windows.Forms.MenuStrip();
            this.gioiThieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinTứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXemMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatMon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuCustomer
            // 
            this.menuCustomer.AutoSize = false;
            this.menuCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuCustomer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gioiThieuToolStripMenuItem,
            this.tinTứcToolStripMenuItem,
            this.menuXemMonAn,
            this.menuDatBan,
            this.menuDatMon,
            this.menuDatHang,
            this.liênHệToolStripMenuItem,
            this.menuDangXuat});
            this.menuCustomer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuCustomer.Location = new System.Drawing.Point(0, 0);
            this.menuCustomer.Name = "menuCustomer";
            this.menuCustomer.Size = new System.Drawing.Size(1099, 50);
            this.menuCustomer.TabIndex = 1;
            this.menuCustomer.Text = "menuStrip1";
            // 
            // gioiThieuToolStripMenuItem
            // 
            this.gioiThieuToolStripMenuItem.Name = "gioiThieuToolStripMenuItem";
            this.gioiThieuToolStripMenuItem.Size = new System.Drawing.Size(123, 46);
            this.gioiThieuToolStripMenuItem.Text = "Giới thiệu";
            this.gioiThieuToolStripMenuItem.Click += new System.EventHandler(this.gioiThieuToolStripMenuItem_Click);
            // 
            // tinTứcToolStripMenuItem
            // 
            this.tinTứcToolStripMenuItem.Name = "tinTứcToolStripMenuItem";
            this.tinTứcToolStripMenuItem.Size = new System.Drawing.Size(98, 46);
            this.tinTứcToolStripMenuItem.Text = "Tin tức";
            // 
            // menuXemMonAn
            // 
            this.menuXemMonAn.Name = "menuXemMonAn";
            this.menuXemMonAn.Size = new System.Drawing.Size(152, 46);
            this.menuXemMonAn.Text = "Xem món ăn";
            this.menuXemMonAn.Click += new System.EventHandler(this.menuXemMonAn_Click);
            // 
            // menuDatBan
            // 
            this.menuDatBan.Name = "menuDatBan";
            this.menuDatBan.Size = new System.Drawing.Size(107, 46);
            this.menuDatBan.Text = "Đặt bàn";
            this.menuDatBan.Click += new System.EventHandler(this.menuDatBan_Click);
            // 
            // menuDatMon
            // 
            this.menuDatMon.Name = "menuDatMon";
            this.menuDatMon.Size = new System.Drawing.Size(113, 46);
            this.menuDatMon.Text = "Đặt món";
            this.menuDatMon.Click += new System.EventHandler(this.menuDatMon_Click);
            // 
            // menuDatHang
            // 
            this.menuDatHang.Name = "menuDatHang";
            this.menuDatHang.Size = new System.Drawing.Size(119, 46);
            this.menuDatHang.Text = "Đặt hàng";
            this.menuDatHang.Click += new System.EventHandler(this.menuDatHang_Click);
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(99, 46);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(130, 46);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1099, 625);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // GUI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 675);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuCustomer);
            this.Name = "GUI_KhachHang";
            this.Text = "Nhà hàng MICONET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_KhachHang_Load);
            this.menuCustomer.ResumeLayout(false);
            this.menuCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuCustomer;
        private System.Windows.Forms.ToolStripMenuItem gioiThieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinTứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuXemMonAn;
        private System.Windows.Forms.ToolStripMenuItem menuDatBan;
        private System.Windows.Forms.ToolStripMenuItem menuDatMon;
        private System.Windows.Forms.ToolStripMenuItem menuDatHang;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
    }
}