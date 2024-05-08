using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_BanDat
    {
        public int maBanDat { get; set; }
        public int soLuongNguoi { get; set; }
        public int viTri { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }
        public int maNVTT { get; set; }
        public int maKH { get; set; }
        public int maThucDon { get; set; }
        public int thoiGianId { get; set; }

        // Constructor không tham số
        public DTO_BanDat()
        {
        }

        // Constructor với tham số
        public DTO_BanDat(int maBanDat, int soLuongNguoi, int viTri, string ghiChu, bool trangThai, int maNVTT, int maKH, int maThucDon, int thoiGianId)
        {
            this.maBanDat = maBanDat;
            this.soLuongNguoi = soLuongNguoi;
            this.viTri = viTri;
            this.ghiChu = ghiChu;
            this.trangThai = trangThai;
            this.maNVTT = maNVTT;
            this.maKH = maKH;
            this.maThucDon = maThucDon;
            this.thoiGianId = thoiGianId;
        }
    }
}
