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

namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienThuNgan
{
    public partial class UC_ThanhToanDonHang : UserControl

    {
        BUS_DonHang bus_donHang = new BUS_DonHang();
        BUS_MonAn bus_monAn = new BUS_MonAn();
        BUS_HoaDon bus_hoaDon= new BUS_HoaDon();
        public UC_ThanhToanDonHang()
        {
            InitializeComponent();
            LoadTables();
        }
        public void LoadTables()
        {
            dataGVDonHang.DataSource = bus_donHang.LayDanhSachDonHang();
            dataGVDonHang.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVDonHang.Columns["maDonHang"].HeaderText = "Mã đơn hàng";
            dataGVDonHang.Columns["trangThai"].HeaderText = "Trạng thái";
            dataGVDonHang.Columns["ngayDat"].HeaderText = "Ngày đặt";
            dataGVDonHang.Columns["ngayXacNhan"].HeaderText = "Ngày xác nhận";
            dataGVDonHang.Columns["soLuong"].HeaderText = "Số lượng";
            dataGVDonHang.Columns["maKH"].HeaderText = "Mã khách hàng";
            dataGVDonHang.Columns["maNVSale"].HeaderText = "Mã nhân viên";
            dataGVDonHang.Columns["maMonAn"].HeaderText = "Mã món ăn";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGVDonHang.CurrentRow != null)
            {
                int selectedIndex = dataGVDonHang.CurrentRow.Index;
                DataGridViewRow selectedRow = dataGVDonHang.Rows[selectedIndex];
                int maDonHang = Convert.ToInt32(selectedRow.Cells["maDonHang"]);
                if (bus_donHang.XoaDonHang(maDonHang))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Chọn ít nhất 1 dòng để xóa!");
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGVDonHang.CurrentRow != null)
            {
                int selectedIndex = dataGVDonHang.CurrentRow.Index;
                DataGridViewRow selectedRow = dataGVDonHang.Rows[selectedIndex];
                int maMon = Convert.ToInt32(selectedRow.Cells["maMonAn"].Value);
                int maDonHang = Convert.ToInt32(selectedRow.Cells["maDonHang"].Value);
                int thanhTien= Convert.ToInt32(lbThanhTien.Text);
                int soLuong = Convert.ToInt32(selectedRow.Cells["soLuong"].Value);
                DTO_MonAn monAn = bus_monAn.LayGiaMonAn(maMon);
                DTO_HoaDonDonHang hoaDon = new DTO_HoaDonDonHang(monAn.tenMon, monAn.giaMon, soLuong, thanhTien, maDonHang);
                if (bus_hoaDon.ThemHoaDonDonHang(hoaDon))
                {
                    bus_donHang.DoiTrangThaiDonHang(maDonHang);
                    LoadTables();
                    MessageBox.Show("Thanh toán thành công");
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công");
                }
            }
        }

        private void dataGVDonHang_Click(object sender, EventArgs e)
        {
            if (dataGVDonHang.CurrentRow != null)
            {
                int selectedIndex = dataGVDonHang.CurrentRow.Index;
                DataGridViewRow selectedRow = dataGVDonHang.Rows[selectedIndex];
                lbMaDonHang.Text = selectedRow.Cells["maDonHang"].Value.ToString();
                int maMon = Convert.ToInt32(selectedRow.Cells["maMonAn"].Value);
                int soLuong = Convert.ToInt32(selectedRow.Cells["soLuong"].Value);
                DTO_MonAn monAn = bus_monAn.LayGiaMonAn(maMon);
                lbThanhTien.Text = (monAn.giaMon * soLuong).ToString();
            }
        }
    }
}
