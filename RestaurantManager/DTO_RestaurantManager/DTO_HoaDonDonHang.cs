using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_HoaDonDonHang
    {
        public int maCTHD { get; set; }
        public string tenMon { get; set; }
        public float giaMon { get; set; }
        public int soLuong { get; set; }
        public float thanhTien { get; set; }
        public int maDonHang { get; set; }

        // Constructor không tham số
        public DTO_HoaDonDonHang()
        {
        }
        // Constructor với tham số
        public DTO_HoaDonDonHang(int maCTHD, string tenMon, float giaMon, int soLuong,  float thanhTien, int maHoaDon, int maDonHang)
        {
            this.maCTHD = maCTHD;
            this.tenMon = tenMon;
            this.giaMon = giaMon;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
            this.maDonHang = maDonHang;
        }
    }
}
