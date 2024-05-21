using BUS_RestaurantManager;
using DTO_RestaurantManager;
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
    public partial class GUI_DoiMatKhau : Form
    {
        BUS_TaiKhoan bus_taiKhoan = new BUS_TaiKhoan();

        BUS_DangNhap bus_DangNhap = new BUS_DangNhap();
        public GUI_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string username = txtTenDN.Text;
            string password = txtMKCu.Text;
            string newPassword = txtMKMoi.Text;
            string confirmNewPassword = txtNLMK.Text;

            // Kiểm tra xem các trường đã được điền đầy đủ hay không
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            DTO_TaiKhoan taiKhoan = bus_DangNhap.KiemTraTaiKhoan(username, password);


            if (taiKhoan == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.");
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp.");
                return;
            }


            taiKhoan.password = newPassword;
            if (bus_taiKhoan.UpdatePassword(taiKhoan))
            {
                MessageBox.Show("Cập nhật mật khẩu thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }
        }
    }
}
