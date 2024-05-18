using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_hoaDon= new DAL_HoaDon();
        public BUS_HoaDon() { }
        public bool ThemHoaDon(DTO_HoaDon hoaDon)
        {
            return dal_hoaDon.ThemHoaDon(hoaDon);
        }
        public DataTable LayDanhSachHoaDon()
        {
            return dal_hoaDon.LayDanhSachHoaDon();
        }
        public bool ThemHoaDonDonHang(DTO_HoaDonDonHang hoaDon)
        {
            return dal_hoaDon.ThemHoaDonDonHang(hoaDon);
        }
        public DataTable LayDoanhThuTheoThang(int nam)
        {
            return dal_hoaDon.LayDoanhThuTheoThang(nam);
        }
        public DataTable LaySoLuongKhachTheoThang(int nam)
        {
            return dal_hoaDon.LaySoLuongKhachTheoThang(nam);
        }
        public DataTable LayDoanhThuDonHangTheoThang(int nam)
        {
            return dal_hoaDon.LayDoanhThuDonHang(nam);
        }
    }
}
