using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_RestaurantManager.UserControls.UsersControls_QuanTri;
namespace GUI_RestaurantManager
{
    public partial class GUI_QuanTri : Form
    {
        public int CurrentUser { get; set; }
        public GUI_QuanTri()
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

        private void GUI_QuanTri_Load(object sender, EventArgs e)
        {
            btnTrangChu_Click(sender, e);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            UC_TrangChu uC_TrangChu = new UC_TrangChu();
            addUserControl(uC_TrangChu);
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            UC_QLMonAn uc_qlMonAn = new UC_QLMonAn();
            addUserControl(uc_qlMonAn);

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            UC_QLNhanVien uc_qlNhanVien= new UC_QLNhanVien();
            addUserControl(uc_qlNhanVien);
        }

        private void btnTKBC_Click(object sender, EventArgs e)
        {
            UC_TKBC uc_TKBC = new UC_TKBC();
            addUserControl(uc_TKBC);
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            UC_ThayDoiQuyDinh uc_quyDinh= new UC_ThayDoiQuyDinh();
            addUserControl(uc_quyDinh);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_DangNhap dangNhap = new GUI_DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
