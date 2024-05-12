using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_NguoiDung
    {
        public int idNguoiDung { get; set; }
        public string tenNguoiDung { get; set; }
        public string email { get; set; }
        public string diaChi { get; set; }
        public DateTime namSinh { get; set; }
        public string soDienThoai { get; set; }

      
        public DTO_NguoiDung()
        {
        }

        public DTO_NguoiDung( string tenNguoiDung, string email, string diaChi, string soDienThoai)
        {
            this.tenNguoiDung = tenNguoiDung;
            this.email = email;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
        }
        public DTO_NguoiDung(string tenNguoiDung, string email, string soDienThoai)
        {
            this.tenNguoiDung = tenNguoiDung;
            this.email = email;
            this.soDienThoai = soDienThoai;
        }
        public DTO_NguoiDung(int idNguoiDung, string tenNguoiDung, string email, string soDienThoai)
        {
            this.idNguoiDung= idNguoiDung;
            this.tenNguoiDung= tenNguoiDung;
            this.email = email;
            this.soDienThoai= soDienThoai;
        }
        public DTO_NguoiDung(int idNguoiDung, string tenNguoiDung, string email, string diaChi, DateTime namSinh, string soDienThoai)
        {
            this.idNguoiDung = idNguoiDung;
            this.tenNguoiDung = tenNguoiDung;
            this.email = email;
            this.diaChi = diaChi;
            this.namSinh = namSinh;
            this.soDienThoai = soDienThoai;
        }
    }
}
