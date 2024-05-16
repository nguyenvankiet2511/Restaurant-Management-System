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
        public DateTime ngayXacNhan { get; set; }  
        public int soLuong {  get; set; }
        public int maKH { get; set; }
        public int maNVSale { get; set; }
        public int maMonAn { get; set; }

        // Constructor không tham số
        public DTO_DonHang()
        {
            // Khởi tạo ngày đặt là ngày hiện tại
            this.ngayXacNhan = DateTime.Now;
        }
        public DTO_DonHang( DateTime ngayDat, int soLuong, int maKH, int maMonAn, int maNVSale)
        {
            this.ngayDat = ngayDat;
            this.soLuong = soLuong;
            this.maKH = maKH;
            this.maMonAn = maMonAn;
            this.maNVSale = maNVSale;
        }
        // Constructor với tham số
        public DTO_DonHang(int maDonHang,DateTime ngayDat,DateTime ngayXacNhan,int soLuong, int maKH, int maMonAn)
        {
            this.maDonHang = maDonHang;
            this.ngayDat = ngayDat;
            this.ngayXacNhan=ngayXacNhan;
            this.soLuong=soLuong;
            this.maKH = maKH;
            this.maMonAn = maMonAn;
        }
    }
}
