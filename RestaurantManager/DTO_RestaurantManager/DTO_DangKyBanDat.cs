using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_DangKyBanDat
    {
        public int maDK { get; set; }
        public int soLuongNguoi { get; set; }
        public int viTri { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }
        public DateTime thoiGian { get; set; }
        // Constructor không tham số
        public DTO_DangKyBanDat()
        {
        }

        // Constructor với tham số
        public DTO_DangKyBanDat( int soLuongNguoi, int viTri, string ghiChu, DateTime thoiGian)
        {
            this.soLuongNguoi = soLuongNguoi;
            this.viTri = viTri;
            this.ghiChu = ghiChu;
            this.thoiGian = thoiGian;
             
        }
    }
}
