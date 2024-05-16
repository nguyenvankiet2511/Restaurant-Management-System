namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienThuNgan
{
    partial class UC_ThanhToanDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGVDonHang = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaDonHang = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1161, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh toán đơn hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.lbThanhTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbMaDonHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 521);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dataGVDonHang
            // 
            this.dataGVDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDonHang.Location = new System.Drawing.Point(0, 39);
            this.dataGVDonHang.Name = "dataGVDonHang";
            this.dataGVDonHang.RowHeadersWidth = 51;
            this.dataGVDonHang.RowTemplate.Height = 24;
            this.dataGVDonHang.Size = new System.Drawing.Size(1161, 482);
            this.dataGVDonHang.TabIndex = 3;
            this.dataGVDonHang.Click += new System.EventHandler(this.dataGVDonHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(570, 35);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(180, 50);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(821, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa đơn hàng";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã đơn hàng";
            // 
            // lbMaDonHang
            // 
            this.lbMaDonHang.BackColor = System.Drawing.Color.Honeydew;
            this.lbMaDonHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMaDonHang.Location = new System.Drawing.Point(235, 35);
            this.lbMaDonHang.Name = "lbMaDonHang";
            this.lbMaDonHang.Size = new System.Drawing.Size(179, 26);
            this.lbMaDonHang.TabIndex = 4;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.BackColor = System.Drawing.Color.Honeydew;
            this.lbThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbThanhTien.Location = new System.Drawing.Point(235, 76);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(179, 26);
            this.lbThanhTien.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành tiền";
            // 
            // UC_ThanhToanDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGVDonHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_ThanhToanDonHang";
            this.Size = new System.Drawing.Size(1161, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dataGVDonHang;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaDonHang;
        private System.Windows.Forms.Label label2;
    }
}
