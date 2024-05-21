using BUS_RestaurantManager;
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
    public partial class UC_TrangChu : UserControl
    {
        BUS_BanDat bus_banDat = new BUS_BanDat();
        BUS_KhachHang bus_khachHang= new BUS_KhachHang();
        BUS_HoaDon bus_hoaDon= new BUS_HoaDon();
        public UC_TrangChu()
        {
            InitializeComponent();
            LoadLable();
            LoadDataKhachHang();
            LoadDataDonHang();
        }
        public void LoadLable()
        {
            lbSoLuongKhach.Text = "Số lượng khách: " + bus_banDat.LaySoLuongBanDatTrongNgay();
            lbDoanhThuDonHang.Text = "Doang thu đơn hàng: " + bus_hoaDon.DoanhThuDonHangTrongNgay();
            lbTongDoanhThu.Text= "Tổng doang thu: "+ bus_hoaDon.LayDoanhThuTheoNgay();
        }
        public void LoadDataKhachHang()
        {
            dataGVThongTinKH.DataSource = bus_khachHang.LayThongTinKhachHangDatBan();
            dataGVThongTinKH.RowTemplate.Height = 30; // Đặt chiều cao của mỗi dòng
            dataGVThongTinKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVThongTinKH.Columns["ten_nguoi_dung"].HeaderText = "Tên khách hàng";
            dataGVThongTinKH.Columns["diaChi"].HeaderText = "Địa chỉ";
            dataGVThongTinKH.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            dataGVThongTinKH.Columns["maBanDat"].HeaderText = "Mã bàn đặt";
            dataGVThongTinKH.Columns["soLuongNguoi"].HeaderText = "Số lượng người";
            dataGVThongTinKH.Columns["viTri"].HeaderText = "Vị trí bàn";
            dataGVThongTinKH.Columns["thoiGian"].HeaderText = "Thời gian đặt bàn";
        }
        public void LoadDataDonHang()
        {
            dataGVDonHang.DataSource = bus_hoaDon.LayThongTinDonHangTrongNgay();
            dataGVDonHang.RowTemplate.Height = 30; // Đặt chiều cao của mỗi dòng
            dataGVDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVDonHang.Columns["tenMon"].HeaderText = "Tên món ăn";
            dataGVDonHang.Columns["giaMon"].HeaderText = "Giá món ăn";
            dataGVDonHang.Columns["soLuong"].HeaderText = "Số lượng";
            dataGVDonHang.Columns["thanhTien"].HeaderText = "Thành tiền";
            dataGVDonHang.Columns["ngayLap"].HeaderText = "Ngày đặt hàng";
            dataGVDonHang.Columns["maHDDH"].Visible = false;
            dataGVDonHang.Columns["maDonHang"].Visible = false;
        }
    }
}
