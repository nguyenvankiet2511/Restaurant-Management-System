﻿using GUI_RestaurantManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_RestaurantManager
{
    public partial class GUI_KhachHang : Form
    {
        public int CurrentUser { get; set; }
        public GUI_KhachHang()
        {
            InitializeComponent();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {

        }
        private void menuXemMonAn_Click(object sender, EventArgs e)
        {
            UC_XemMonAn uc_XemMonAn = new UC_XemMonAn();
            addUserControl(uc_XemMonAn);
        }

        private void menuDatBan_Click(object sender, EventArgs e)
        {
            UC_DatBan uc_datBan = new UC_DatBan();
            uc_datBan.SetParentForm(this);
            addUserControl(uc_datBan);
        }

        private void menuDatMon_Click(object sender, EventArgs e)
        {
            UC_DatMon uc_datMon = new UC_DatMon();
            addUserControl(uc_datMon);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
