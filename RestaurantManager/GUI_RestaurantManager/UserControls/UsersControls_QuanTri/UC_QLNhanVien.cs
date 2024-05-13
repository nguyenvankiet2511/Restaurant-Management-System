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

namespace GUI_RestaurantManager.UserControls.UsersControls_QuanTri
{
    public partial class UC_QLNhanVien : UserControl
    {
        BUS_NguoiDung bus_nguoiDung= new BUS_NguoiDung();
        BUS_NhanVien bus_nhanVien= new BUS_NhanVien();
        public UC_QLNhanVien()
        {
            InitializeComponent();
            LoadTablesNhanVien();
        }
        public void LoadTablesNhanVien()
        {
            dataGVNhanVien.DataSource = bus_nguoiDung.LayDanhSachNhanVien();
            dataGVNhanVien.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVNhanVien.Columns["idNguoiDung"].HeaderText = "Mã nhân viên";
            dataGVNhanVien.Columns["ten_nguoi_dung"].HeaderText = "Tên nhân viên";
            dataGVNhanVien.Columns["email"].HeaderText = "Email";
            dataGVNhanVien.Columns["namSinh"].HeaderText = "Năm sinh";
            dataGVNhanVien.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            dataGVNhanVien.Columns["diaChi"].HeaderText = "Địa chỉ";
            dataGVNhanVien.Columns["bangCap"].HeaderText = "Bằng cấp";
            dataGVNhanVien.Columns["loaiTaiKhoan"].HeaderText = "Loại tài khoản";
            dataGVNhanVien.Refresh();
        }

      

        private void dataGVNhanVien_Click(object sender, EventArgs e)
        {
            if (dataGVNhanVien.CurrentRow != null)
            {
                // Lấy hàng hiện tại được chọn trong DataGridView
                DataGridViewRow row = dataGVNhanVien.CurrentRow;
                txtMaNhanVien.Text = row.Cells["idNguoiDung"].Value.ToString();
                txtTenNV.Text = row.Cells["ten_nguoi_dung"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                dateNamSinh.Value = (DateTime)row.Cells["namSinh"].Value;
                txtSoDienThoai.Text = row.Cells["soDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["diaChi"].Value.ToString();
                txtBangCap.Text = row.Cells["bangCap"].Value.ToString();
                txtChucVu.Text = row.Cells["loaiTaiKhoan"].Value.ToString();
            }
        }
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtTenNV.Text;
            string email = txtEmail.Text;
            DateTime namSinh = dateNamSinh.Value;
            string soDienThoai = txtSoDienThoai.Text;
            string diaChi = txtDiaChi.Text;
            string bangCap = txtBangCap.Text;
            int loaiTaiKhoan = Convert.ToInt32(txtChucVu.Text);
            DTO_NguoiDung nguoiDung = new DTO_NguoiDung( tenNhanVien, email, namSinh, soDienThoai, diaChi);
            int maNhanVienMoi = bus_nguoiDung.ThemNguoiDungMoi(nguoiDung);
            bool result_nhanVien = false;
            switch (loaiTaiKhoan)
            {
                case 2:
                    DTO_NhanVienTiepTan nhanVien = new DTO_NhanVienTiepTan(maNhanVienMoi, bangCap);
                    result_nhanVien = bus_nhanVien.ThemNhanVienTiepTan(nhanVien);
                    break;
                case 3:
                    DTO_NhanVienThuNgan nhanVienTN = new DTO_NhanVienThuNgan(maNhanVienMoi, bangCap);
                    result_nhanVien = bus_nhanVien.ThemNhanVienThuNgan(nhanVienTN);
                    break;
                case 4:
                    DTO_NhanVienSale nhanVienSale = new DTO_NhanVienSale(maNhanVienMoi, bangCap);
                    result_nhanVien = bus_nhanVien.ThemNhanVienSale(nhanVienSale);
                    break;
            }
            if (result_nhanVien == true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int maNhanVien = Convert.ToInt32(txtMaNhanVien.Text);
            string tenNhanVien= txtTenNV.Text;
            string email = txtEmail.Text;
            DateTime namSinh = dateNamSinh.Value;
            string soDienThoai= txtSoDienThoai.Text;
            string diaChi= txtDiaChi.Text;
            string bangCap= txtBangCap.Text;
            int loaiTaiKhoan= Convert.ToInt32(txtChucVu.Text);
            DTO_NguoiDung nguoiDung= new DTO_NguoiDung(maNhanVien,tenNhanVien,email,namSinh,soDienThoai,diaChi);
            bool result= bus_nguoiDung.CapNhatThongTinNhanVien(nguoiDung);
            bool result_nhanVien = false;
            switch (loaiTaiKhoan)
            {
                case 2:
                    DTO_NhanVienTiepTan nhanVien = new DTO_NhanVienTiepTan(maNhanVien, bangCap);
                    result_nhanVien = bus_nhanVien.CapNhatNhanVienTiepTan(nhanVien);
                    break;
                case 3:
                    DTO_NhanVienThuNgan nhanVienTN = new DTO_NhanVienThuNgan(maNhanVien, bangCap);
                    result_nhanVien = bus_nhanVien.CapNhatNhanVienThuNgan(nhanVienTN);
                    break;
                case 4:
                    DTO_NhanVienSale nhanVienSale = new DTO_NhanVienSale(maNhanVien, bangCap);
                    result_nhanVien = bus_nhanVien.CapNhatNhanVienSale(nhanVienSale);
                    break;
            }
            if (result==true&& result_nhanVien==true)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maNhanVien = Convert.ToInt32(txtMaNhanVien.Text);
            int loaiTaiKhoan = Convert.ToInt32(txtChucVu.Text);
            bool result = false;
            if (bus_nguoiDung.XoaNguoiDung(maNhanVien))
            {
                switch (loaiTaiKhoan)
                {
                    case 2:
                        result = bus_nhanVien.XoaNhanVienTiepTan(maNhanVien);
                        break;
                    case 3:
                        result = bus_nhanVien.XoaNhanVienThuNgan(maNhanVien);
                        break;
                    case 4:
                        result = bus_nhanVien.XoaNhanVienSale(maNhanVien);
                        break;
                }
            }
            if (result == true )
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
    }
}
