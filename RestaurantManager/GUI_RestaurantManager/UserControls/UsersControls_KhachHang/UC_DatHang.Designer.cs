namespace GUI_RestaurantManager.UserControls.UsersControls_KhachHang
{
    partial class UC_DatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVDonHangDat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGVDonHangXacNhan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMaDSDH = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMonAn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGVMonAn = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHangDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHangXacNhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1523, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn hàng đã đặt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGVDonHangDat
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVDonHangDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVDonHangDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVDonHangDat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVDonHangDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGVDonHangDat.Location = new System.Drawing.Point(0, 49);
            this.dataGVDonHangDat.Name = "dataGVDonHangDat";
            this.dataGVDonHangDat.RowHeadersWidth = 51;
            this.dataGVDonHangDat.RowTemplate.Height = 24;
            this.dataGVDonHangDat.Size = new System.Drawing.Size(1523, 214);
            this.dataGVDonHangDat.TabIndex = 1;
            this.dataGVDonHangDat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVDonHangDat_CellContentClick);
            this.dataGVDonHangDat.Click += new System.EventHandler(this.dataGVDonHangDat_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1523, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn hàng đã được xác nhận";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGVDonHangXacNhan
            // 
            this.dataGVDonHangXacNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDonHangXacNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGVDonHangXacNhan.Location = new System.Drawing.Point(0, 322);
            this.dataGVDonHangXacNhan.Name = "dataGVDonHangXacNhan";
            this.dataGVDonHangXacNhan.RowHeadersWidth = 51;
            this.dataGVDonHangXacNhan.RowTemplate.Height = 24;
            this.dataGVDonHangXacNhan.Size = new System.Drawing.Size(1523, 198);
            this.dataGVDonHangXacNhan.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.lbMaDSDH);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxMonAn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGVMonAn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1523, 370);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbMaDSDH
            // 
            this.lbMaDSDH.AutoSize = true;
            this.lbMaDSDH.Location = new System.Drawing.Point(1336, 255);
            this.lbMaDSDH.Name = "lbMaDSDH";
            this.lbMaDSDH.Size = new System.Drawing.Size(0, 25);
            this.lbMaDSDH.TabIndex = 9;
            this.lbMaDSDH.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1287, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 62);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa đơn hàng";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1093, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 62);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa đơn hàng";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(909, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 62);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm đơn hàng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(642, 302);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(190, 33);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(476, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn món ăn";
            // 
            // comboBoxMonAn
            // 
            this.comboBoxMonAn.FormattingEnabled = true;
            this.comboBoxMonAn.Location = new System.Drawing.Point(238, 301);
            this.comboBoxMonAn.Name = "comboBoxMonAn";
            this.comboBoxMonAn.Size = new System.Drawing.Size(188, 33);
            this.comboBoxMonAn.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(60, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn món ăn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGVMonAn
            // 
            this.dataGVMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGVMonAn.Location = new System.Drawing.Point(3, 64);
            this.dataGVMonAn.Name = "dataGVMonAn";
            this.dataGVMonAn.RowHeadersWidth = 51;
            this.dataGVMonAn.RowTemplate.Height = 24;
            this.dataGVMonAn.Size = new System.Drawing.Size(1517, 174);
            this.dataGVMonAn.TabIndex = 1;
            this.dataGVMonAn.Click += new System.EventHandler(this.dataGVMonAn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1517, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách món ăn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_DatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGVDonHangXacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGVDonHangDat);
            this.Controls.Add(this.label1);
            this.Name = "UC_DatHang";
            this.Size = new System.Drawing.Size(1523, 890);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHangDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonHangXacNhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVDonHangDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGVDonHangXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGVMonAn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMonAn;
        private System.Windows.Forms.Label lbMaDSDH;
    }
}
