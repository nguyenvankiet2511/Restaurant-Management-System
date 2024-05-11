using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_RestaurantManager.UserControls.UsersControls_TiepTan;

namespace GUI_RestaurantManager
{
    public partial class GUI_NhanVienTiepTan : Form
    {
        public GUI_NhanVienTiepTan()
        {
            InitializeComponent();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelTiepTan.Controls.Clear();
            panelTiepTan.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnDonDatBan_Click(object sender, EventArgs e)
        {
            UC_DonDatBan uC_DonDatBan = new UC_DonDatBan();
            addUserControl(uC_DonDatBan);
        }
    }
}
