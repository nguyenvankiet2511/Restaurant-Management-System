using GUI_RestaurantManager.UserControls.UsersControls_NhanVienSale;
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
    public partial class GUI_NhanVienSale : Form
    {
        public int CurrentUser { get; set; }
        public GUI_NhanVienSale()
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
        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            UC_DonDatHang uC_DonDatHang = new UC_DonDatHang();
            uC_DonDatHang.SetFromParent(this);
            addUserControl(uC_DonDatHang);

        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            UC_QuanLyDonHang uc_QLDH= new UC_QuanLyDonHang();
            addUserControl(uc_QLDH);
        }
    }
}
