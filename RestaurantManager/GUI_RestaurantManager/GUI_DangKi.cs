using BUS_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_RestaurantManager
{
    public partial class GUI_DangKi : Form
    {
        BUS_NguoiDung bus_nguoiDung= new BUS_NguoiDung();
        BUS_TaiKhoan bus_taiKhoan = new BUS_TaiKhoan();
        public GUI_DangKi()
        {
            InitializeComponent();
        }

        private void GUI_DangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string hoVaTen=txtName.Text;
            DateTime ngaySinh= dateNgaySinh.Value;
            string email=txtEmail.Text;
            string diaChi=txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string username= txtUsername.Text;
            string password= txtPassword.Text;
            DTO_NguoiDung nguoiDung= new DTO_NguoiDung(hoVaTen,email,ngaySinh,soDienThoai,diaChi);
            int maKH= bus_nguoiDung.ThemNguoiDungMoi(nguoiDung);
            DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan(hoVaTen, username, password, maKH);
            if (bus_taiKhoan.ThemTaiKhoan(taiKhoan))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
