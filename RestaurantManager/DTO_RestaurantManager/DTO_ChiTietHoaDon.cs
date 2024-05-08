using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_ChiTietHoaDon
    {
        public int maCTHD { get; set; }
        public string tenMon { get; set; }
        public float giaMon { get; set; }
        public int soLuong { get; set; }
        public float thue { get; set; }
        public float thanhTien { get; set; }
        public int maHoaDon { get; set; }
        public int maDonHang { get; set; }

        // Constructor không tham số
        public DTO_ChiTietHoaDon()
        {
        }
        // Constructor với tham số
        public DTO_ChiTietHoaDon(int maCTHD, string tenMon, float giaMon, int soLuong, float thue, float thanhTien, int maHoaDon, int maDonHang)
        {
            this.maCTHD = maCTHD;
            this.tenMon = tenMon;
            this.giaMon = giaMon;
            this.soLuong = soLuong;
            this.thue = thue;
            this.thanhTien = thanhTien;
            this.maHoaDon = maHoaDon;
            this.maDonHang = maDonHang;
        }
    }
}
