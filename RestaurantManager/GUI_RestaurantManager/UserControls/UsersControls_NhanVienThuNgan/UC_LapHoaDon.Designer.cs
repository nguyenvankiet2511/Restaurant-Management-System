namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienThuNgan
{
    partial class UC_LapHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtMaBanDat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxKM = new System.Windows.Forms.CheckBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTienMon = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGVThucDon = new System.Windows.Forms.DataGridView();
            this.lbTienBan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbViTri = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMaBan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThucDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.txtMaBanDat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 152);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1293, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lập hóa đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(742, 62);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(204, 46);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem thông tin";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtMaBanDat
            // 
            this.txtMaBanDat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBanDat.Location = new System.Drawing.Point(414, 70);
            this.txtMaBanDat.Name = "txtMaBanDat";
            this.txtMaBanDat.Size = new System.Drawing.Size(275, 33);
            this.txtMaBanDat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã bàn đặt";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkKhaki;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1293, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thông tin hóa đơn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.checkBoxKM);
            this.panel2.Controls.Add(this.lbTongTien);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lbTienMon);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dataGVThucDon);
            this.panel2.Controls.Add(this.lbTienBan);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lbViTri);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbMaBan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1293, 571);
            this.panel2.TabIndex = 2;
            // 
            // checkBoxKM
            // 
            this.checkBoxKM.AutoSize = true;
            this.checkBoxKM.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKM.Location = new System.Drawing.Point(88, 174);
            this.checkBoxKM.Name = "checkBoxKM";
            this.checkBoxKM.Size = new System.Drawing.Size(139, 29);
            this.checkBoxKM.TabIndex = 12;
            this.checkBoxKM.Text = "Khuyến mãi";
            this.checkBoxKM.UseVisualStyleBackColor = true;
            this.checkBoxKM.CheckedChanged += new System.EventHandler(this.checkBoxKM_CheckedChanged);
            // 
            // lbTongTien
            // 
            this.lbTongTien.BackColor = System.Drawing.Color.LightBlue;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(252, 227);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(170, 23);
            this.lbTongTien.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "Thành tiền";
            // 
            // lbTienMon
            // 
            this.lbTienMon.BackColor = System.Drawing.Color.LightBlue;
            this.lbTienMon.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienMon.Location = new System.Drawing.Point(252, 130);
            this.lbTienMon.Name = "lbTienMon";
            this.lbTienMon.Size = new System.Drawing.Size(170, 23);
            this.lbTienMon.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(81, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tiền món ăn";
            // 
            // dataGVThucDon
            // 
            this.dataGVThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVThucDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGVThucDon.Location = new System.Drawing.Point(647, 0);
            this.dataGVThucDon.Name = "dataGVThucDon";
            this.dataGVThucDon.RowHeadersWidth = 51;
            this.dataGVThucDon.RowTemplate.Height = 24;
            this.dataGVThucDon.Size = new System.Drawing.Size(646, 484);
            this.dataGVThucDon.TabIndex = 7;
            // 
            // lbTienBan
            // 
            this.lbTienBan.BackColor = System.Drawing.Color.LightBlue;
            this.lbTienBan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienBan.Location = new System.Drawing.Point(252, 90);
            this.lbTienBan.Name = "lbTienBan";
            this.lbTienBan.Size = new System.Drawing.Size(170, 23);
            this.lbTienBan.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tiền đặt bàn";
            // 
            // lbViTri
            // 
            this.lbViTri.BackColor = System.Drawing.Color.LightBlue;
            this.lbViTri.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViTri.Location = new System.Drawing.Point(252, 51);
            this.lbViTri.Name = "lbViTri";
            this.lbViTri.Size = new System.Drawing.Size(170, 23);
            this.lbViTri.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vị trí";
            // 
            // lbMaBan
            // 
            this.lbMaBan.BackColor = System.Drawing.Color.LightBlue;
            this.lbMaBan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaBan.Location = new System.Drawing.Point(252, 13);
            this.lbMaBan.Name = "lbMaBan";
            this.lbMaBan.Size = new System.Drawing.Size(170, 23);
            this.lbMaBan.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã bàn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 484);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1293, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(668, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(336, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lập hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UC_LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "UC_LapHoaDon";
            this.Size = new System.Drawing.Size(1293, 772);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThucDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtMaBanDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxKM;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTienMon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGVThucDon;
        private System.Windows.Forms.Label lbTienBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbViTri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaBan;
        private System.Windows.Forms.Label label4;
    }
}
