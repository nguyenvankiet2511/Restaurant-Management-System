using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_RestaurantManager.UserControls.UsersControls_NhanVienThuNgan;

namespace GUI_RestaurantManager
{
    public partial class GUI_NhanVienThuNgan : Form
    {
        public int CurrentUser { get; set; }
        public GUI_NhanVienThuNgan()
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
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            UC_ThanhToanHoaDon uc_lapHoaDon = new UC_ThanhToanHoaDon();
            uc_lapHoaDon.SetFormParent(this);
            addUserControl(uc_lapHoaDon);
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            UC_XemHoaDon uc_xemHoaDon = new UC_XemHoaDon();
            addUserControl(uc_xemHoaDon);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
