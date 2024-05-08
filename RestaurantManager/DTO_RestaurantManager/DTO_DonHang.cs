using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_DonHang
    {
        public int maDonHang { get; set; }
        public bool trangThai { get; set; }
        public DateTime ngayDat { get; set; }
        public int maKH { get; set; }
        public int maNVSale { get; set; }
        public int maMonAn { get; set; }

        // Constructor không tham số
        public DTO_DonHang()
        {
            // Khởi tạo ngày đặt là ngày hiện tại
            this.ngayDat = DateTime.Now;
        }

        // Constructor với tham số
        public DTO_DonHang(int maDonHang, bool trangThai, DateTime ngayDat, int maKH, int maNVSale, int maMonAn)
        {
            this.maDonHang = maDonHang;
            this.trangThai = trangThai;
            this.ngayDat = ngayDat;
            this.maKH = maKH;
            this.maNVSale = maNVSale;
            this.maMonAn = maMonAn;
        }
    }
}
