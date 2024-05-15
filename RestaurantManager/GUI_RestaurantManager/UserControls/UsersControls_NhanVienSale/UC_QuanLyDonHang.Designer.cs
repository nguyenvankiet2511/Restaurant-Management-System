namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienSale
{
    partial class UC_QuanLyDonHang
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
            this.dataGVDonHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVDonHang
            // 
            this.dataGVDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGVDonHang.Location = new System.Drawing.Point(0, 0);
            this.dataGVDonHang.Name = "dataGVDonHang";
            this.dataGVDonHang.RowHeadersWidth = 51;
            this.dataGVDonHang.RowTemplate.Height = 24;
            this.dataGVDonHang.Size = new System.Drawing.Size(1385, 323);
            this.dataGVDonHang.TabIndex = 0;
            this.dataGVDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVDonHang_CellContentClick);
            this.dataGVDonHang.Click += new System.EventHandler(this.dataGVDonHang_Click);
            // 
            // UC_QuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGVDonHang);
            this.Name = "UC_QuanLyDonHang";
            this.Size = new System.Drawing.Size(1385, 793);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVDonHang;
    }
}
