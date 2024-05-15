namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienThuNgan
{
    partial class UC_XemHoaDon
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
            this.dataGVHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVHoaDon
            // 
            this.dataGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dataGVHoaDon.Name = "dataGVHoaDon";
            this.dataGVHoaDon.RowHeadersWidth = 51;
            this.dataGVHoaDon.RowTemplate.Height = 24;
            this.dataGVHoaDon.Size = new System.Drawing.Size(1398, 801);
            this.dataGVHoaDon.TabIndex = 0;
            this.dataGVHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVHoaDon_CellContentClick);
            // 
            // UC_XemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGVHoaDon);
            this.Name = "UC_XemHoaDon";
            this.Size = new System.Drawing.Size(1398, 801);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVHoaDon;
    }
}
