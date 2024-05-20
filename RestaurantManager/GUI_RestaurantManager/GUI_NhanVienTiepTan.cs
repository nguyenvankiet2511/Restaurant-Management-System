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
        public int CurrentUser { get; set; }
        public GUI_NhanVienTiepTan()
        {
            InitializeComponent();
            UC_DonDatBan uC_DonDatBan = new UC_DonDatBan();
            uC_DonDatBan.SetParentForm(this);
            addUserControl(uC_DonDatBan);

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
            uC_DonDatBan.SetParentForm(this);
            addUserControl(uC_DonDatBan);

        }

        private void GUI_NhanVienTiepTan_Load(object sender, EventArgs e)
        {
            label1.Text = CurrentUser.ToString();
        }

        private void btnQLBanAn_Click(object sender, EventArgs e)
        {
            UC_QuanLyBan uC_QuanLyBan = new UC_QuanLyBan();
            uC_QuanLyBan.SetParentForm(this);
            addUserControl(uC_QuanLyBan);
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_DangNhap dangNhap = new GUI_DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {

        }
    }
}
