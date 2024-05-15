namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienSale
{
    partial class UC_DonDatHang
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
            this.dataGVDonDatHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGVDanhSachXacNhan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDanhSachXacNhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1379, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dang sách đơn đặt hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGVDonDatHang
            // 
            this.dataGVDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGVDonDatHang.Location = new System.Drawing.Point(0, 42);
            this.dataGVDonDatHang.Name = "dataGVDonDatHang";
            this.dataGVDonDatHang.RowHeadersWidth = 51;
            this.dataGVDonDatHang.RowTemplate.Height = 24;
            this.dataGVDonDatHang.Size = new System.Drawing.Size(1379, 196);
            this.dataGVDonDatHang.TabIndex = 1;
            this.dataGVDonDatHang.Click += new System.EventHandler(this.dataGVDonDatHang_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1379, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xác nhận đơn hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGVDanhSachXacNhan
            // 
            this.dataGVDanhSachXacNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDanhSachXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDanhSachXacNhan.Location = new System.Drawing.Point(0, 291);
            this.dataGVDanhSachXacNhan.Name = "dataGVDanhSachXacNhan";
            this.dataGVDanhSachXacNhan.RowHeadersWidth = 51;
            this.dataGVDanhSachXacNhan.RowTemplate.Height = 24;
            this.dataGVDanhSachXacNhan.Size = new System.Drawing.Size(1379, 466);
            this.dataGVDanhSachXacNhan.TabIndex = 5;
            this.dataGVDanhSachXacNhan.Click += new System.EventHandler(this.dataGVDanhSachXacNhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 657);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1379, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(306, 32);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(143, 46);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(563, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 46);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(810, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 46);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // UC_DonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGVDanhSachXacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGVDonDatHang);
            this.Controls.Add(this.label1);
            this.Name = "UC_DonDatHang";
            this.Size = new System.Drawing.Size(1379, 757);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDanhSachXacNhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVDonDatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGVDanhSachXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXacNhan;
    }
}
