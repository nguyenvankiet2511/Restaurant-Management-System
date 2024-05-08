using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_HoaDon
    {
        public int maHoaDon { get; set; }
        public DateTime ngayLap { get; set; }
        public string loaiHoaDon { get; set; }
        public string moTa { get; set; }
        public float thanhTien { get; set; }
        public int maNVTN { get; set; }

        // Constructor không tham số
        public DTO_HoaDon()
        {
            // Khởi tạo ngày lập là ngày hiện tại
            this.ngayLap = DateTime.Now.Date;
        }

        // Constructor với tham số
        public DTO_HoaDon(int maHoaDon, DateTime ngayLap, string loaiHoaDon, string moTa, float thanhTien, int maNVTN)
        {
            this.maHoaDon = maHoaDon;
            this.ngayLap = ngayLap;
            this.loaiHoaDon = loaiHoaDon;
            this.moTa = moTa;
            this.thanhTien = thanhTien;
            this.maNVTN = maNVTN;
        }
    }
}
