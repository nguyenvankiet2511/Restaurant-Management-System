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
        public string moTa { get; set; }
        public int thanhTien { get; set; }
        public int maNVTN { get; set; }
         
        public int maBanDat {  get; set; }

        // Constructor không tham số
        public DTO_HoaDon()
        {
            // Khởi tạo ngày lập là ngày hiện tại
            this.ngayLap = DateTime.Now.Date;
        }
        public DTO_HoaDon(int thanhTien, int maNVTN, int maBanDat)
        {
            this.thanhTien = thanhTien;
            this.maNVTN = maNVTN;
            this.maBanDat = maBanDat;
        }
        // Constructor với tham số
        public DTO_HoaDon(int maHoaDon, DateTime ngayLap,  string moTa, int thanhTien, int maNVTN)
        {
            this.maHoaDon = maHoaDon;
            this.ngayLap = ngayLap;

            this.moTa = moTa;
            this.thanhTien = thanhTien;
            this.maNVTN = maNVTN;
        }
    }
}
