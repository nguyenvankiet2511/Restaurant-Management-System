using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_DanhSachDonHang
    {
        public int maDSDH { get; set; }      
        public DateTime ngayDat { get; set; }   
        public string tenMon { get; set; }     
        public int soLuong { get; set; }      
        public int maMonAn { get; set; }        
        public int maKH { get; set; }          

        // Constructor
        public DTO_DanhSachDonHang()
        {
            ngayDat = DateTime.Now; 
        }
        public DTO_DanhSachDonHang(int maDSDH,string tenMon, int soLuong, int maMonAn)
        {
            this.maDSDH = maDSDH;
            this.tenMon = tenMon;
            this.soLuong = soLuong;
            this.maMonAn = maMonAn;
        }
        public DTO_DanhSachDonHang(  string tenMon, int soLuong, int maMonAn, int maKH)
        {
            this.tenMon = tenMon;
            this.soLuong = soLuong;
            this.maMonAn = maMonAn;
            this.maKH = maKH;
        }
        public DTO_DanhSachDonHang(int maDSDH, DateTime ngayDat, string tenMon, int soLuong, int maMonAn, int maKH)
        {
            this.maDSDH = maDSDH;
            this.ngayDat = ngayDat;
            this.tenMon = tenMon;
            this.soLuong = soLuong;
            this.maMonAn = maMonAn;
            this.maKH = maKH;
        }
    }

}
