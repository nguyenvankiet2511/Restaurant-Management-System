namespace GUI_RestaurantManager.UserControls
{
    partial class UC_DatBan
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
            this.panelBan = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMaBan = new System.Windows.Forms.Label();
            this.dateThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbBan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBan
            // 
            this.panelBan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBan.Controls.Add(this.label6);
            this.panelBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBan.Location = new System.Drawing.Point(0, 0);
            this.panelBan.Name = "panelBan";
            this.panelBan.Size = new System.Drawing.Size(1220, 797);
            this.panelBan.TabIndex = 0;
            this.panelBan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBan_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1220, 57);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thông tin bàn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập thông tin đặt bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaBan);
            this.groupBox1.Controls.Add(this.dateThoiGian);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lbBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1220, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 740);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbMaBan
            // 
            this.lbMaBan.AutoSize = true;
            this.lbMaBan.Location = new System.Drawing.Point(98, 518);
            this.lbMaBan.Name = "lbMaBan";
            this.lbMaBan.Size = new System.Drawing.Size(44, 16);
            this.lbMaBan.TabIndex = 25;
            this.lbMaBan.Text = "label8";
            this.lbMaBan.Visible = false;
            // 
            // dateThoiGian
            // 
            this.dateThoiGian.CalendarFont = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateThoiGian.Location = new System.Drawing.Point(314, 361);
            this.dateThoiGian.Name = "dateThoiGian";
            this.dateThoiGian.Size = new System.Drawing.Size(325, 22);
            this.dateThoiGian.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Thời gian:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Chocolate;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(441, 562);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(259, 62);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Brown;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(101, 562);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(269, 62);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Đặt bàn";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbBan
            // 
            this.lbBan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBan.Location = new System.Drawing.Point(314, 441);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(326, 43);
            this.lbBan.TabIndex = 19;
            this.lbBan.Text = "Chọn bàn đặt";
            this.lbBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vị trí bàn:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(314, 266);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(326, 33);
            this.txtGhiChu.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ghi chú:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(314, 173);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(326, 33);
            this.txtSoLuong.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng người: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(314, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 33);
            this.txtName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên khách hàng: ";
            // 
            // UC_DatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBan);
            this.Name = "UC_DatBan";
            this.Size = new System.Drawing.Size(1865, 797);
            this.panelBan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateThoiGian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaBan;
    }
}
