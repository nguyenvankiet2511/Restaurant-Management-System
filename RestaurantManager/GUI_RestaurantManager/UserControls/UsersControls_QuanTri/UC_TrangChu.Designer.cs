namespace GUI_RestaurantManager.UserControls.UsersControls_QuanTri
{
    partial class UC_TrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSoLuongKhach = new System.Windows.Forms.Label();
            this.dataGVThongTinKH = new System.Windows.Forms.DataGridView();
            this.dataGVDonHang = new System.Windows.Forms.DataGridView();
            this.lbDoanhThuDonHang = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThongTinKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSoLuongKhach, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGVThongTinKH, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGVDonHang, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbDoanhThuDonHang, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTongDoanhThu, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1167, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang chủ quản lý nhà hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoLuongKhach
            // 
            this.lbSoLuongKhach.AutoSize = true;
            this.lbSoLuongKhach.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSoLuongKhach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongKhach.Location = new System.Drawing.Point(3, 54);
            this.lbSoLuongKhach.Name = "lbSoLuongKhach";
            this.lbSoLuongKhach.Size = new System.Drawing.Size(202, 54);
            this.lbSoLuongKhach.TabIndex = 1;
            this.lbSoLuongKhach.Text = "Số lượng khách";
            // 
            // dataGVThongTinKH
            // 
            this.dataGVThongTinKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVThongTinKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVThongTinKH.Location = new System.Drawing.Point(3, 111);
            this.dataGVThongTinKH.Name = "dataGVThongTinKH";
            this.dataGVThongTinKH.RowHeadersWidth = 51;
            this.dataGVThongTinKH.RowTemplate.Height = 24;
            this.dataGVThongTinKH.Size = new System.Drawing.Size(1167, 158);
            this.dataGVThongTinKH.TabIndex = 2;
            // 
            // dataGVDonHang
            // 
            this.dataGVDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDonHang.Location = new System.Drawing.Point(3, 329);
            this.dataGVDonHang.Name = "dataGVDonHang";
            this.dataGVDonHang.RowHeadersWidth = 51;
            this.dataGVDonHang.RowTemplate.Height = 24;
            this.dataGVDonHang.Size = new System.Drawing.Size(1167, 158);
            this.dataGVDonHang.TabIndex = 3;
            // 
            // lbDoanhThuDonHang
            // 
            this.lbDoanhThuDonHang.AutoSize = true;
            this.lbDoanhThuDonHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhThuDonHang.Location = new System.Drawing.Point(3, 272);
            this.lbDoanhThuDonHang.Name = "lbDoanhThuDonHang";
            this.lbDoanhThuDonHang.Size = new System.Drawing.Size(264, 32);
            this.lbDoanhThuDonHang.TabIndex = 4;
            this.lbDoanhThuDonHang.Text = "Doanh thu đơn hàng";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDoanhThu.Location = new System.Drawing.Point(3, 490);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(158, 32);
            this.lbTongDoanhThu.TabIndex = 5;
            this.lbTongDoanhThu.Text = "Doanh thu: ";
            // 
            // UC_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_TrangChu";
            this.Size = new System.Drawing.Size(1173, 548);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThongTinKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSoLuongKhach;
        private System.Windows.Forms.DataGridView dataGVThongTinKH;
        private System.Windows.Forms.DataGridView dataGVDonHang;
        private System.Windows.Forms.Label lbDoanhThuDonHang;
        private System.Windows.Forms.Label lbTongDoanhThu;
    }
}
