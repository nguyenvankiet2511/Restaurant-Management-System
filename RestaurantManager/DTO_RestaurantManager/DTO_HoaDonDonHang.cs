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
        public int giaMon { get; set; }
        public int soLuong { get; set; }
        public int thanhTien { get; set; }
        public int maDonHang { get; set; }

        // Constructor không tham số
        public DTO_HoaDonDonHang()
        {
        }
        // Constructor với tham số
        public DTO_HoaDonDonHang( string tenMon, int giaMon, int soLuong,  int thanhTien, int maDonHang)
        {
            this.tenMon = tenMon;
            this.giaMon = giaMon;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
            this.maDonHang = maDonHang;
        }
    }
}
