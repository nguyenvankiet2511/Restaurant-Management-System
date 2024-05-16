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

namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienSale
{
    public partial class UC_QuanLyDonHang : UserControl
    {
        BUS_DonHang bus_donHang= new BUS_DonHang();
        public UC_QuanLyDonHang()
        {
            InitializeComponent();
            LoadTables();
        }
        public void LoadTables()
        {
            dataGVDonHang.DataSource = bus_donHang.LayDanhSachDonHang();
            dataGVDonHang.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGVDonHang_Click_1(object sender, EventArgs e)
        {
            if (dataGVDonHang.CurrentRow != null)
            {
                int selectedIndex = dataGVDonHang.CurrentRow.Index;
                DataGridViewRow selectedRow = dataGVDonHang.Rows[selectedIndex];
                lbMaDonHang.Text= selectedRow.Cells["maDonHang"].Value.ToString();
                txtMaKH.Text= selectedRow.Cells["maKH"].Value.ToString();
                txtMaMonAn.Text = selectedRow.Cells["maMonAn"].Value.ToString();
                dateNgayDat.Value = Convert.ToDateTime( selectedRow.Cells["ngayDat"].Value);
                dateNgayXacNhan.Value =Convert.ToDateTime( selectedRow.Cells["ngayXacNhan"].Value);
                txtSoLuong.Text = selectedRow.Cells["soLuong"].Value.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int maDonHang = Convert.ToInt32(lbMaDonHang.Text);
            int maKH = Convert.ToInt32(txtMaKH.Text);
            int maMonAn = Convert.ToInt32(txtMaMonAn.Text);
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            DateTime ngayDat = dateNgayDat.Value;
            DateTime ngayXacNhan = dateNgayXacNhan.Value;
            DTO_DonHang donHang= new DTO_DonHang(maDonHang,ngayDat,ngayXacNhan,soLuong,maKH,maMonAn);
            if (bus_donHang.CapNhatDonHang(donHang))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maDonHang= Convert.ToInt32(lbMaDonHang.Text);
            if (bus_donHang.XoaDonHang(maDonHang))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
    }
}
