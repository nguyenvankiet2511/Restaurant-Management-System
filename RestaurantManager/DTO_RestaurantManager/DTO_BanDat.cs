using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_BanDat
    {
        public int maBanDat {  get; set; }
        public int soLuongNguoi { get; set; }
        public int viTri { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }
        public DateTime thoiGian { get; set; }
        public int maKH { get; set; }
        public int maNV { get; set; }
        public DTO_BanDat() { }
        public DTO_BanDat( int maKH, int maNV)
        {           
            this.maKH = maKH;
            this.maNV = maNV;
        }
        public DTO_BanDat( int soLuongNguoi, int viTri, string ghiChu, DateTime thoiGian, int maKH, int maNV) 
        {
            this.soLuongNguoi = soLuongNguoi;
            this.viTri = viTri;
            this.ghiChu = ghiChu;
            this.thoiGian = thoiGian;
            this.maKH = maKH;
            this.maNV = maNV;
        }
        public DTO_BanDat(int soLuongNguoi, int viTri, DateTime thoiGian, int maNV)
        {
            this.soLuongNguoi = soLuongNguoi;
            this.viTri = viTri;
            this.thoiGian = thoiGian;
            this.maNV= maNV;
        }
        public DTO_BanDat(int maBanDat, int soLuongNguoi, int viTri, DateTime thoiGian)
        {
            this.maBanDat = maBanDat;
            this.soLuongNguoi = soLuongNguoi;
            this.viTri = viTri;
            this.thoiGian = thoiGian;
        }
        public DTO_BanDat( int maBanDat,int soLuongNguoi, int viTri ,DateTime thoiGian, int maNV,int maKH) 
        {
            this.maBanDat = maBanDat;
            this.soLuongNguoi= soLuongNguoi;
            this.viTri = viTri;
            this.thoiGian = thoiGian;
            this.maKH = maKH;
            this.maNV = maNV;
        }

    }
}
