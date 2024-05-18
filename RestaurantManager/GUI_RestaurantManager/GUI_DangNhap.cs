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
    public partial class GUI_DangNhap : Form
    {
        
        BUS_DangNhap bus_DangNhap= new BUS_DangNhap();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username= txtUsername.Text;
            string password= txtPassword.Text;
            if(username.Trim()=="")
            {
                MessageBox.Show("Nhập tên đăng nhập!");
                return;
            }
            else if(password.Trim()=="")
            {
                MessageBox.Show("Nhập mật khẩu !");
                return;
            }
            else
            {
                DTO_TaiKhoan taiKhoan= bus_DangNhap.KiemTraTaiKhoan(username, password);
                if (taiKhoan!=null)
                {
                    switch (taiKhoan.loaiTaiKhoan)
                    {
                        case 1:
                            this.Hide();
                            GUI_QuanTri quantri = new GUI_QuanTri();
                            quantri.CurrentUser = Convert.ToInt32(taiKhoan.nguoiDungId.ToString());
                            MessageBox.Show(quantri.CurrentUser.ToString());
                            quantri.ShowDialog();
                            this.Close();
                            break;
                        case 2:
                            this.Hide();
                            GUI_NhanVienTiepTan nhanVienTT= new GUI_NhanVienTiepTan();
                            nhanVienTT.CurrentUser = Convert.ToInt32(taiKhoan.nguoiDungId.ToString());
                            MessageBox.Show(nhanVienTT.CurrentUser.ToString());
                            nhanVienTT.ShowDialog();
                            this.Close();
                            break;
                        case 3:
                            this.Hide();
                            GUI_NhanVienThuNgan nhanVienTN = new GUI_NhanVienThuNgan();
                            nhanVienTN.CurrentUser = Convert.ToInt32(taiKhoan.nguoiDungId.ToString());
                            MessageBox.Show(nhanVienTN.CurrentUser.ToString());
                            nhanVienTN.ShowDialog();
                            this.Close();
                            break;
                        case 4:
                            this.Hide();
                            GUI_NhanVienSale nhanVienSale = new GUI_NhanVienSale();
                            nhanVienSale.CurrentUser = Convert.ToInt32(taiKhoan.nguoiDungId.ToString());
                            MessageBox.Show(nhanVienSale.CurrentUser.ToString());
                            nhanVienSale.ShowDialog();
                            this.Close();
                            break;
                        case 5:
                            this.Hide();
                            GUI_KhachHang khachHang = new GUI_KhachHang();
                            khachHang.CurrentUserKH = Convert.ToInt32(taiKhoan.nguoiDungId.ToString());
                            MessageBox.Show(khachHang.CurrentUserKH.ToString());
                            khachHang.ShowDialog();
                            this.Close();
                            break;
                    }
                    MessageBox.Show("Đăng nhập thành công");
                    return;
                }
                else 
                {
                    MessageBox.Show("Đăng nhập không thành công");
                    return;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GUI_QuenMatKhau quenMatKhau= new GUI_QuenMatKhau();
            quenMatKhau.ShowDialog();
            this.Close();
        }
        private void linkDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GUI_DangKi dangKi = new GUI_DangKi();
            dangKi.ShowDialog();
            this.Close();
        }
    }
}
